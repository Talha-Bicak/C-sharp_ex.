using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckedUnchecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxInt = int.MaxValue;

            try
            {
                checked
                {
                    //Bu işlem int türünün maksimum değerini aşacak
                    int tasmaDurumu = maxInt + 1;
                    //Bu satırdan sonraki hiç bir satır çalışmicak
                    Console.WriteLine("Bu satır çalışmicak çünkü checked blogunun içerisinde olduğundan ötürü.");
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Taşma hatası: {ex.Message}");
            }

                unchecked
                {
                    //Bu işlemde int türünün maksimum değerini aşmasına rağmen hata vermicek
                      int tasmaDurumu = maxInt + 1;
                      Console.WriteLine($"Int türü maksimum değerini açtı.{tasmaDurumu}Bu bir hata mesajı değildir.");
                }
            Console.ReadLine();

        }
    }
}
