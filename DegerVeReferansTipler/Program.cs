using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 31;
            Console.WriteLine(sayi1);

            int[] sayilar1 = { 1, 2, 3 };
            int[] sayilar2 = { 11, 22, 33 };
            sayilar1 = sayilar2;
            sayilar2[0] = 31;
            foreach (int item in sayilar1)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine(sayilar1[0]);
        }
    }
}
