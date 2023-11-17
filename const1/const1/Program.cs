using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace const1
{
    internal class Program
    {
        const char BaslangıcKarakteri = 'A';
        const int KarakterSayisi = 10;
        static void Main(string[] args)
        {
            string metin = ""; //Sabit karakter kümesini kullanarak metin oluşturma
            
            for (int i = 0; i < KarakterSayisi; i++)
            {
                char karakter = (char)(BaslangıcKarakteri+i);
                metin += karakter;
            }

            Console.WriteLine(metin);
            Console.ReadLine();
        }
    }
}
