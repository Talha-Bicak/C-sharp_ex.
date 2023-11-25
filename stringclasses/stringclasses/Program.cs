using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringclasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "C# Programlama Dili";
            char[] dizi = {'1','2','3','4','5'};
            
            String s = new String(dizi); // 12345

            s = new String(dizi, 1, 2);
            //dizi[1] den itibaren 2 eleman stringe atandı. ->23

            s = new string('x', 10);
            //xxxxxxxxx
            Console.WriteLine(s);

            Console.WriteLine("İsminiz: ");
            string isim = Console.ReadLine();
            
            Console.WriteLine("Soy isminiz: ");
            string SoyIsim = Console.ReadLine();

            Console.Write("Yasınız: ");
            int Yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Yas);

            String prsn1 = String.Concat(isim, " ", SoyIsim ," : ", Yas);
            Console.WriteLine(prsn1);

            Console.WriteLine("##################");

            int c = String.Compare(isim, SoyIsim, true); //True: büyük küçük duyarlı
            //Dönüş değeri int'dir.Eğerki dönüş değeri 0 ise eşit 1 ise birbirine eşit değildir.
            Console.WriteLine(c);

            Console.WriteLine("##################");

            string name = "           talha   Bıçak   ";
            Console.WriteLine(name);
            name = name.Trim();
            Console.WriteLine(name);
        }
    }
}
