using KAutoHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonaryAuto
{
    class ItemPosition
    {
        public Point MissionPos(IntPtr hwnd)
        {
            if (hwnd != null)
            {
                int x = 450;
                int y = 420;
                return AutoControl.GetGlobalPoint(hwnd, x, y);
            } else
            {
                return new Point();
            }
        }
        public Point StoryPos(IntPtr hwnd)
        {
            if (hwnd != null)
            {
                int x = 150;
                int y = 380;
                return AutoControl.GetGlobalPoint(hwnd, x, y);
            }
            else
            {
                return new Point();
            }
        }
    }
}