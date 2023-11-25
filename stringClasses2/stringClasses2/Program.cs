using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringClasses2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PadRight & PadLeft

            string originalString = "Hello";
            // PadRight: Sağa doğru belirtilen uzunluğa kadar karakter ekler
            string paddedRight = originalString.PadRight(10, '_');

            // PadLeft: Sola doğru belirtilen uzunluğa kadar karakter ekler
            string paddedLeft = originalString.PadLeft(10, '*');
            Console.WriteLine("Original String: " + originalString);
            Console.WriteLine("Padded Right: " + paddedRight);
            Console.WriteLine("Padded Left: " + paddedLeft);

            //StartsWith & EndsWith

            string text = "Hello World!";
            // StartsWith: Belirtilen bir önek ile başlayıp başlamadığını kontrol eder
            bool startsWithHello = text.StartsWith("Hello");

            // EndsWith: Belirtilen bir sonek ile bitip bitmediğini kontrol eder
            bool endsWithHello = text.EndsWith("World!");

            Console.WriteLine("Text: " + text);
            Console.WriteLine("Starts with 'Merhaba': " + startsWithHello);
            Console.WriteLine("Ends with 'dünya!': " + endsWithHello);

            //Split & Join

            string sentence = "Bu bir örnek cümledir.";

            // Split: Belirtilen ayırıcıya göre metni parçalar ve bir diziye atar
            string[] words = sentence.Split(' ');

            // Join: Bir dizi içindeki öğeleri belirtilen ayırıcı ile birleştirir
            string joinedSentence = string.Join(" ", words);

            Console.WriteLine("Original Sentence: " + sentence);
            Console.WriteLine("Split Words:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("Joined Sentence: " + joinedSentence);
        }
    }
}
