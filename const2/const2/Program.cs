using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace const2
{
    class Sabitler
    {
        public const int MinimumYas = 18;
        public const int MaximumHiz = 120;
        public const string UlkeKodu = "+90";

    }
    class Kullanici
    {
        public string Ad;
        public int Yas;

        public Kullanici(string ad, int yas)
        {
            this.Ad = ad;
            this.Yas = yas;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine($"Ad: {Ad}, Yas: {Yas}");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Isminizi giriniz: ");
            string isim = Console.ReadLine();
            Console.WriteLine("Yasinizi giriniz: ");
            string yas = Console.ReadLine() ;
            int yas2 =  int.Parse( yas );
            Console.WriteLine();
            Kullanici kullanici = new Kullanici(isim, yas2);

            kullanici.BilgileriGoster();

            if(kullanici.Yas < Sabitler.MinimumYas)
            {
                Console.WriteLine("Üzgünüz, yaşınız yaş kriterini karşılamıyor");
            }
            else 
            {
                Console.WriteLine("Yaşınız yaş kriterini karşılıyor.");
            }

            int aracHizi = 110;

            if(aracHizi < Sabitler.MaximumHiz)
            {
                Console.WriteLine("Hızınız hız sınırını aşmıyor.");
            }
            else
            {
                Console.WriteLine("Hızının hız sınırını aşıyor.");
            }
            //Sabit ülke kodu ile kullanıcıdan telefon numarasını istenmesi
            Console.WriteLine("Telefon numaranızı (5xxxxxxxxx) şeklinde giriniz: ");
            
            string telefonNumarası = Console.ReadLine();

            Console.WriteLine($"Telefon numaranız: {Sabitler.UlkeKodu}{telefonNumarası}");
            Console.ReadLine();
        }
    }
}
