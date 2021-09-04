using KAutoHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DragonaryAuto
{
    public class Util
    {
        private const String appName = "Dragonary";
        private IntPtr hwnd = IntPtr.Zero;
        private const String prefix = "assets/";
        public Util()
        {
            setWindowHandle();
        }

        private void setWindowHandle()
        {
            hwnd = AutoControl.FindWindowHandle(null, appName);
        }

        private IntPtr getWindowHandle()
        {
            return hwnd;
        }


        public Point? handleFindImage(String image)
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(prefix + image);
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);

            return resBitmap;
        }

        public bool handleMouseClick(Point? point)
        {
            if (point != null)
            {
                AutoControl.MouseClick(point.Value, EMouseKey.LEFT);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool handleMouseClickPoint(String image)
        {
            var screen = CaptureHelper.CaptureScreen();
            var subBitmap = ImageScanOpenCV.GetImage(prefix + image);
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);

            if (resBitmap != null)
            {
                int xCoord = resBitmap.Value.X + subBitmap.Width / 2;
                int yCoord = resBitmap.Value.Y + subBitmap.Height/ 2;
                if (image == "mission-new.png" || image == "mission-8.png") AutoControl.MouseClick(resBitmap.Value.X + 20, resBitmap.Value.Y + 20, EMouseKey.LEFT);
                else AutoControl.MouseClick(xCoord, yCoord, EMouseKey.LEFT);

                return true;
            }
            else
            {
                return false;
            }
        }

        public void SendLeftClick()
        {

            var screen = CaptureHelper.CaptureWindow(hwnd);
            var subBitmap = ImageScanOpenCV.GetImage("assets/mission-new.png");
            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);

            AutoControl.SendClickDownOnPosition(hwnd, resBitmap.Value.X, resBitmap.Value.Y, EMouseKey.LEFT);
            //AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y, EMouseKey.LEFT);

        }
    }
}
