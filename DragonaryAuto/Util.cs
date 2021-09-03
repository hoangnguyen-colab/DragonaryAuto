﻿using KAutoHelper;
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

        public bool handleMouseArray(string type)
        {
            //string[] imageArray = new Constants().storyImages;
            //switch (type)
            //{
            //    case "story":
            //        {
            //            imageArray = new Constants().storyImages;
            //            break;
            //        }
            //    case "embers":
            //        {
            //            imageArray = new Constants().storyImages;
            //            break;
            //        }
            //    default:
            //        break;
            //}
            var screen = CaptureHelper.CaptureScreen();
            foreach (var image in new Constants().storyImages)
            {
                var subBitmap = ImageScanOpenCV.GetImage(prefix + image);
                var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
                if (resBitmap != null)
                {
                    AutoControl.MouseClick(resBitmap.Value, EMouseKey.LEFT);
                    //return true;
                }
            }
            return false;
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
                if (image == "mission-new.png") AutoControl.MouseClick(resBitmap.Value.X + 20, resBitmap.Value.Y + 20, EMouseKey.LEFT);
                else AutoControl.MouseClick(resBitmap.Value, EMouseKey.LEFT);

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
