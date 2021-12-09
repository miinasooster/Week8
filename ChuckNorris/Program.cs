using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm valib juhusliku chuck norrise nalja ja kuvab seda konsoolis.


            string randomChuck;
            randomChuck = GetRandomFromFile("chuck.txt");
            

            Console.WriteLine($"{randomChuck}.");



            string filePath = @"/Users/miinasooster/projects/chuck.txt";

            string[] DataFromFile = File.ReadAllLines(filePath);

        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string GetRandomFromFile(string FileName)
        {
            string filePath = $@"/Users/miinasooster/projects/{FileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;



        }
    }
}
