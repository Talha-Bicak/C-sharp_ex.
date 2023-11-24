using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{

    class ParamsExample
    {
        public static int Topla(params int[] numbers)
        {
            Console.WriteLine("Topla metodu çalıştı.");
            int topla = 0;
            foreach (int i in numbers)
            {
                topla += i;
            }
            return topla;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Metot, sıfır, bir veya daha fazla sayıda argüman alabilir
            Console.WriteLine("İki argüman: " + ParamsExample.Topla(1, 2));
            Console.WriteLine("Üç argüman: " + ParamsExample.Topla(1, 2, 3));
            Console.WriteLine("Dört argüman: " + ParamsExample.Topla(1, 2 ,3 , 4));
            Console.WriteLine("Sıfır argüman: " + ParamsExample.Topla());

            Console.ReadLine();
        }
    }
}
