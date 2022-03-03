using System;

namespace GuessingGameThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1st-10ni;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset;
            //kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata, siis mängu võidab arvuti;
            //programm genereerib juhuslikku numbrit vaid ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool LoopActive = true;
            int i = 0;

            while (i < 3)
            { 
                Console.WriteLine($"Arva ära number ühest kümneni. Teil on {3 - (i)} katset.");
                int guessNumber = Convert.ToInt32(Console.ReadLine());

                if (guessNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne, oled mängu võitnud!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale, proovi uuesti!");
                }
            }
            Console.WriteLine("Head päeva!");
        }
    }
}
