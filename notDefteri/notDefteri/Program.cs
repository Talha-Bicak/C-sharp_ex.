using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notDefteri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> notlar = new List<String>();

            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi giriniz: ");
                Console.WriteLine("1-> Not Ekle");
                Console.WriteLine("2-> Notları Göster");
                Console.WriteLine("3-> Çıkış");
                Console.Write("Seçiminiz : ");

                int secim = Convert.ToInt32(Console.ReadLine());

                switch(secim)
                {
                    case 1:
                        Console.WriteLine("Eklemek istediğiniz notu girin: ");
                        string not = Console.ReadLine();
                        notlar.Add(not);
                        break;

                    case 2:
                        foreach(var n in notlar)
                        {
                            Console.WriteLine(n);
                        }
                        break; 

                    case 3:
                        Console.WriteLine("Programdan çıkılıyor...");
                        return ;

                    default:
                         Console.WriteLine("Geçersiz Seçim! Lütfen Tekrar Deneyiniz");
                        break; 
                }

                Console.WriteLine("\n***************************************************\n");

            }
        }
    }
}
