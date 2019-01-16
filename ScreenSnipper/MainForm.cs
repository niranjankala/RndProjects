using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSnipper
{
    /// <summary>
    /// References:
    /// https://social.msdn.microsoft.com/Forums/vstudio/en-US/6a3621a4-18c5-4ffe-b694-56efc72f60b4/using-copyfromscreen-returns-different-images-when-text-size-changes?forum=vbgeneral
    /// https://social.msdn.microsoft.com/Forums/sharepoint/en-US/6acc3b21-23a4-4a00-90b4-968a43e1ccc8/capture-screen-with-high-dpi?forum=vbgeneral
    /// https://www.cyotek.com/blog/capturing-screenshots-using-csharp-and-p-invoke 
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = graphics3dViewControl.TakeSnapshot();
            //pictureBox1.Image = graphics3dViewControl.CaptureArea();
            pictureBox1.Image = graphics3dViewControl.CaptureScreen();
        }

       

    }
}
