using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] listt = { "deneme1","deneme2","deneme3", "deneme4"};
            for (int i = 0; i < listt.Length; i++)
            {
                Console.WriteLine(listt[i]);
            }
            foreach(var item in listt)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Kurss
    {

    }
}
