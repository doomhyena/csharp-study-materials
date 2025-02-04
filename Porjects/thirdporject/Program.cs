using System;

namespace thirdproject
{
    class Program
    {
        static void Main(string[] args)
        {
            string keresztnev = "";
            string vezeteknev = "";
            string monogram = "";

            Console.Write("Kérem a Vezetéknevét: ");
            vezeteknev = Console.ReadLine();
            Console.Write("Kérem a Keresztnevét: ");
            keresztnev = Console.ReadLine();

            monogram = vezeteknev[0].ToString();
            monogram += keresztnev[0].ToString();

            Console.Write("A monogram: ");
            Console.WriteLine(monogram);
            Console.ReadKey();

        }
    }
}