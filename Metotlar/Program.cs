using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "elma";
            urun1.Fiyatı = 31;
            urun1.Aciklama = "amasya elması";
            Product urun2 = new Product();
            urun2.Adi = "nar";
            urun2.Fiyatı = 10;
            urun2.Aciklama = "pazaradn aldım 1 tane eve gittim ellibeş bin tane";

            Product[] urunler = new Product[]{urun1,urun2}; // listeyi tanımlarken new product[] şeklinde yazmasakta olur no proeblemo

            foreach ( Product uruns in urunler)
            {
                Console.WriteLine(uruns.Adi+" : "+uruns.Fiyatı);
            }

            Console.WriteLine("metotlarrrrrrrrrr");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


        }
    }
}
