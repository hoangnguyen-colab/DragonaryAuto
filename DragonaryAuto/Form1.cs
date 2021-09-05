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
        Constants constanst = new Constants();
        private CancellationTokenSource cancellationToken;
        private bool _stopLoop = false;


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public Form1()
        {
            InitializeComponent();
            versionTxt.Text = "ver: " + (constanst.isDev ? constanst.devAppVersion : constanst.publicAppVersion);
        }

        private void ToggleBtn(string type)
        {
            switch (type)
            {
                case "start":
                    {
                        startBtn.Enabled = false;
                        ingameAutoBtn.Enabled = false;
                        cancelBtn.Enabled = true;
                        cancelBtn.Text = "Stop Story Auto";
                        _stopLoop = false;
                        break;
                    }
                case "start-ingame":
                    {
                        startBtn.Enabled = false;
                        ingameAutoBtn.Enabled = false;
                        cancelBtn.Enabled = true;
                        cancelBtn.Text = "Stop Ingame Auto";
                        _stopLoop = false;
                        break;
                    }
                case "stop":
                    {
                        _stopLoop = true;
                        startBtn.Enabled = true;
                        ingameAutoBtn.Enabled = true;
                        cancelBtn.Enabled = false;
                        cancelBtn.Text = "Stop";
                        cancellationToken.Cancel();
                        break;
                    }
                default:
                    break;
            }
        }

        private async Task handleGameStart()
        {
            cancellationToken = new CancellationTokenSource();

            while (!_stopLoop)
            {
                await Task.Run(() =>
                {
                    new StoryStart().handleStoryStart(_stopLoop);
                }, cancellationToken.Token);
            }

            ToggleBtn("stop");
        }

        private async Task handleInGameStart()
        {
            cancellationToken = new CancellationTokenSource();

            await Task.Run(() =>
            {
                new StoryStart("ingame").handleIngameContinue(_stopLoop);
            }, cancellationToken.Token);

            ToggleBtn("stop");
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

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ToggleBtn("start-ingame");
                await handleInGameStart();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
