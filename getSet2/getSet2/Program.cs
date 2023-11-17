using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getSet2
{

    public class Araba
    {
        private string marka;

        public string Marka 
        {
            get { return marka; } // Arabanın marka değeri alındı (getter)
            set
            {
                if (!string.IsNullOrEmpty(marka)) // Marka değeri boş girilmemişse arabanın markasını ayarlar(setter)
                    marka = value;
                else
                    Console.WriteLine("Hatalı giriş işlemi! Marka kısmı boş değer olamaz.");
            }
        }

        private int hız;

        public int Hız
        {
            get { return hız; }

            set
            {
                if (hız >= 0)
                    hız = value;
                else
                    Console.WriteLine("Hatalı giriş!");
            }
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();

            araba.Marka = "TOGG";
            araba.Hız = 220;

            Console.WriteLine($"Arabanın markası: {araba.Marka}\nArabanın Hızı: {araba.Hız}");

            Console.ReadLine();
        }
    }
}
