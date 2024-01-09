using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmeticMean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç sayının aritmetik ortalamasını almak istiyorsunuz ? ");
            int adet = Convert.ToInt32(Console.ReadLine());
//
            Console.WriteLine("Aritmetik ortalaması alınacak olan sayilari giriniz: ");

            int toplam = 0;
            for (int i = 0; i < adet; i++)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            }
            int aritmetikOrt = toplam / adet;
            Console.WriteLine($"Girdiğiniz Sayıların Aritmetik Ortalaması: {aritmetikOrt}");
            Console.WriteLine("Programı kapatmak için bir tuşa basınız...");
            Console.ReadLine(); // Kullanıcıdan bir giriş bekler, sonra program kapanır.
        }
    }
}
