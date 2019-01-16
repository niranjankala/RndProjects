using ScreenSnipper.Win32API;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ScreenSnipper
{
    internal sealed class ScreenshotSnipper
    {
        #region Methods

        public Bitmap CaptureActiveWindow()
        {
            return this.CaptureWindow(Win32APICalls.GetForegroundWindow());
        }

        public Bitmap CaptureDesktop()
        {
            return this.CaptureDesktop(false);
        }

        public Bitmap CaptureDesktop(bool workingAreaOnly)
        {
            Rectangle desktop;
            Screen[] screens;

            desktop = Rectangle.Empty;
            screens = Screen.AllScreens;

            // ReSharper disable once LoopCanBeConvertedToQuery
            for (int i = 0; i < screens.Length; i++)
            {
                Screen screen;

                screen = screens[i];

                desktop = Rectangle.Union(desktop, workingAreaOnly ? screen.WorkingArea : screen.Bounds);
            }

            return this.CaptureRegion(desktop);
        }

        public Bitmap CaptureMonitor(Screen monitor)
        {
            return this.CaptureMonitor(monitor, false);
        }

        public Bitmap CaptureMonitor(Screen monitor, bool workingAreaOnly)
        {
            Rectangle region;

            region = workingAreaOnly ? monitor.WorkingArea : monitor.Bounds;

            return this.CaptureRegion(region);
        }

        public Bitmap CaptureMonitor(int index)
        {
            return this.CaptureMonitor(index, false);
        }

        public Bitmap CaptureMonitor(int index, bool workingAreaOnly)
        {
            return this.CaptureMonitor(Screen.AllScreens[index], workingAreaOnly);
        }

        public Bitmap CaptureRegion(Rectangle region)
        {
            IntPtr desktophWnd;
            IntPtr desktopDc;
            IntPtr memoryDc;
            IntPtr bitmap;
            IntPtr oldBitmap;
            bool success;
            Bitmap result;

            desktophWnd = Win32APICalls.GetDesktopWindow();
            desktopDc = Win32APICalls.GetWindowDC(desktophWnd);
            memoryDc = Win32APICalls.CreateCompatibleDC(desktopDc);
            bitmap = Win32APICalls.CreateCompatibleBitmap(desktopDc, region.Width, region.Height);
            oldBitmap = Win32APICalls.SelectObject(memoryDc, bitmap);

            success = Win32APICalls.BitBlt(memoryDc, 0, 0, region.Width, region.Height, desktopDc, region.Left, region.Top, RasterOperations.SRCCOPY | RasterOperations.CAPTUREBLT);

            try
            {
                if (!success)
                {
                    throw new Win32Exception();
                }

                result = Image.FromHbitmap(bitmap);
            }
            finally
            {
                Win32APICalls.SelectObject(memoryDc, oldBitmap);
                Win32APICalls.DeleteObject(bitmap);
                Win32APICalls.DeleteDC(memoryDc);
                Win32APICalls.ReleaseDC(desktophWnd, desktopDc);
            }

            return result;
        }

        public Bitmap CaptureWindow(IntPtr hWnd)
        {
            Win32APICalls.RECT region;

            if (Environment.OSVersion.Version.Major < 6)
            {
                Win32APICalls.GetWindowRect(hWnd, out region);
            }
            else
            {
                if (Win32APICalls.DwmGetWindowAttribute(hWnd, Win32APICalls.DWMWA_EXTENDED_FRAME_BOUNDS, out region, Marshal.SizeOf(typeof(Win32APICalls.RECT))) != 0)
                {
                    Win32APICalls.GetWindowRect(hWnd, out region);
                }
            }

            return this.CaptureRegion(Rectangle.FromLTRB(region.left, region.top, region.right, region.bottom));
        }

        public Bitmap CaptureWindow(Form form)
        {
            return this.CaptureWindow(form.Handle);
        }

        #endregion
    }

}
