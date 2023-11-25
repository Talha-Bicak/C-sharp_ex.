using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringClasses3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalString = "Merhaba, dünya!";

            // ToUpper: Stringin tüm karakterlerini büyük harfe çevirir
            string upperCaseString = originalString.ToUpper();

            // ToLower: Stringin tüm karakterlerini küçük harfe çevirir
            string lowerCaseString = originalString.ToLower();

            Console.WriteLine("Original String: " + originalString);
            Console.WriteLine("Upper Case String: " + upperCaseString);
            Console.WriteLine("Lower Case String: " + lowerCaseString);

            // Remove: Belirtilen indeksten itibaren belirtilen sayıda karakteri kaldırır
            string removedString = originalString.Remove(3, 5);

            // Insert: Belirtilen indekse yeni bir string ekler
            string insertedString = originalString.Insert(7, " sevgili");

            Console.WriteLine("Original String: " + originalString);
            Console.WriteLine("Removed String: " + removedString);
            Console.WriteLine("Inserted String: " + insertedString);

            // Replace: Belirtilen karakteri veya karakterleri başkalarıyla değiştirir
            string replacedString = originalString.Replace('a', 'e');

            Console.WriteLine("Original String: " + originalString);
            Console.WriteLine("Replaced String: " + replacedString);

            // Substring: Belirtilen indeksten itibaren belirtilen sayıda karakteri alır
            string substring = originalString.Substring(8, 5);

            Console.WriteLine("Original String: " + originalString);
            Console.WriteLine("Substring: " + substring);

            int IndexOfString = originalString.IndexOf("a"); //Belirtilen metni arar ve ilk indexi döndürür.
            int LastIndexOfString = originalString.LastIndexOf("a"); //Belirtilen metni arar ve son index değerini döndürür.

            Console.WriteLine(IndexOfString + " " + LastIndexOfString); //Eğerki metinler bulunamazsa çıktı : -1 -1
        }
    }
}
