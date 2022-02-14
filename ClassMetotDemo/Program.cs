using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Musteri musteri1 = new Musteri();
            musteri1.Id = 1234578910;
            musteri1.Ad = "Abdulkadir";
            musteri1.Soyad = "Özyurt";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2125479879;
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Demiroğ";


            Musteri musteri3 = new Musteri();
            musteri3.Id = 45633321;
            musteri3.Ad = "Hasan";
            musteri3.Soyad = "Baran";


            Musteri[] musteri = new Musteri[]
            {
                musteri1, musteri2,musteri3
            };


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
            musteriManager.Listele(musteri);



        }
    }
}
