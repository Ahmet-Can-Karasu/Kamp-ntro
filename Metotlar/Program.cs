using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi1 = "Elma";
            double fiyati1 = 15;
            string aciklama1 = "Amasya elması";

            //string urunAd2 = "Çilek";
            //double fiyati2 = 10;
            //string aciklama2 = "Çilek gibi çilek";

            //string urunAdi3 = "Karpuz";
            //double fiyati3 = 17;
            //string aciklama3 = "Andana Karpuzu";



            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 17;
            urun2.Aciklama= "Andana Karpuzu";

            Urun[] uruns = new Urun[] {urun1,urun2 };
            foreach (Urun urun in uruns)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------");
            }


            Console.WriteLine("--------------Metodlar----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil Armut",12,50);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 15,65);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 17,20);


        }
    }
}
