using System;
using System.Diagnostics;

namespace VoxtoWavConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertVoxToWav convertVoxToWav = new ConvertVoxToWav();
            convertVoxToWav.Convert("1.vox","1.wav"); //use SOX app to convert


        }
    }
}
