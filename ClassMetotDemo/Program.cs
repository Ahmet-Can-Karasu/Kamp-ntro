using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 10;
            musteri1.Adi = "Yamaç";
            musteri1.SoyAdi = "Kocavalı";
            musteri1.MusteriMi = true;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 11;
            musteri2.Adi = "Cumali";
            musteri2.SoyAdi = "Kocavalı";
            musteri2.MusteriMi = true;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 12;
            musteri3.Adi = "Salih";
            musteri3.SoyAdi = "Kocavalı";
            musteri3.MusteriMi = true;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 13;
            musteri4.Adi = "Akın";
            musteri4.SoyAdi = "Kocavalı";
            musteri4.MusteriMi = false;

            //Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3,musteri4 };


            //foreach (var musteri in musteriler)
            //{
            //    Console.WriteLine(musteri.Id);
            //    Console.WriteLine(musteri.Adi);
            //    Console.WriteLine(musteri.SoyAdi);
            //    Console.WriteLine(musteri.MusteriMi);
            //    Console.WriteLine("-------------------");
            //}

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("Müşteri Listesi \n");
            musteriManager.List(musteri1);
            musteriManager.List(musteri2);
            musteriManager.List(musteri3);
            Console.WriteLine("-------------------");

            musteriManager.Add(musteri4);

            Console.WriteLine("-------------------");

            musteriManager.Delete(musteri3);
            



        }
    }
}
