﻿using System;

namespace fifthproject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Tanulo informatika jegye");
            int jegy = int.Parse(Console.ReadLine());

            switch (jegy)
            {
                case 5:
                {
                    Console.WriteLine("Jeles");
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Jo");
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Kozepes");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Elegseges");
                    break;
                }
                case 1:
                {
                    Console.WriteLine("Elegtelen");
                    break;
                }
                default: 
                    Console.WriteLine("Nincs ilyen osztalyzat!");
                    break;
            }
            Console.ReadKey();

        }
    }
}