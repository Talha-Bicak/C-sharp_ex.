using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referenceTypes
{
    //Bir sınıf tanımlıyoruz.
    public class Ogrenci
    {
        public string Ad { get; set; }
        public int Yas { get; set; }

        //Yapıcı metot (constructor)
        public Ogrenci(string ad, int yas)
        {
            this.Ad = ad;
            this.Yas = yas;
        }


        //Metot oluşturalım.

        public void BilgileriGoster()
        {
            Console.WriteLine($"Öğrencinin Adı: {Ad} \n Öğrencinin Yaşı {Yas}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Öğrenci sınıfından bir nesne oluşturuluyor.
            Ogrenci ogrenci1 = new Ogrenci("Talha", 20);

            //Yeni bir referans oluşturuldu ve önceki nesneyi referans ediyoruz.
            Ogrenci ogrenci2 = ogrenci1;

            //ogrenci1 'in bilgilerini gösterelim
            Console.WriteLine("Birinci öğrencinin bilgileri: ");
            ogrenci1.BilgileriGoster();

            //ogrenci2 nin bilgilerini gösterelim
            Console.WriteLine("İkinci öğrencinin bilgileri: ");
            ogrenci2 .BilgileriGoster();

            //ogrenci2 nin yasını değiştirelim.
            ogrenci2.Yas = 30;

            //Şimdi öğrenci1 'in bilgilerini inceleyelim. Bakalım ikinci öğrencinin
            //bilgilerindeki değişikler birinci öğrenciyi etkilemiş mi ?

            Console.WriteLine("Değişiklerden sonra ogrenci1'in bilgileri:");
            ogrenci1 .BilgileriGoster();

            //Görüldüğü üzere ogrenci2 referans oalrak ogrenci1'i aldığı için
            //ogrenci2'deki herhangi bir değişiklik ogrenci1'i de etkiler
            Console.ReadLine();
        }
    }
}
