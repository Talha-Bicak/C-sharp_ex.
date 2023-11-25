using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    internal class Program
    {
        public enum HaftaninGunleri
        {
            Pazartesi,  // 0
            Salı,        // 1
            Çarşamba,    // 2
            Perşembe,    // 3
            Cuma,        // 4
            Cumartesi,   // 5
            Pazar        // 6
        }
        static void Main(string[] args)
        {
            HaftaninGunleri day;

            for(day = HaftaninGunleri.Pazartesi; day<=HaftaninGunleri.Pazar; day++)
            {
                Console.WriteLine(day); // Haftanın günlerini isim olarak alırız.
            }

            HaftaninGunleri gun = HaftaninGunleri.Pazartesi; // Haftanın günlerini sayısal olarak alırız.
            switch (gun)
            {
                case HaftaninGunleri.Pazartesi:
                    //Console.WriteLine("Lineer Cebir");
                    //break;
                case HaftaninGunleri.Salı:
                    //Console.WriteLine("İstatistik ve Olasılık");
                    //break;
                case HaftaninGunleri.Çarşamba:
                    Console.WriteLine("Nesne Tabanlı Programlama");
                    break;
                case HaftaninGunleri.Perşembe:
                    Console.WriteLine("Ayrık Yapılar");
                    break;
                case HaftaninGunleri.Cuma:
                    Console.WriteLine("Hafta sonuna yaklaşıyor!");
                    break;
                case HaftaninGunleri.Cumartesi:
                    Console.WriteLine("Çalışma günü");
                    break;
                case HaftaninGunleri.Pazar:
                    Console.WriteLine("Çalışma günü");
                    break;
                default:
                    Console.WriteLine("Haftanın herhangi bir günü");
                    break;
            }


        }
    }
}
