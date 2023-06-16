using System;
using System.Diagnostics;

namespace VoxtoWavConverter
{
    class ConvertVoxToWav
    {
        public void Convert(string sourcefile, string destfile){ //sourcefile --> 1.vox , destfile --> 1.wav
            Console.WriteLine("Convert start");

            try
            {
                //Execute a command in cmd.exe prompt using C# (This execute code of batch file in cmd)
                Process p = new Process();
                p.StartInfo.FileName = "C:\\Users\\dilshan\\Downloads\\ConvertSox.bat"; //path of bat file
                p.StartInfo.WorkingDirectory = @"C:\Users\dilshan\Downloads"; //working directory of saved vox file
                p.StartInfo.Arguments = sourcefile + " " + destfile;
                p.Start();
              
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);                
            }
        }
    }
}
