using KAutoHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonaryAuto
{
    public partial class Form1 : Form
    {
        private const String appName = "Dragonary";
        Util util = new Util();
        StoryStart mission = new StoryStart();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public Form1()
        {
            InitializeComponent();
        }

        private void handleGameStart()
        {
            bool result = false;
            while (true && result != true)
            {
                result = util.handleMouseClickPoint("mission-new.png");
                bool isStory = storyRdBtn.Checked;
                if (isStory)
                {
                    mission.handleStoryStart();
                }
                else
                {
                    //bool resul = handleMouseClick(handleFindImage("embers.png"));
                }
            }
        }


        private void startBtn_Click(object sender, EventArgs e)
        {
            try
            {
                handleGameStart();
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
       
        //private void mouseTimer_Tick(object sender, EventArgs e)
        //{
        //    String xMouse = Cursor.Position.X.ToString();
        //    String YMouse = Cursor.Position.Y.ToString();

        //    xMouseTxt.Text = xMouse;
        //    yMouseTxt.Text = YMouse;
        //}
    }
}
