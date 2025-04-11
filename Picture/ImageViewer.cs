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

namespace Picture
{
    public partial class ImageViewer : Form
    {
        public ImageViewer()
        {
            InitializeComponent();
        }

        private void loadFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.SelectedPath;
                string[] files = Directory.GetFiles(path);

                flowLayoutPanel1.Controls.Clear(); // Xoá ảnh cũ nếu có

                foreach (var file in files)
                {
                    if (file.EndsWith(".jpg") || file.EndsWith(".png"))
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Cursor = Cursors.Hand;
                        pictureBox.Load(file);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Width = 100;
                        pictureBox.Height = 100;
                        pictureBox.Tag = file;

                        pictureBox.Click += pictureBox1_Click;

                        flowLayoutPanel1.Controls.Add(pictureBox);
                    }
                }
            }
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                string imgPath = pictureBox.Tag.ToString();
                pictureBox1.Load(imgPath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                labelDC.Text = "File " + imgPath + " is loaded.";
            }
        }

    }
}
