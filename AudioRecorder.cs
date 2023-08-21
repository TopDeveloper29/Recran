using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recran
{
    internal class AudioRecorder
    {
        WasapiLoopbackCapture capture = new WasapiLoopbackCapture();
        WaveFileWriter writer;
        private string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public AudioRecorder()
        {
            capture.DataAvailable += (s, a) =>
            {
                writer.Write(a.Buffer, 0, a.BytesRecorded);
            };
            capture.RecordingStopped += (s, a) =>
            {
                writer.Dispose();
                writer = null;
                capture.Dispose();
            };
        }

        public void StartRecord()
        {
            var outputFilePath = Path.Combine(Directory.GetCurrentDirectory(), $@"{appdata}\RecEcran\output.wav");
            writer = new WaveFileWriter(outputFilePath, capture.WaveFormat);
            capture.StartRecording();
        }
        public void StopRecord()
        {
            capture.StopRecording();
        }
    }
}
