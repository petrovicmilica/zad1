using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj: ");
            int broj;
            string broj1 = Console.ReadLine();
            broj = Int32.Parse(broj1);
            if (IfNumberContains(broj))
            {
                Console.WriteLine("Broj sadrzi 3.");
            }
            else
            {
                Console.WriteLine("Broj ne sadrzi 3.");
            }
        }

        static bool IfNumberContains(int br)
        {
            while(br % 10 != 0)
            {
                if (br % 10 == 3)
                {
                    return true;
                }
                br /= 10;
            }
            return false;
        }


    }
}
