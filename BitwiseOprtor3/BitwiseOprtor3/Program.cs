using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOprtor3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin = "Merhaba , Ben Talha!";
            string anahtar = "Key123";

            Console.WriteLine($"Orjinal Metin {metin}");

            //Şifreleme 
            string sifreliMetin = XOR( metin, anahtar );
            Console.WriteLine($"Şifreli Metin: {sifreliMetin}");

            // Şifre Çözme 
            string cozulmusMetin = XOR(sifreliMetin , anahtar );
            Console.WriteLine($"Çözülmüş Metin: {cozulmusMetin}");
            
            Console.ReadLine();

        }
        static string XOR(string text , string key)
        {
            StringBuilder encryptedText = new StringBuilder();

            for(int i= 0; i < text.Length; i++)
            {
                char encryptedChar = (char)(text[i] ^ key[i % key.Length]); //XOR ile şifreleme işlemleri
                encryptedText.Append(encryptedChar);
            }
            return encryptedText.ToString();
        }
    }
}
