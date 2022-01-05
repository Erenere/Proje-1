using System;
using System.Collections.Generic;

namespace Proje1
{
    public class Rehber:IRehberIslem
    {
        private List<Kisi> RehberListe;

        public Rehber(List<Kisi> rehberListe)
        {
            RehberListe = rehberListe;
            this.BaslangicEkrani();
        }
        
        public void Ekle()
        {
            Console.WriteLine("Lütfen isim giriniz  : ");
            string isim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz   : ");
            string soyisim = Console.ReadLine();
            Console.WriteLine("Lüten telefon numarası giriniz   : ");
            long numara = long.Parse(Console.ReadLine());
            RehberListe.Add(new Kisi(numara,isim,soyisim));
        }

        public void Sil()
        {
            int input = 2;
            while (input == 2 || input!=1)
            {
                char yesno = ' ';
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string giris = Console.ReadLine();
                var a =RehberListe.Find(kisi =>
                (
                    kisi.İsim == giris || kisi.Soyisim==giris
                    ));
                
                if (a != null)
                {
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",a.İsim);
                    yesno = char.Parse(Console.ReadLine());
                    if(yesno=='y')
                        RehberListe.Remove(a);
                    break;
                }
                else
                {
                    Console.WriteLine(  @"Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.
                                            * Silmeyi sonlandırmak için : (1)
                                            * Yeniden denemek için      : (2)");
                    input = Int16.Parse(Console.ReadLine());
                }
            }
            
                
        }

        public void Guncelle()
        {
            int input = 2;
            while (input == 2 || input != 1)
            {
                Console.WriteLine("Lütfen numarasını guncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string giris = Console.ReadLine();
                var a =RehberListe.Find(kisi =>
                (
                    kisi.İsim == giris || kisi.Soyisim==giris
                    ));
                
                if (a != null)
                {
                    Console.WriteLine("Kisinin yeni adi: ");
                    string newName = Console.ReadLine();
                    Console.WriteLine("Kisinin yeni soyadi: ");
                    string newSurname = Console.ReadLine();
                    Console.WriteLine("Kisinin yeni numarasi ");
                    long newNumber = long.Parse(Console.ReadLine());
                    a.İsim = newName;
                    a.Soyisim = newSurname;
                    a.Numara = newNumber;
                    break;
                }
                else
                {
                    Console.WriteLine( @"Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.
                        * Güncellemeyi sonlandırmak için    : (1)
                        * Yeniden denemek için              : (2)");
                    input = Int16.Parse(Console.ReadLine());
                }
            }
            
            
        }

        public void RehberListele()
        {
            Console.WriteLine("(A-Z) icin (1), (Z-A) icin (2): ");
            int input = Int16.Parse(Console.ReadLine());
            if(input==1)
                RehberListe.Sort((x,y)=>
                    String.Compare(x.İsim, y.İsim, StringComparison.Ordinal));
            else if (input == 2)
            {
                RehberListe.Sort((x,y)=>
                    String.Compare(x.İsim, y.İsim, StringComparison.Ordinal));
                RehberListe.Reverse();
            }
                
            RehberListe.ForEach(k =>
            {
                Console.WriteLine("**********************");
                Console.WriteLine("isim: {0}",k.İsim);
                Console.WriteLine("soyisim: {0}",k.Soyisim);
                Console.WriteLine("Telefon numarası: {0}",k.Numara);
                Console.WriteLine("-");
            });
        }

        public void RehberArama()
        {
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int input = Int32.Parse(Console.ReadLine());
            if (input == 1)
            {
                string inp = Console.ReadLine();
                var res = RehberListe.FindAll(kisi => (
                    kisi.İsim.Contains(inp) || kisi.Soyisim.Contains(inp)
                ));
                Console.WriteLine("Arama Sonuçlarınız: ");
                Console.WriteLine("***********************");
                res.ForEach(k =>
                {
                    Console.WriteLine("**********************");
                    Console.WriteLine("isim: {0}",k.İsim);
                    Console.WriteLine("soyisim: {0}",k.Soyisim);
                    Console.WriteLine("Telefon numarası: {0}",k.Numara);
                    Console.WriteLine("-");
                });
            }else if (input == 2)
            {
                long numGiris = long.Parse(Console.ReadLine());
                var res = RehberListe.FindAll(kisi => (
                    kisi.Numara.ToString().Contains(numGiris.ToString())
                ));
                Console.WriteLine("Arama Sonuçlarınız: ");
                Console.WriteLine("***********************");
                res.ForEach(k =>
                {
                    Console.WriteLine("**********************");
                    Console.WriteLine("isim: {0}",k.İsim);
                    Console.WriteLine("soyisim: {0}",k.Soyisim);
                    Console.WriteLine("Telefon numarası: {0}",k.Numara);
                    Console.WriteLine("-");
                });
            }
        }

        public void BaslangicEkrani()
        {
            Console.WriteLine(@"Lütfen yapmak istediğiniz işlemi seçiniz :) 
                *******************************************
                (1) Yeni Numara Kaydetmek
                (2) Varolan Numarayı Silmek
                (3) Varolan Numarayı Güncelleme
                (4) Rehberi Listelemek
                (5) Rehberde Arama Yapmak");

            int input = Int16.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                {
                    this.Ekle();
                    break;
                }
                case 2:
                {
                    this.Sil();
                    break;
                }
                case 3:
                {
                    this.Guncelle();
                    break;
                }
                case 4:
                {
                    this.RehberListele();
                    break;
                }
                case 5:
                {
                    this.RehberArama();
                    break;
                }
                        
            }
        }
    }
}