using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] sinavNotlari =
            {
                {75, 80, 85, 90},
                {60, 70, 75, 80},
                {90, 95, 85, 88}
            };

            Console.WriteLine("Öğrenci Notları: ");
            for ( int ogrenci = 0; ogrenci < 3; ogrenci++ )
            {
                Console.WriteLine($"Öğrenci {ogrenci + 1}: ");
                for ( int sinav = 0; sinav < 4; sinav++)
                {
                    Console.WriteLine($"{sinavNotlari[ogrenci, sinav]}");
                }
                Console.WriteLine();
            }
            // Her öğrencinin ortalamasını hesaplama
            for ( int ogrenci = 0; ( ogrenci < 3); ogrenci++ )
            {
                int toplam = 0;
                for ( int sinav = 0;sinav < 4; sinav++)
                {
                    toplam += sinavNotlari[ogrenci, sinav];

                }
                double ortalama = (double)toplam / 4;
                Console.WriteLine($"Öğrenci {ogrenci + 1} Ortalama: {ortalama:F2}");
                Console.ReadLine();
            }
        }
    }
}
