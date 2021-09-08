using System;

namespace EpicDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mängus osaleb 2 mängijat
            //iga mängija visakb täringut (1-6)
            //programm kuvab nende visete tulemuse ja kuvab ka, kes on võitja
            // - ehk kes viskas suurema numbri

            Random rnd = new Random();

            string PlayerOne = "Harry Potter";
            String PlayerTwo = "Voldemort";

            int HarryThrow = rnd.Next(1, 7);
            int VoldemortThrow = rnd.Next(1, 7);

            Console.WriteLine($"{PlayerOne} threw :{HarryThrow}");
            Console.WriteLine($"{PlayerTwo} threw :{VoldemortThrow}");

            if(HarryThrow > VoldemortThrow)
            {
                Console.WriteLine($"{PlayerOne} wins!");
            }
            else if (HarryThrow < VoldemortThrow)
            {
                Console.WriteLine($"{PlayerTwo} wins!");
            }
            else
            {
                Console.WriteLine("Draw! Let them try again.");
            }


        }
    }
}
