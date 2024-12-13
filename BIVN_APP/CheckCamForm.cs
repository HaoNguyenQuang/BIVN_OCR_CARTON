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

namespace BIVN_APP
{
    public partial class CheckCamForm : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        private Bitmap _screenshot;
        private List<Bitmap> screenshotList = new List<Bitmap>();


        public CheckCamForm(Bitmap screenshot, List<Bitmap> imageList)
        {
            InitializeComponent();
            comboBoxCamera.Items.Clear();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            _screenshot = screenshot;
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
            _screenshot = screenshot;
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
            // Xóa các mục cũ trong ComboBox (nếu cần)
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
                    pictureBoxCamera.Image = (Bitmap)e.Frame.Clone();
                }));
            }
            else
            {
                pictureBoxCamera.Image = (Bitmap)e.Frame.Clone();
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

    }
}
