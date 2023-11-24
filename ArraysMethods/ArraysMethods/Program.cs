using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 8, 3, 6, 8, 21, 85, 99 };


            //Diziyi sıralayalım
            Array.Sort(numbers);
            Console.WriteLine("Sıralanmış Dizi");
            foreach(var number in numbers)
            {
                Console.WriteLine(number); //Sıralanmış diziyi yazdıralım
            }
            Console.WriteLine("---------------------------------------");

            //BinarySearch: Belirli bir değeri dizide kaçıncı indexte olduğunu döndürür.
            int index = Array.BinarySearch(numbers, 21);
            Console.WriteLine($"21 değeri dizide {index}. index'te bulunuyor.");
            Console.WriteLine("---------------------------------------");

            //Reverse: Diziyi tersine çevirir
            Array.Reverse(numbers);
            Console.WriteLine("Tersine Çevrilen Dizi");
            foreach (var number in numbers)
            {
                Console.WriteLine(number + " ");
            }
            Console.WriteLine("---------------------------------------");

            // Bir dizinin belirli bir bölümünü başka bir diziye kopyalar
            int[] copyArray = new int[3];
            Array.Copy(numbers, 0, copyArray, 0, 3);
            Console.WriteLine("Kopyalanan Dizi:");
            foreach (var number in copyArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n---------------------------------------");

            //IndexOf: Belirli bir değerin dizideki ilk indeksini bulur
            int indexOfValue = Array.IndexOf(numbers, 21);
            Console.WriteLine($"21 değeri dizideki ilk bulunduğu indeks: {indexOfValue}");

            Console.WriteLine("---------------------------------------");

            //int türünde, 3 elemanlı bir dizi nesnesi oluştur.
            Array myArray = Array.CreateInstance(typeof(int), 3);

            //Eğerki çok boyutlu diziler oluşturmak istiyorsak;
            //Array myArray = Array.CreateInstance(typeof(int), 3,5,8);


            // Dizinin içerisine değer ata
            myArray.SetValue(10, 0);
            myArray.SetValue(20, 1);
            myArray.SetValue(30, 2);

            // Diziyi ekrana yazdır
            Console.WriteLine("Oluşturulan Dizi:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray.GetValue(i));
            }
            Console.WriteLine("---------------------------------------");

            Console.ReadLine();
        }
    }
}
