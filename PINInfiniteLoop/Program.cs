﻿using System;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm, mis küsib kasutajal sisestada pin-koodi;
            //programm võrdleb sisestatud pin-koodi arvuga 1234;
            //kui sisestatud pin-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud pin-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti!";
            //katsete arv on piiramatu

            bool loopActive = true; //boolean --> true/false
            int i = 0;


            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:"); //cw + double TAB
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234) 
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++; //i = i + 1;
                    Console.WriteLine("Vale PIN. Proovi uuesti.");
                    Console.WriteLine($"Oled sisestanud vale PIN-koodi {i} korda");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
