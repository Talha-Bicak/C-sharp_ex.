using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOprtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 10;

            CompareNumbers(sayi1, sayi2);

            Console.ReadLine();
        }
        static void CompareNumbers(int a, int b)
        {
            // a > b ise 1, a < b ise -1, a=b ise 0
            int result = (a>b) ? 1 : (a < b) ? -1 : 0;

            switch(result)
            {
                case 0:
                    Console.WriteLine($"{a} eşittir {b}");
                    break;
                case 1:
                    Console.WriteLine($"{a} büyüktür {b}");
                    break;
                case -1:
                    Console.WriteLine($"{a} küçüktür {b}");
                    break;
            }


        }
        
    }
}
