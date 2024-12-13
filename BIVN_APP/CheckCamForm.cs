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


        public CheckCamForm()
        {
            InitializeComponent();
            comboBoxCamera.Items.Clear();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo info in filterInfoCollection)
            {
                comboBoxCamera.Items.Add(info.Name);
            }
            if (comboBoxCamera.Items.Count > 0)
                comboBoxCamera.SelectedIndex = 0;
            else
                MessageBox.Show("Không có thiết bị camera nào được phát hiện!");
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
