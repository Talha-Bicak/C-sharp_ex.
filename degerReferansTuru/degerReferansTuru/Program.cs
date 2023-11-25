using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static degerReferansTuru.Point;

namespace degerReferansTuru
{
    // Değer türü: struct
    public struct Point
    {
        public int X; public int Y;

        //Değer türlerinde parametre olarak geçtiğinde kopya oluşturulur.
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        // Değer türüne ait bir metod
        public void Display()
        {
            Console.WriteLine($"Point ({X}, {Y})");
        }

    // Referans türü: class
    public class Person
        {
            public string Name;
            
            // Referans türlerinde parametre olarak geçtiğinde aynı nesneye referans edilir.
            public Person(string name)
            {
                this.Name = name;
            }
            // Referans türüne ait bir metod
            public void DisplayName()
            {
                Console.WriteLine($"Person: {Name}");
            }
            
        }
    }




    internal class Program
    {
        static void ModifyValue(Point point) // Point türünde bir değişken parametre olarak tanımlandı.
        {
            point.X = 100;
            point.Y = 200;
        }
        static void ModifyReference(Person person) // Person türünde bir değişken parametre olarak tanımlandı.
        {
            person.Name = "Test";
        }

        static void Main(string[] args)
        {
            // Değer türü kullanımı
            Point p = new Point(10,20);
            Console.WriteLine("Before Modification:");
            p.Display();
            ModifyValue(p);
            Console.WriteLine("After Modification:");
            p.Display(); //Değer türü olduğu için değişikliler yansımaz.

            // Referans türü kullanımı
            Person person = new Person("Reference");
            Console.WriteLine("Before Modification:");
            person.DisplayName();
            ModifyReference(person);
            Console.WriteLine("After Modification:");
            person.DisplayName();

            Console.ReadLine();

        }
    }
}
