using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Selma";
            musteri1.Soyad = "Altan";
            musteri1.Sehir = "Mersin";
            musteri1.TelefonNo = "05369897847";
            musteri1.Maas = "3525 TL";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Sena";
            musteri2.Soyad = "Kalkan";
            musteri2.Sehir = "Adana";
            musteri2.TelefonNo = "05364875247";
            musteri2.Maas = "3200 TL";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Yasemin";
            musteri3.Soyad = "Ayyıldız";
            musteri3.Sehir = "İzmir";
            musteri3.TelefonNo = "0548785847";
            musteri3.Maas = "8540 TL";

            Musteri musteri4 = new Musteri();
            musteri4.Ad = "Sinem";
            musteri4.Soyad = "Yılmaz";
            musteri4.Sehir = "İstanbul";
            musteri4.TelefonNo = "0538575847";
            musteri4.Maas = "7585 TL";


            List<Musteri> liste = new List<Musteri> { musteri1, musteri2, musteri3, musteri4 };
            MusteriManager Ozellikler = new MusteriManager();
            Console.WriteLine("************************************************İlk Durum************************************************");
            Console.WriteLine("   ");
            Ozellikler.MusteriListele(liste);
            Console.WriteLine("************************************************İkinci Durum************************************************");
            Console.WriteLine("   ");
            Ozellikler.MusteriSil(liste, musteri4);
            Ozellikler.MusteriListele(liste);
            Console.WriteLine("************************************************ÜÇüncü Durum************************************************");
            Console.WriteLine("   ");

            Musteri musteri5 = new Musteri();
            musteri5.Ad = "Hasan Emre";
            musteri5.Soyad = "Alkan";
            musteri5.Sehir = "Hatay";
            musteri5.TelefonNo = "0538585847";
            musteri5.Maas = "0 TL"+" - "+"Garibanın yüzü gülür mü?";

            Ozellikler.MusteriEkle(liste, musteri5);
            Ozellikler.MusteriListele(liste);





        }
    }
}
