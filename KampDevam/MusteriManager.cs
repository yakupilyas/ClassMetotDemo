using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampDevam
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: " + musteri.Adi);
        }

        public void Cıkar(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+ " "+ musteri.Soyadi+
                " İsimli müşteriyi çıkardınız.");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("AD: " + musteri.Adi);
                Console.WriteLine("SOYAD: " + musteri.Soyadi);
                Console.WriteLine("YAŞ: " + +musteri.Yas);
                Console.WriteLine("TCNO: " + musteri.TcNo);
                Console.WriteLine("-------------------");

            }
        }

      
    }
}
