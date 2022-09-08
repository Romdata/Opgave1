using SingAsong2.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Timers;
namespace SingAsong2
{
    internal class Program
    {
        static void Main()
        {
            int numbers;
            List<string> SongLine = new List<string>();
            var resourceName = Resources.millej;

            foreach (string line in resourceName.Split(new[] { '\n' }))
            {
                SongLine.Add(line);
            }

            Console.WriteLine($"Hvor mange linier af sangen ønsker du udskrevet ? der er {SongLine.Count} linier ialt");
            numbers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n");

            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine($"{i+1}:\t{SongLine[i]}");
                Thread.Sleep(500);
            }
            Console.WriteLine($"\n\nDet var i alt {numbers} linier af sangen\nMille J med Anders Matthesen fra albummet \"Søvnløs\"\n\n\n");
        }

    }
}
