using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Recran
{
    public partial class Main_Form : MaterialForm
    {
        private Thread captureThread;
        private ScreenRecorder screenRecorder;
        int selrec = 0;
        public Main_Form()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            screenRecorder = new ScreenRecorder();
        }

        public void StartCapture()
        {
            if (!Directory.Exists("frames"))
            {
                Directory.CreateDirectory("frames");
            }
            else
            {
                foreach (string filePath in Directory.GetFiles("frames"))
                {
                    File.Delete(filePath);
                }
                Directory.Delete("frames");
                Directory.CreateDirectory("frames");
            }
            captureThread = new Thread(() =>
            {
                int frameCount = 0;
                while (true)
                {
                    preview.Invoke(new Action(() =>
                    {
                        preview.Image = screenRecorder.CaptureScreen(1);
                        screenRecorder.NewFrame(frameCount);
                        frameCount++;
                    }));
                    Thread.Sleep(10);
                }
            });
            captureThread.Start();
        }

        public void StopCapture()
        {
            if (captureThread != null && captureThread.IsAlive)
            {
                captureThread.Abort();
                screenRecorder.Export_MP4();
            }
        }

        private void record_activ_CheckedChanged(object sender, EventArgs e)
        {
            if (record_activ.Checked)
            {
                StartCapture();
            }
            else
            {
                StopCapture();
            }
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            record_activ.Checked = false;
            Environment.Exit(0);
        }
    }
}
