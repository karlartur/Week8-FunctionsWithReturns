﻿using System;

namespace FunctionsWithReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foods = { "tacos", "burritos", "nachos", "wrap" };
            string[] drinks = { "coke", "7UP", "DR Pepper", "Sprite" };
            string[] movies = { "Transformers", "Star Wars", "Avengers" };
            //DisplayRandomFromArray(foods);
            //DisplayRandomFromArray(drinks);
            string randomSnack = PickRandomFromArray(foods);
            string randomDrink = PickRandomFromArray(drinks);
            string randomMovie = PickRandomFromArray(movies);
            Console.WriteLine($"Computer has picked {randomSnack} and {randomDrink} for a {randomMovie} night.");
        }
        private static string PickRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            string randomElement = someArray[randomIndex];

            return randomElement;
        }

        private static void DisplayRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            Console.WriteLine($"Computer has chosen {someArray[randomIndex]}");
        }


    }
}
