using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseControls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Bir");
                        break;
                    case 2:
                        Console.WriteLine("İki");
                        break;
                    case 3:
                        Console.WriteLine("Üç");
                        continue; // Döngüyü bir sonraki iterasyona geçir
                    case 4:
                        Console.WriteLine("Dört");
                        break;
                    default:
                        Console.WriteLine("Diğer");
                        break;
                }
                if (i % 2 == 0)
                {
                    Console.WriteLine("Çift sayı");
                }
                else
                {
                    Console.WriteLine("Tek sayı");
                }
                if (i == 5)
                {
                    Console.WriteLine("İterasyon durduruluyor.");
                    break; // Döngüyü tamamen sonlandır
                }

                if (i > 7)
                {
                    Console.WriteLine("İterasyon atlanıyor.");
                    goto SkipIteration; // Etiketli bir noktaya geç
                }
                Console.WriteLine("Devam eden işlemler...");

                SkipIteration:
                Console.WriteLine("İterasyon atlandı.");
            }
            Console.WriteLine("Program tamamlandı.");
            Console.ReadLine();
        }
    }
}
