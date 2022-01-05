using System;
using System.Collections.Generic;

namespace Proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1 = new Kisi(5340445599, "isim1", "soyisim1");
            Kisi kisi2 = new Kisi(5340444599, "isim2", "soyisim2");
            Kisi kisi3 = new Kisi(5360875599, "isim3", "soyisim3");
            Kisi kisi4 = new Kisi(5340865599, "isim4", "soyisim4");
            Kisi kisi5 = new Kisi(5350445431, "isim5", "soyisim5");
            List<Kisi> list1 = new List<Kisi>();
            list1.Add(kisi1);
            list1.Add(kisi2);
            list1.Add(kisi3);
            list1.Add(kisi4);
            list1.Add(kisi5);
            Rehber rehber = new Rehber(list1);
            Console.WriteLine("--------------------------------");
            rehber.Ekle();
            Console.WriteLine("--------------------------------");
            rehber.Sil();
            Console.WriteLine("--------------------------------");
            rehber.Guncelle();
            Console.WriteLine("--------------------------------");
            rehber.RehberListele();
            Console.WriteLine("--------------------------------");
            rehber.RehberArama();
        }
    }
}