using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Recran
{
    public class ScreenRecorder
    {
        const int ENUM_CURRENT_SETTINGS = -1;

        static private Image LastImage;
        AudioRecorder recorder = new AudioRecorder();
        private string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string rootdata;
        private string mp4path;
        private string wavpath;

        public ScreenRecorder()
        {
            LastImage = null;
            rootdata = $@"{appdata}\RecEcran";
            mp4path = $@"{rootdata}\output.mp4";
            wavpath = $@"{rootdata}\output.wav";
        }
        internal Image CaptureScreen(int SNUM)
        {
            try
            {
                Screen screen = Screen.AllScreens[SNUM];
                DEVMODE dm = new DEVMODE();
                dm.dmSize = (short)Marshal.SizeOf(typeof(DEVMODE));
                EnumDisplaySettings(screen.DeviceName, ENUM_CURRENT_SETTINGS, ref dm);

                using (Bitmap bmp = new Bitmap(dm.dmPelsWidth, dm.dmPelsHeight))
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(dm.dmPositionX, dm.dmPositionY, 0, 0, bmp.Size);

                    using (MemoryStream stream = new MemoryStream())
                    {
                        bmp.Save(stream, ImageFormat.Png);
                        stream.Seek(0, SeekOrigin.Begin);
                        Image img = Image.FromStream(stream);
                        LastImage = img;
                        return img;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
        }
        public void NewFrame(int frame_number)
        {
            LastImage.Save($@"{rootdata}\frames\frame_{frame_number}.png", ImageFormat.Png);
        }
        public void StartRecordAudio()
        {
            recorder.StartRecord();
        }
        public void StopRecordAudio()
        {
            recorder?.StopRecord();
        }

        public void Export_MP4()
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "MP4 files (*.mp4)|*.mp4|All files (*.*)|*.*";
                saveFileDialog1.Title = "Save the screen recording to MP4 File";
                saveFileDialog1.ShowDialog();
   
                if (saveFileDialog1.FileName != "")
                {
                    if (!Directory.Exists(rootdata)){Directory.CreateDirectory(rootdata);}

                    Process ffpmeg = new Process();
                    ffpmeg.StartInfo.FileName = "ffmpeg.exe";
                    ffpmeg.StartInfo.UseShellExecute = false;
                    ffpmeg.StartInfo.CreateNoWindow = true;

                    ffpmeg.StartInfo.Arguments = $"-framerate 10 -i \"{rootdata}\\frames\\frame_%d.png\" -pix_fmt yuv420p \"{mp4path}\"";
                    ffpmeg.Start();

                    while (!ffpmeg.HasExited) { Thread.Sleep(3000); }
                    do { Thread.Sleep(3000); } while (!File.Exists($"{mp4path}"));
                    Thread.Sleep(3000);

                    if (File.Exists($"{wavpath}"))
                    {
                        ffpmeg.StartInfo.Arguments = $"-i \"{mp4path}\" -i \"{wavpath}\" -c:v copy -c:a aac -strict experimental \"{saveFileDialog1.FileName}\"";
                        ffpmeg.Start();
                    }
                    else
                    {
                        File.Move($"{mp4path}", saveFileDialog1.FileName);
                    }
                    Thread.Sleep(1000);
                    foreach (string filePath in Directory.GetFiles($@"{rootdata}\frames"))
                    {
                        File.Delete(filePath);
                    }
                    Directory.Delete($@"{rootdata}\frames");
                    while (!ffpmeg.HasExited) { Thread.Sleep(3000); }
                    if (File.Exists($"{mp4path}")) { File.Delete($"{mp4path}"); }
                    if (File.Exists($"{wavpath}")) { File.Delete($"{wavpath}"); }
                    new popup($"The video is now save at: {saveFileDialog1.FileName}").Show();
                }
                
            } catch(Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        [DllImport("user32.dll")]
        public static extern bool EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode);

        [StructLayout(LayoutKind.Sequential)]
        public struct DEVMODE
        {
            private const int CCHDEVICENAME = 0x20;
            private const int CCHFORMNAME = 0x20;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public ScreenOrientation dmDisplayOrientation;
            public int dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmFormName;
            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;
        }
    }
}
