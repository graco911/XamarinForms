using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using App1.Interfaces;
using AVFoundation;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(App1.iOS.PlatformSoundPlayer))]

namespace App1.iOS
{
    public class PlatformSoundPlayer : IPlatformSoundPlayer
    {
        const int numChannels = 1;
        const int bitsPerSample = 16;

        public void PlaySound(int samplingRate, byte[] pcmData)
        {
            int numSamples = pcmData.Length / (bitsPerSample / 8);

            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(memoryStream, Encoding.ASCII);

            writer.Write(new char[] { 'R', 'I', 'F', 'F' });
            writer.Write(36 + sizeof(short) * numSamples);
            writer.Write(new char[] { 'W', 'A', 'V', 'E' });
            writer.Write(new char[] { 'f', 'm', 't', ' ' });
            writer.Write(16);                                               // PCM chunk size
            writer.Write((short)1);                                         // PCM format flag
            writer.Write((short)numChannels);
            writer.Write(samplingRate);
            writer.Write(samplingRate * numChannels * bitsPerSample / 8);   // byte rate
            writer.Write((short)(numChannels * bitsPerSample / 8));         // block align
            writer.Write((short)bitsPerSample);
            writer.Write(new char[] { 'd', 'a', 't', 'a' });                // data chunk
            writer.Write(numSamples * numChannels * bitsPerSample / 8);

            writer.Write(pcmData, 0, pcmData.Length);

            memoryStream.Seek(0, SeekOrigin.Begin);
            NSData data = NSData.FromStream(memoryStream);
            AVAudioPlayer audioPlayer = AVAudioPlayer.FromData(data);
            audioPlayer.Play();
        }
    }
}