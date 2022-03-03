using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1st-10ni;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu;
            //programm genereerib juhuslikku numbrit vaid ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool LoopActive = true;

            int i = -1;

            while (LoopActive)
            {
                Console.WriteLine("Arva number ära!");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Tubli, sa võitsid arvutit!");
                    break;
                }
                else
                {
                    Console.WriteLine("Vale vastus, proovi uuesti!");
                }
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
