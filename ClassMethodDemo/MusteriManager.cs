using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void MusteriListele(List<Musteri> musteri)
        {
            int sayac = 1;
            foreach (Musteri k in musteri)
            {
                Console.WriteLine("----------------------------------" + sayac+ ".Müşteri----------------------------------");
                Console.WriteLine("Adı: " + k.Ad);
                Console.WriteLine("Soyadı: " + k.Soyad);
                Console.WriteLine("Şehri: " + k.Sehir);
                Console.WriteLine("Telefon Numarası: " + k.TelefonNo);
                Console.WriteLine("Maaşı: " + k.Maas);
                ++sayac;
            }
        }

        public void MusteriSil(List<Musteri> musteri, Musteri silinecekMusteri)
        {
            for (int i = 0; i < musteri.Count; ++i)
            {
                if (musteri[i] == silinecekMusteri)
                    musteri.Remove(silinecekMusteri);
            }
        }

        public void MusteriEkle(List<Musteri> musteri, Musteri eklenecekMusteri)
        {
            musteri.Add(eklenecekMusteri);
        }
    }
}
