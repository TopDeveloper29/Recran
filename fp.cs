using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NAudio.Wave;
using NAudio.CoreAudioApi;
using System.Diagnostics;

namespace Recran
{
    public partial class fp : MaterialForm
    {
        private Thread captureThread;
        private ScreenRecorder screenRecorder;
        int select_screen = 0;
        Settings settings = new Settings("settings.json");
        string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string rootdata;
        string mp4path;
        string wavpath;
        public fp()
        {
            rootdata = $@"{appdata}\RecEcran";
            mp4path = $@"{rootdata}\output.mp4";
            wavpath = $@"{rootdata}\output.wav";
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            screenRecorder = new ScreenRecorder();
        }

        public void StartCapture()
        {
            screenRecorder = new ScreenRecorder();
            captureThread = new Thread(() =>
            {
                if (File.Exists($"{mp4path}")) { File.Delete($"{mp4path}"); }
                if (File.Exists($"{wavpath}")) { File.Delete($"{wavpath}"); }
                if (!Directory.Exists($@"{rootdata}\frames")){Directory.CreateDirectory($@"{rootdata}\frames");}
                else
                {
                    foreach (string filePath in Directory.GetFiles($@"{rootdata}\frames"))
                    {
                        File.Delete(filePath);
                    }
                    Directory.Delete($@"{rootdata}\frames");
                    Directory.CreateDirectory($@"{rootdata}\frames");
                }
                if (recaudio.Checked)
                {
                    screenRecorder.StartRecordAudio();
                    recaudio.Invoke(new Action(() =>
                    {
                        recaudio.Enabled = false;
                    }));
                }
                int frameCount = -1;
                while (true)
                {
                    preview_group.Invoke(new Action(() =>
                    {
                        preview_group.Text = $"Frame #: {frameCount}";
                    }));
                    preview.Invoke(new Action(() =>
                    {
                        preview.Image = screenRecorder.CaptureScreen(select_screen);
                        screenRecorder.NewFrame(frameCount);
                        frameCount++;
                    }));
                    int frequency = 1000;
                    var waveOut = new WaveOutEvent();
                    var sineWaveProvider = new SineWaveProvider(frequency, 0.1f, 44100);
                    waveOut.Init(sineWaveProvider);
                    waveOut.Play();
                    Thread.Sleep(9);
                    waveOut.Stop();
                    waveOut.Dispose();
                }
            });
            captureThread.Start();
        }
        public void StopCapture()
        {
            preview_group.Text = "Live Preview";
            if (captureThread != null && captureThread.IsAlive)
            {
                captureThread.Abort();
                if (recaudio.Checked)
                {
                    recaudio.Enabled = true;
                    screenRecorder.StopRecordAudio();
                }
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
        private void fp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("ffmpeg");

            foreach (Process process in processes)
            {
                process.Kill();
            }
            record_activ.Checked = false;
            Environment.Exit(0);
        }
        private void fp_Load(object sender, EventArgs e)
        {
            // Get all screens
            Screen[] screens = Screen.AllScreens;

            // Add screen information to combo box
            for (int i = 0; i < screens.Length; i++)
            {
                screen_list.Items.Add("Screen " + (i + 1) + ": " + screens[i].Bounds.Width + "x" + screens[i].Bounds.Height);
            }

            if (settings.TestKey("SelectedScreen"))
            {
                try
                {
                    screen_list.SelectedIndex = Convert.ToInt32(settings["SelectedScreen"]);
                }
                catch
                {
                    screen_list.SelectedIndex = 0;
                }
            }

            if (settings.TestKey("recaudio"))
            {
                recaudio.Checked = (bool)(settings["recaudio"]);
            }

        }
        private void screen_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            preview.SizeMode = PictureBoxSizeMode.StretchImage;
            select_screen = screen_list.SelectedIndex;
            settings["SelectedScreen"] = select_screen;
            preview.Image = screenRecorder.CaptureScreen(select_screen);
            if (select_screen != -1)
            {
                record_activ.Enabled = true;
                screenshot.Enabled = true;
            }
        }
        private void screenshot_Click(object sender, EventArgs e)
        {
            Image img = screenRecorder.CaptureScreen(select_screen);
            preview.Image = img;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save the screen capture to PNG File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                img.Save(saveFileDialog1.FileName);
            }
        }
        private void recaudio_CheckedChanged(object sender, EventArgs e)
        {
            settings["recaudio"] = recaudio.Checked;
        }
    }
}
