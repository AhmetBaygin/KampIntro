using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "ben";
            kurs1.IzlenmeOrani = 31;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "c++";
            kurs2.Egitmen = "sen";
            kurs2.IzlenmeOrani = 61;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "c";
            kurs3.Egitmen = "o";
            kurs3.IzlenmeOrani = 33;

            Kurs[] kurslar = {kurs1,kurs2,kurs3 };
            foreach (Kurs item in kurslar)
            {
                Console.WriteLine(item.KursAdi);
            }

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
