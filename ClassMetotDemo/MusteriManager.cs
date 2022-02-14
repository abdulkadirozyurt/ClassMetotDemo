using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri sisteme eklendi : " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri sistemden silindi : " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Listele(Musteri[] musteri)
        {
            Console.WriteLine("Müşteri Listesi");

            foreach (Musteri musteriler in musteri)
            {
                Console.WriteLine(musteriler.Ad + " " + musteriler.Soyad);
            }


        }


    }

}
