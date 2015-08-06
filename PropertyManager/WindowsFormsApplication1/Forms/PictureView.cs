using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PictureView : Form
    {
        Bitmap bitmap;

        public PictureView(Bitmap bmp)
        {
            InitializeComponent();
            bitmap = bmp;
            pictureBox1.Image = bitmap;
        }

        private void saveImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Bitmap bmp = new Bitmap(bitmap);
            string filename = saveFileDialog1.FileName;
            string extension = filename.Split('.').Last();
            bmp.Save(filename);
        }
    }
}
