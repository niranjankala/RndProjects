using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ScreenSnipper
{
    public partial class Graphics3dView : UserControl
    {
        public Graphics3dView()
        {
            InitializeComponent();
        }
        internal Bitmap TakeSnapshot()
        {
            Refresh();

            try
            {
                Rectangle rect = this.RectangleToScreen(this.ClientRectangle);
                Bitmap screenShotBMP = new Bitmap(rect.Width - 2, rect.Height, PixelFormat.Format32bppArgb);
                Graphics screenShotGraphics = Graphics.FromImage(screenShotBMP);
                screenShotGraphics.CopyFromScreen(rect.X, rect.Y, 0, 0, ClientRectangle.Size, CopyPixelOperation.SourceCopy);

                //screenShotBMP = CaptureWindow(this.picImage.Handle);
                Size size = new Size(210, 210);
                Bitmap imgresized = FixedSize(screenShotBMP, size.Width, size.Height); //new Bitmap(screenShotBMP, size);
                screenShotGraphics.Dispose();
                //using (Form frm = new Form())
                //{
                //    frm.Size = new Size(640, 250);
                //    PictureBox pictureBox = new PictureBox();
                //    pictureBox.Width = 320;
                //    pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                //    pictureBox.Dock = DockStyle.Left;
                //    PictureBox pictureBox1 = new PictureBox();
                //    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                //    pictureBox1.Width = 320;
                //    pictureBox1.Dock = DockStyle.Right;
                //    frm.Controls.Add(pictureBox);
                //    frm.Controls.Add(pictureBox1);
                //    pictureBox1.BringToFront();
                //    pictureBox.Image = screenShotBMP;
                //    pictureBox1.Image = imgresized;
                //    frm.StartPosition = FormStartPosition.CenterParent;                    
                //    frm.ShowDialog(this);
                //}               
                return screenShotBMP;
                //return imgresized;
            }
            finally
            {
                Refresh();
            }
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rectangle rect);


        public Bitmap CaptureWindow(IntPtr handle)
        {
            var rect = new Rectangle();
            GetWindowRect(this.Handle, ref rect);
            var bounds = new Rectangle(rect.Left, rect.Top, Math.Abs(rect.Right - rect.Left), Math.Abs(rect.Bottom - rect.Top));
            var result = new Bitmap(bounds.Width, bounds.Height);

            using (var graphics = Graphics.FromImage(result))
            {
                graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            }

            return result;
        }
        static Bitmap FixedSize(Bitmap imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((Width -
                              (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height -
                              (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(Width, Height,
                              PixelFormat.Format32bppArgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                             imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            //grPhoto.Clear(Color.White);
            grPhoto.Clear(Color.FromArgb(239, 239, 239)); //# EDEDE9
            grPhoto.InterpolationMode =
                    System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

        private const int DESKTOPVERTRES = 0x75;
        private const int DESKTOPHORZRES = 0x76;

        [DllImport("gdi32.dll")]
        private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);


        public Bitmap CaptureArea()
        {
            double Xscale = 1.0;
            double Yscale = 1.0;

            using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
            {
                IntPtr hDc = g.GetHdc();
                Xscale = (GetDeviceCaps(hDc, DESKTOPHORZRES) / (double)Screen.FromControl(this).Bounds.Width);
                Yscale = (GetDeviceCaps(hDc, DESKTOPVERTRES) / (double)Screen.FromControl(this).Bounds.Height);
                g.ReleaseHdc(hDc);
            }
            //Rectangle picBounds = this.RectangleToScreen(this.ClientRectangle);
            Rectangle picBounds = new Rectangle(this.PointToScreen(this.ClientRectangle.Location), this.ClientSize);

            double xDelta = Math.Abs(((picBounds.X * Xscale) - picBounds.X))/Xscale;
            double yDelta = Math.Abs(((picBounds.Y * Yscale) - picBounds.Y))/Yscale;

            picBounds.X = System.Convert.ToInt32(picBounds.X +xDelta);
            picBounds.Y = System.Convert.ToInt32(picBounds.Y + yDelta);
            picBounds.Width = System.Convert.ToInt32(picBounds.Width * Xscale);
            picBounds.Height = System.Convert.ToInt32(picBounds.Height * Yscale);

            Bitmap bm = new Bitmap(picBounds.Width, picBounds.Height);
            {
                using (Graphics g = Graphics.FromImage(bm))
                {
                    g.CopyFromScreen(picBounds.Location, Point.Empty, picBounds.Size, CopyPixelOperation.SourceCopy);
                }
            }
            return bm;
        }
        public Image CaptureScreenArea()
        {
            ScreenshotSnipper capture;
            capture = new ScreenshotSnipper();
            //return capture.CaptureRegion(this.CaptureScreenArea);
            var rectf = this.client;
            return capture.CaptureRegion(this.RectangleToScreen(new Rectangle((int)rectf.X, (int)rectf.Y, (int)rectf.Width, (int)rectf.Height)));
        }
    }
}
