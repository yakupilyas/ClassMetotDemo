using System;

namespace KampDevam
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Yakup İlyas";
            musteri1.Soyadi = "ÇAĞAN";
            musteri1.TcNo = 99999999999;
            musteri1.Yas = 22;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Yunus Emre";
            musteri2.Soyadi="ÇAĞAN";
            musteri2.TcNo = 55555555555;
            musteri2.Yas = 18;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Halil İbrahim";
            musteri3.Soyadi = "ÇAĞAN";
            musteri3.TcNo = 1000000000;
            musteri3.Yas = 22;

            Musteri[] musteriler = new Musteri[] {musteri1,
                musteri2, musteri3};
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("AD: "+musteri.Adi);
                Console.WriteLine("SOYAD: "+musteri.Soyadi);
                Console.WriteLine("YAŞ: "+ +musteri.Yas);
                Console.WriteLine("TCNO: "+musteri.TcNo);
                Console.WriteLine("-------------------");
               
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("-------------------");

            musteriManager.Cıkar(musteri1);
            musteriManager.Cıkar(musteri2);
            musteriManager.Cıkar(musteri3);

            Console.WriteLine("---------------");

            musteriManager.Listele(musteriler);

        }
    }
}
