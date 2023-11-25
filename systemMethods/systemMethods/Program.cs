using System;

class Kisi : IComparable
{
    public string Ad { get; set; }
    public int Yas { get; set; }

    public Kisi(string ad, int yas)
    {
        Ad = ad;
        Yas = yas;
    }

    // IComparable arabiriminden türetilen CompareTo metodu
    public int CompareTo(object obj)
    {
        if (obj == null) return 1;

        Kisi digerKisi = obj as Kisi;
        if (digerKisi != null)
            return this.Yas.CompareTo(digerKisi.Yas);
        else
            throw new ArgumentException("Object is not a Kisi");
    }

    // Object.Equals metodunun override edilmesi
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Kisi digerKisi = (Kisi)obj;
        return (Ad == digerKisi.Ad) && (Yas == digerKisi.Yas);
    }

    // Object.ToString metodunun override edilmesi
    public override string ToString()
    {
        return $"Ad: {Ad}, Yas: {Yas}";
    }
}

class Program
{
    static void Main()
    {
        // Parse örneği
        int sayi = int.Parse("42");
        Console.WriteLine($"Parse Örneği: {sayi}");

        // CompareTo örneği
        Kisi kisi1 = new Kisi("Ahmet", 25);
        Kisi kisi2 = new Kisi("Mehmet", 30);
        int karsilastirmaSonucu = kisi1.CompareTo(kisi2);
        Console.WriteLine($"CompareTo Örneği: {karsilastirmaSonucu}");

        // Equals örneği
        Kisi kisi3 = new Kisi("Ahmet", 25);
        bool esitMi = kisi1.Equals(kisi3);
        Console.WriteLine($"Equals Örneği: {esitMi}");

        // ToString örneği
        Console.WriteLine($"ToString Örneği: {kisi1.ToString()}");
    }
}
