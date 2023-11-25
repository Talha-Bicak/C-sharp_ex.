using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir int değerini byte dizisine dönüştürme
            int sayi = 123456789;
            byte[] byteDizisi = BitConverter.GetBytes(sayi);

            Console.WriteLine("Orijinal Sayı: " + sayi);

            Console.WriteLine("Byte Dizisi");
            foreach (byte b in byteDizisi) {  Console.WriteLine(b + " "); }

            //Byte dizisini int değerine dönüştürme(eski haline getirme)

            int yeniSayi  = BitConverter.ToInt32(byteDizisi, 0);
            Console.WriteLine("\n Yeniden Oluşturulan Sayı: " + yeniSayi);

            Console.WriteLine("\n####################################################\n");

            if (BitConverter.IsLittleEndian)
            {
                Console.WriteLine("Sisteminiz düşük mimariyi destekliyor en anlamlı bit sonda\n");
            }
            else {
                    Console.WriteLine("Sisteminiz yüksek mimariyi destekliyor en anlamlı bit başta\n");
                }
            
        }
    }
}
