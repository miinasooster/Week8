﻿using System;
using System.IO;

namespace DataFromFile
{
    class Program
    {
        static void Main(string[] args)

        {
            string randomFood, randomDrink, randomMovie;
            randomFood = GetRandomFromFile("foods.txt");
            randomDrink = GetRandomFromFile("drinks.txt");
            randomMovie = GetRandomFromFile("movies.txt");

            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}.");



            string filePath = @"/Users/miinasooster/projects/foods.txt";

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