using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getSet3
{

    public class Ogrenci
    {
        public string Ad;
        public int Yas;

        public Ogrenci(string Ad, int Yas)
        {
            this.Ad = Ad;
            this.Yas = Yas;
        }
        
        public void BilgileriGoster()
        {
            Console.WriteLine($"Öğrencinin Adı: {Ad}\nÖğrencinin Yası: {Yas}");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci("Talha", 20);

            ogrenci.Ad = "Muhammed";

            Console.WriteLine(ogrenci.Ad);

            Console.ReadLine();
        }
    }
}
