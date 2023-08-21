using NAudio.Wave;
using System;

class SineWaveProvider : WaveProvider32
{
    private readonly float frequency;
    private readonly float amplitude;
    private readonly int sampleRate;
    private double phase;

    public SineWaveProvider(float frequency, float amplitude, int sampleRate)
    {
        this.frequency = frequency;
        this.amplitude = amplitude;
        this.sampleRate = sampleRate;
        this.phase = 0;
    }

    public override int Read(float[] buffer, int offset, int sampleCount)
    {
        for (int i = 0; i < sampleCount; i++)
        {
            buffer[offset + i] = (float)(amplitude * Math.Sin(2 * Math.PI * frequency * phase / sampleRate));
            phase += 1.0 / sampleRate;
            if (phase > 1) phase -= 1;
        }
        return sampleCount;
    }
}
