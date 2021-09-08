using System;

namespace KiviPaberKäärid
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int Number = rnd.Next(1, 3);
            int Number2 = rnd.Next(1, 3);

            Console.WriteLine($"Arvuti genereeris: {Number}");
            Console.WriteLine($"Arvuti genereeris: {Number2}");


            if (1 > 2)
            {
                Console.WriteLine("Paber katab kivi.");
            }
            else if (2 > 3)
            {
                Console.WriteLine("Kivi nürib käärid.");
            }
            else 
            {
                Console.WriteLine("Käärid lõikavad paberit.");
            }




        }
    }
}
