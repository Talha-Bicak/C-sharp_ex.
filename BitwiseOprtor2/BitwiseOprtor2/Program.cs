using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOprtor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 20;
            int sayi2 = 15;

            // & (ve) operatörü
            // Kontrol mekanizmasındaki iki koşulda kontrol edilip sonuç öyle döndürülecek
            if (CheckCondition(sayi2) & CheckCondition2(sayi1))
            {
                Console.WriteLine("Her iki koşul da doğru.");
            }
            else
            {
                Console.WriteLine("En az bir koşul yanlış.");
            }

            // && (ve-ama) operatörü
            //Kontrol mekanizmasında ilk koşul yanlış ise ikinciyi kontrol etmicek
            if (CheckCondition(sayi2) && CheckCondition2(sayi1))
            {
                Console.WriteLine("Her iki koşul da doğru.");
            }
            else
            {
                Console.WriteLine("En az bir koşul yanlış."); 
            }
            Console.ReadLine();
        }

        static bool CheckCondition(int number)
        {
            Console.WriteLine($"Koşul 1 kontrol ediliyor: {number > 0 }");
            return number % 2 == 0;

        }
        static bool CheckCondition2(int number)
        {
            Console.WriteLine($"Koşul 2 kontrol ediliyor: {number % 2 == 0}");
            return number > 0;
        }
    }
}
