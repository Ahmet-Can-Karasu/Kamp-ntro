using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteri Eklendi" + "\n" + musteri.Id + " " + musteri.Adi + " " + musteri.SoyAdi + " " + musteri.MusteriMi);
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine( musteri.Id + " " + musteri.Adi + " " + musteri.SoyAdi + " " + musteri.MusteriMi);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi \n" + musteri.Id + " " + musteri.Adi + " " + musteri.SoyAdi + " " + musteri.MusteriMi);
        }
    }
}
