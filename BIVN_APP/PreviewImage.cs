using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIVN_APP
{
    public partial class PreviewImage : Form
    {
        private Bitmap _screenshot;
        public PreviewImage(Bitmap screenshot)
        {
            InitializeComponent();
            _screenshot = screenshot;

            // Gán ảnh vào PictureBox hoặc bất kỳ điều khiển nào trong form để hiển thị ảnh
            picturePreview.Image = _screenshot;
            //picturePreview.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
