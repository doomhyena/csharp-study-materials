using System;

namespace fristproject
{
    class Program
    {
        static void Main(string[] args)
        {

            int szam1;
            int szam2;
            int sum = 0;
            
            Console.Write("Kerem az elso szamot: ");
            szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Az elso szam erteke: {szam1}");
            Console.Write("Kerem az masodik szamot: ");
            szam2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A masodik szam erteke: {szam2}");

            sum = szam1 + szam2;
            Console.WriteLine($"A ket szam osszege: {sum}");
            
            Console.ReadKey();
        }
    }
}