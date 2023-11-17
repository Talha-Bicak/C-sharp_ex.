using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getSet
{

    public class Ogrenci
    {
        private string ad; //Öğrencinin adını tutan özel bir alan oluşturduk bu yapıya "field" denir.
        private int yas; //Öğrencinin yasını tutan özel bir alan oluşturduk bu yapıya "field" denir.


        public string Ad
        {
            get { return ad; } //Öğrencinin adının alınması (getter)

            set
            {
                if (!string.IsNullOrEmpty(value))
                    ad = value; //Ad yerine girilen değer boş bir değer değilse ad yerine atama yapılır. (setter)
                else
                    Console.WriteLine("Hatalı değer! Öğrenci adı boş olamaz");
            }
        }
        public int Yas
        {
            get { return yas; } //Öğrencinin yas değerini alınması (getter)
            set
            {
                if (yas >= 0)
                    yas = value; //Girilen yaş değeri negatif bir sayı değilse yas olarak atama yapılır.(setter)
                else
                    Console.WriteLine("Hatalı değer! Yas değeri negatif değer alamaz.");
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Talha";
            ogrenci.Yas = 20;
            Console.WriteLine($"Ogrencinin Adı: {ogrenci.Ad}\nOgrencinin yası: {ogrenci.Yas}");
            

            Console.ReadLine();
        }
    }
}
