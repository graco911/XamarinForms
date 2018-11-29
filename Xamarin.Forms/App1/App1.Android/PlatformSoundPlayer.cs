using System;
using Android.Media;
using App1.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(App1.Droid.PlatformSoundPlayer))]

namespace App1.Droid
{
    public class PlatformSoundPlayer : IPlatformSoundPlayer
    {
        AudioTrack previousAudioTrack;
        public void PlaySound(int samplingRate, byte[] pcmData)
        {
            if (previousAudioTrack != null)
            {
                previousAudioTrack.Stop();
                previousAudioTrack.Release();
            }

            AudioTrack audioTrack = new AudioTrack(Stream.Music, samplingRate, ChannelOut.Mono, Encoding.Pcm16bit, pcmData.Length * sizeof(short), AudioTrackMode.Static);

            audioTrack.Write(pcmData, 0, pcmData.Length);
            audioTrack.Play();

            previousAudioTrack = audioTrack;
        }
    }
}