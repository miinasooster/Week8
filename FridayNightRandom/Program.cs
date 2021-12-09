﻿using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();//iseseisev
        }


        private static int GenerateRandomIndex(string[]someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }



        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
           

            Console.WriteLine($"Computer picked:{foods[GenerateRandomIndex(foods)]}");

        }


        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "cola", "fanta", "sprite" };
            
            Console.WriteLine($"Computer picked:{drinks[GenerateRandomIndex(drinks)]}");

        }

        //iseseisev
        private static void DisplayRandomMovie()
        {
            string[] movies = { "Kevade", "Tõde ja õigus", "Mehed ei nuta", "Malev" };

            Console.WriteLine($"Computer picked:{movies[GenerateRandomIndex(movies)]}");

        }
    }
}
