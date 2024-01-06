using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bufferMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buffer sınıfının örnek kullanım
            byte[] sourceArray = { 1, 2, 3, 4, 5 };
            byte[] targetArray = new byte[5];

            // Buffer.BlockCopy metodu ile byte dizileri arasında hızlı kopyalama yapma
            Buffer.BlockCopy(sourceArray, 0, targetArray, 0, sourceArray.Length);

            //Kopyalanan değerleri ekrana yazdırma 
            Console.WriteLine("Kopyalanan Değerler: ");
            foreach(var value in targetArray) Console.WriteLine(value + " ");
        }
    }
}
