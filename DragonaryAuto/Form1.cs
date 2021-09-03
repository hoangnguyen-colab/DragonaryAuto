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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonaryAuto
{
    public partial class Form1 : Form
    {
        StoryStart mission = new StoryStart();
        private CancellationTokenSource cancellationToken;
        private bool _stopLoop = false;


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public Form1()
        {
            InitializeComponent();
        }

        private async Task handleGameStart()
        {
            cancellationToken = new CancellationTokenSource();

            while (!_stopLoop)
            {
                await Task.Run(() =>
                {
                    mission.handleStoryStart(_stopLoop);
                }, cancellationToken.Token);
            }
        }
        private async void startBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ToggleBtn("start");
                await handleGameStart();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (cancellationToken != null)
            {
                ToggleBtn("stop");
            }
        }

        private void ToggleBtn(string type)
        {
            switch (type)
            {
                case "start":
                    {
                        startBtn.Enabled = false;
                        cancelBtn.Enabled = true;
                        _stopLoop = false;
                        break;
                    }
                case "stop":
                    {
                        _stopLoop = true;
                        startBtn.Enabled = true;
                        cancelBtn.Enabled = false;
                        cancellationToken.Cancel();
                        break;
                    }
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Util().SendLeftClick();
        }
    }
}
