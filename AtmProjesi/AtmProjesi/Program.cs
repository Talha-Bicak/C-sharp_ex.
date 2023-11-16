using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmProjesi
{
    internal class Program
    {
        private string hesapSahibi;
        private double bakiye;

        public Program(string hesapSahibi , double bakiye) { 
            
            this.bakiye = bakiye;
            this.hesapSahibi = hesapSahibi;
        }
        
        public void ParaYatirma(double miktar)
        {
            if (miktar < 0)
            {
                Console.WriteLine("Pozitif bir değer girilmelidir.");
            }
            else
            {
                bakiye += miktar;
                Console.WriteLine($"Işlem Başarılı!\nYeni bakiyeniz: {bakiye}");
            }
        }
        public void ParaCekme(double miktar)
        {
            if (miktar < 0)
            {
                Console.WriteLine("Negatif bir değer girilemez...");
            }
            else if (bakiye < miktar)
            {
                Console.WriteLine("Yetersiz Bakiye !");
            }
            else
            {
                bakiye -= miktar;
                Console.WriteLine($"Işlem Başarılı!\nYeni Bakiyeniz: {bakiye}");
            }
        }
        public void ParaBakiye()
        {
            Console.WriteLine($"{hesapSahibi} adlı hesabın bakiyesi: {bakiye}");

        }

        static void Main(string[] args)
        {
            Program hesapBilgi = new Program("Muhammed Talha Bicak", 100);

            Console.WriteLine($"Hoşgeldiniz {hesapBilgi.hesapSahibi}  Yapmak istediğiniz işlemi seçin : ");
            Console.WriteLine("1-Bakiye Sorgulama");
            Console.WriteLine("2-Para Yatırma");
            Console.WriteLine("3-Para Çekme");
            Console.Write("Seciminiz: ");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    hesapBilgi.ParaBakiye();
                    break;
                case 2:
                    Console.WriteLine("Yatırmak istediğiniz miktarı giriniz: ");
                    int tutar = Convert.ToInt32(Console.ReadLine());
                    hesapBilgi.ParaYatirma(tutar);
                    break;
                case 3:
                    Console.WriteLine("Çekmek istediğiniz miktarı giriniz: ");
                    tutar = Convert.ToInt32(Console.ReadLine());
                    hesapBilgi.ParaCekme(tutar);
                    break;
                default:
                    Console.WriteLine("Geçersiz karakter!");
                    break;
            }


            Console.WriteLine("Programı kapatmak için bir tuşa basınız...");
            Console.ReadLine(); // Kullanıcıdan bir giriş bekler, sonra program kapanır.
        }
    }
}
