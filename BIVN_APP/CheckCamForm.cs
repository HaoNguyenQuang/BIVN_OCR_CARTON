using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Ocl;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using Newtonsoft.Json;
using Tesseract;


namespace BIVN_APP
{
    public partial class CheckCamForm : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        private Bitmap _screenshot;
        private List<Bitmap> screenshotList = new List<Bitmap>();
        public string resultOCRImage;
        public string resultOCRCamera;
        public string language = "ara+chi_sim+chi_sim_vert+deu+deu_frak+deu_latf+eng+fra+jpn+jpn_vert+kor+kor_vert+rus+spa+spa_old+tha+vie";
        //public string language;
        //public class Config
        //{
        //    public string Languages { get; set; }
        //}

        //public string LoadLanguageFromConfig()
        //{
        //    try
        //    {
        //        string filePath = @"E:\OCR_CARTON\configs.json";
        //        if (!File.Exists(filePath))
        //        {
        //            MessageBox.Show("File cấu hình không tồn tại. Sử dụng ngôn ngữ mặc định: eng");
        //            return "eng";
        //        }

        //        string jsonContent = File.ReadAllText(filePath);
        //        var config = JsonConvert.DeserializeObject<Config>(jsonContent);

        //        if (config != null && !string.IsNullOrEmpty(config.Languages))
        //        {
        //            return config.Languages;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Nội dung file cấu hình không hợp lệ. Sử dụng ngôn ngữ mặc định: eng");
        //            return "eng";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi đọc file cấu hình: " + ex.Message);
        //        return "eng";
        //    }
        //}
    



    public CheckCamForm(Bitmap screenshot, List<Bitmap> imageList)
        {
            InitializeComponent();
            comboBoxCamera.Items.Clear();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            _screenshot = screenshot ?? new Bitmap(100, 100); ;
            pictureBoxImage.Image = _screenshot;
            LoadImagesToComboBox(imageList);
            foreach (FilterInfo info in filterInfoCollection)
            {
                comboBoxCamera.Items.Add(info.Name);
            }
            if (comboBoxCamera.Items.Count > 0)
                comboBoxCamera.SelectedIndex = 0;
            else
                MessageBox.Show("Không có thiết bị camera nào được phát hiện!");
        }
        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy ảnh tương ứng với vùng được chọn và hiển thị trong PictureBox
            int selectedIndex = comboBoxRegion.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < screenshotList.Count)
            {
                pictureBoxImage.Image = screenshotList[selectedIndex];
            }
        }

        private void LoadImagesToComboBox(List<Bitmap> imageList)
        {
            if (imageList == null || imageList.Count == 0)
            {
                MessageBox.Show("Danh sách ảnh trống! Đang khởi tạo danh sách mặc định.");
                imageList = null;
            }
            comboBoxRegion.Items.Clear();
            screenshotList = imageList;

            for (int i = 0; i < screenshotList.Count; i++)
            {
                comboBoxRegion.Items.Add($"Vùng {i + 1}");
            }

            if (comboBoxRegion.Items.Count > 0)
            {
                comboBoxRegion.SelectedIndex = 0;
            }
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            if (comboBoxCamera.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn camera để bắt đầu!");
                return;
            }
            if (captureDevice != null && captureDevice.IsRunning)
            {
                try
                {
                    // Dừng camera cũ trong luồng nền
                    await Task.Run(() =>
                    {
                        captureDevice.SignalToStop();
                        captureDevice.WaitForStop();
                        pictureBoxCamera.Image = null;
                        captureDevice = null;
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi khi dừng camera: {ex.Message}");
                    return;  // Nếu có lỗi khi dừng camera, không tiếp tục bắt đầu camera mới
                }
            }
            float zoomValue = 1;
            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboBoxCamera.SelectedIndex].MonikerString);
            captureDevice.DisplayPropertyPage(IntPtr.Zero);
            captureDevice.SetCameraProperty(
                CameraControlProperty.Zoom,
                5,
                CameraControlFlags.Manual);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs e)
        {
            if (pictureBoxCamera.InvokeRequired)
            {
                pictureBoxCamera.Invoke(new Action(() =>
                {
                    Bitmap frame = (Bitmap)e.Frame.Clone();
                    pictureBoxCamera.Image = frame;
                }));
            }
            else
            {
                Bitmap frame = (Bitmap)e.Frame.Clone();
                pictureBoxCamera.Image = frame;

            }
        }

        private async void buttonStop_Click(object sender, EventArgs e)
        {
            if (captureDevice != null && captureDevice.IsRunning)
            {
                try
                {
                    await Task.Run(() =>
                    {
                        captureDevice.SignalToStop();
                        captureDevice.WaitForStop();
                        pictureBoxCamera.Image = null;
                        captureDevice = null;
                    });

                    pictureBoxCamera.Invoke(new Action(() =>
                    {
                        pictureBoxCamera.Image = null;
                    }));

                    MessageBox.Show("Camera đã dừng.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi khi dừng camera: {ex.Message}");
                }

            }
        }
        private void PerformOCR()
        {
            if (pictureBoxImage.Image != null)
            {
                try
                {
                    //language = LoadLanguageFromConfig();
                    string tessdataPath = @"E:\OCR_CARTON\tessdata-main\tessdata-main";

                    using (var ocr = new TesseractEngine(tessdataPath, language, EngineMode.Default))
                    {
                        Bitmap bitmap = (Bitmap)pictureBoxImage.Image;
                        using (Tesseract.Pix pixImage = Tesseract.Pix.LoadFromMemory(BitmapToBytes(bitmap)))
                        {
                            using (var page = ocr.Process(pixImage))
                            {
                                resultOCRImage = page.GetText();
                                OCRResultForm resultForm = new OCRResultForm(resultOCRImage);
                                resultForm.Show();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện OCR: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không có ảnh để thực hiện OCR.");
            }
        }
        private byte[] BitmapToBytes(Bitmap bitmap)
        {
            using (var ms = new MemoryStream())
            {
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                return ms.ToArray();
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            PerformOCR();
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (pictureBoxCamera.Image != null)
            {
                try
                {
                    // Chuyển hình ảnh trong PictureBox thành Bitmap
                    Bitmap bitmap = (Bitmap)pictureBoxCamera.Image;

                    string tessdataPath = @"E:\OCR_CARTON\tessdata-main\tessdata-main";
                    //language = LoadLanguageFromConfig();
                    using (var ocr = new TesseractEngine(tessdataPath, language, EngineMode.Default))
                    {

                        using (Tesseract.Pix pixImage = Tesseract.Pix.LoadFromMemory(BitmapToBytes(bitmap)))
                        {
                            // Thực hiện nhận diện văn bản
                            using (var page = ocr.Process(pixImage))
                            {
                                resultOCRCamera = page.GetText();
                                OCRResultForm resultForm = new OCRResultForm(resultOCRCamera);
                                resultForm.Show();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện OCR: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không có ảnh để thực hiện OCR.");
            }
        }
    }
}
