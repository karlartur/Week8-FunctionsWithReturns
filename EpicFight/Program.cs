using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero, villain;
            string heroWeapon, villainWeapon;
            hero = RandomHero();
            heroWeapon = RandomWeapon();
            villain = RandomVillain();
            villainWeapon = RandomWeapon(); 
            Console.WriteLine($"{hero} will fight {villain}");
            Console.WriteLine($"{hero} will fight {heroWeapon}");
            Console.WriteLine($"{villain} will fight {villainWeapon}");

        }

        private static int RandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string RandomHero()
        {
            string[] heros = { "Optimus Prime", "Black Widow", "Luke Skywalker" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, heros.Length);

            return heros[RandomIndex(heros)];
            


        }
        
        private static string RandomVillain()
        {
            string[] villains = { "Megatron", "Thanos", "Palpatine" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villains.Length);
            string randomVillain = villains[randomIndex];
            return randomVillain;
        }

        private static string RandomWeapon()
        {
            string[] weapon = { "water bottle", "burger", "force", "snow"  };
            return weapon[RandomIndex(weapon)];
             
        }
    }
}
