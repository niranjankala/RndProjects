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

namespace ImageEditor
{
    public partial class ImageOperationsForm : Form
    {
        public ImageOperationsForm()
        {
            InitializeComponent();
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.TIF)|*.BMP;*.JPG;*.GIF;*.TIF|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        txtImagePath.Text = dialog.FileName;
                        pbxImage.Image = Image.FromFile(txtImagePath.Text);

                        Properties.Settings.Default.ImagePath = txtImagePath.Text;
                        Properties.Settings.Default.Save();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void ImageOperationsForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtImagePath.Text = Properties.Settings.Default.ImagePath;
                if (!string.IsNullOrWhiteSpace(txtImagePath.Text) && File.Exists(txtImagePath.Text))
                {
                    pbxImage.Image = Image.FromFile(txtImagePath.Text);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
