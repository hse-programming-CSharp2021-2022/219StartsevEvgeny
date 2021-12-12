using System;

namespace HW_3
{
    class Program
    {

        public static string RandomName()
        {
            Random random = new();
            string name = "";
            for (int i = 0; i < random.Next(2, 7); ++i)
            {
                name += (char)random.Next(97, 123);
            }
            return name;
        }
        public class VideoFile
        {
            private string _name;
            private int _duration;
            private int _quality;
            public VideoFile(string name, int duration, int quality)
            {
                this._name = name;
                this._duration = duration;
                this._quality = quality;
            }
            public int Size
            {
                get
                {
                    return _duration * _quality;
                }
            }
            public override string ToString()
            {
                return $"Name: {_name}; duration: {_duration}; quality: {_quality}";
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new();
                VideoFile videoFile = new VideoFile(RandomName(), random.Next(60, 361), random.Next(100, 1001));
                VideoFile[] videoFiles = new VideoFile[random.Next(5, 16)];
                Console.Write("Video file. ");
                Console.WriteLine(videoFile);
                for (int i = 0; i < videoFiles.Length; i++)
                {
                    videoFiles[i] = new VideoFile(RandomName(), random.Next(60, 361), random.Next(100, 1001));
                    if (videoFiles[i].Size > videoFile.Size)
                    {
                        Console.WriteLine('+' + " " + videoFiles[i]);
                    }
                }
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
            }
            

        }
    }
}