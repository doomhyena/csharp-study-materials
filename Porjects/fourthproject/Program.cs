﻿using System;

namespace fourthproject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Valtozo deklaralasa
            int ora = 0;
            
            Console.WriteLine("Kerek egy szamot: ");
            
            ora = int.Parse(Console.ReadLine());

            if (ora >= 0 && ora <= 5) {
                Console.WriteLine("Jo reggelt!");
            } else if (ora > 8 && ora <= 10) {
                Console.WriteLine("Szep napot!!");
            } else {
                Console.WriteLine("Szep Jo estet!");
            }
            
            Console.ReadKey();
        }
    }
}