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
    public partial class OCRResultForm : Form
    {
        public OCRResultForm(string ocrResult)
        {
            InitializeComponent();
            richTextBoxResult.Text = ocrResult;
        }
    }
}
