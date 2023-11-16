using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = { "Armut", "Çilek", "Elma", "Muz", "Kiraz" };

            Console.WriteLine("Meyveler : ");

            foreach(string meyve  in meyveler)
            {
                Console.WriteLine(meyve);
            }
            Console.WriteLine(" \nProgramı kapatmak için bir tuşa basınız...");
            Console.ReadLine(); // Kullanıcıdan bir giriş bekler, sonra program kapanır.
        }
    }
}
