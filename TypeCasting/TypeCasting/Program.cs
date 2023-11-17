using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit-Örtülü(Bilinçsiz) Tür Dönüşümü
            int sayi = 42;
            double doubleSayi = sayi;
            Console.WriteLine(doubleSayi);//Çıktı 42.0   
            // VS kullanıyorsanız çıktı olarak 42 vericektir.

            //Explicit-Açık(Bilinçli) Tür Dönüşümü
            double doubleSayi2 = 52.85;
            int sayi2 = (int)doubleSayi2;
            Console.WriteLine(sayi2);//Çıktı 52

            //Convert Metodu 
            string sayiString = "123";
            int sayi3 = Convert.ToInt32(sayiString); 
            Console.WriteLine(sayi3); //Çıktı 123

            //Parse Metodu
            string sayiString2 = "456";
            double sayi4 = double.Parse(sayiString2);
            Console.WriteLine(sayi4); //Çıktı 456.0

            //ToString Metodu
            int sayi5 = 789;
            string sayiString3 = sayi5.ToString();
            Console.WriteLine(sayiString3.GetType()); // Çıktı System.String
            Console.WriteLine(sayiString3); // Çıktı 789
            //Boxing ve Unboxing 
            int sayi6 = 123;
            object obj = sayi6;//
            Console.WriteLine(obj.GetType());//Derleme esnasında int olarak değer verildiğinden ötürü int türündendir.
            int yeniSayi = (int)obj;//Unboxing işlemi (kutudan çıkarma)
            Console.WriteLine(yeniSayi.GetType());

            Console.ReadLine(); 
        }
    }
}
