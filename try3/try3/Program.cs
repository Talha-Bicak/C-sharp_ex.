using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if(sayi == 0)
            {
                Console.WriteLine("Sayı 0'a eşittir...");
            }else if(sayi < 0 ) {

                Console.WriteLine("Sayı negatiftir.");
            }
            else
            {
                Console.WriteLine("Sayı pozitiftir...");
            }

            Console.WriteLine("Sayıların Toplamı: " + SayilarinToplami(sayi));



            Console.WriteLine("Programı kapatmak için bir tuşa basınız...");
            Console.ReadLine(); // Kullanıcıdan bir giriş bekler, sonra program kapanır.
        }

        static int SayilarinToplami(int n)
        {
            int toplam = 0;
            for(int i = 0; i <= n; i++)
            {
                toplam += i;
            }
            return toplam;
        }

    }
}
