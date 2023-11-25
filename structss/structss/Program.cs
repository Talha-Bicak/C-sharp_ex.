using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace structss
{
    // Point adında bir struct tanımlıyoruz
    struct Point
    {
        // Struct içindeki iki alan (field)
        public int X;
        public int Y;
        
        // Struct içinde metot tanımlanabilir
        public void Display()
        {
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Point struct'ından bir örnek oluşturuyoruz
            Point point; // new operatörü ile de kullanılabilir.

            // Struct içindeki alanlara değer atayabiliriz
            point.X = 10;
            point.Y = 20;

            // Struct içindeki metodu çağırabiliriz
            point.Display();

            // Struct, değer türü olduğu için başka bir struct ile değer kopyalanır
            Point anotherPoint = point;

            // Değer kopyalandığı için myPoint'ın değerini değiştirmek, anotherPoint'ı etkilemez
            point.X += 10;

            Console.WriteLine("point:");
            point.Display();

            Console.WriteLine("anohtherPoint: ");
            anotherPoint.Display();
        }
    }
}
