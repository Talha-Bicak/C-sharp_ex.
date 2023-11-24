using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace destructors
{
    // IDisposable arabirimini uygulayan bir sınıf
    class DisposableClass : IDisposable
    {
        // Bellek yönetimiyle ilgili temizleme işlemleri burada yapılır
        public void Dispose()
        {
            //Dispose() metodu: Bir işlemi sonlandırır ve bellekten atar. Bellekten atılan veri üzerinde tekrar işlem yapılmaz.
            Console.WriteLine("Dispose Methodu Çağırıldı");
            // Nesne ile ilgili temizleme işlemleri burada yapılabilir
            // Örneğin, açık dosya kaynakları, veritabanı bağlantıları kapatılabilir
        }

        //Başka İşlemler
        public void SomeOperation()
        {
            Console.WriteLine("SomeOperation Methodu Çağırıldı...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        
            using (DisposableClass nesne = new DisposableClass()) //Using bloğu bu nesnelerin kullandığı yönetimsiz kaynakları doğru bir biçimde serbest bırakacaktır.
            {
                // IDisposable arabirimini uygulayan sınıfın örneği
                nesne.SomeOperation();
                // Bu blok sonunda Dispose metodu otomatik olarak çağrılır
            }

        }
    }
}
