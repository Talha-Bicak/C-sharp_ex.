using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faköriyelİslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktöriyeli alınacak olan sayıyı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            //1.seviye
            //int fact = 1;
            //if (sayi == 0 || sayi == 1)
            //{
            //    Console.WriteLine(fact);
            //}
            //else
            //{

            //    for (int i = 1; i <= sayi; i++)
            //    {
            //        fact *= i;
            //    }
            //    Console.WriteLine(fact);
            //}

            //2.seviye

            long fact = factHesapla(sayi);
            Console.WriteLine(fact);

            Console.WriteLine("Programı kapatmak için bir tuşa basınız...");
            Console.ReadLine(); // Kullanıcıdan bir giriş bekler, sonra program kapanır.
        }

        static long factHesapla(int n)
        {
            if(n==0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * factHesapla(n-1);
            }
        }

    }
}
