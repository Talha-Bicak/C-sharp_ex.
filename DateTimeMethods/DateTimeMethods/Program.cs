using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Şu anki tarih ve saat değerini al
            DateTime suAn = DateTime.Now;
            Console.WriteLine($"Şu anki tarih ve saat: {suAn}");

            // Belirli bir tarih ve saat değerini oluştur
            DateTime yeniYil = new DateTime(2023, 1, 1, 0, 0, 0);
            Console.WriteLine($"Yeni Yıl {yeniYil}");

            // İki tarih arasındaki farkı hesapla
            TimeSpan fark = yeniYil - suAn;
            Console.WriteLine($"Yebi Yıla KAlan Gün: {fark.Days}");

            // Tarih ve saat değerini özel bir biçimle yazdır
            Console.WriteLine($"Özel Biçim: {suAn.ToString("dd/MM/yyyy HH:mm:ss")}");

            // Tarih ve saat değerini arttırma
            DateTime birHaftaSonrasi = suAn.AddDays(7);
            Console.WriteLine($"Bir hafta sonrası: {birHaftaSonrasi}");

            //Bir tarih ve saat string'ini DateTime türüne çevirme

            string tarihSaatString = "2023-11-15 14:30";
            DateTime tarihSaat = DateTime.Parse( tarihSaatString );

            Console.WriteLine($"Çözümlenen Tarih ve Saat: {tarihSaat}");
        }
    }
}
