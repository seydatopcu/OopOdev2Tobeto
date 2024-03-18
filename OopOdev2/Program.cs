/*using System;
//1- polymorfizm ile ilgili 2 ayrı örnek yapınız.
//Örnek 1: Metot Çağrısı Polymorfizmi (Method Overriding)
/*
class Hayvan
{
    public virtual void SesCikar()
    {
        Console.WriteLine("Hayvan sesi...");
    }
}

class Kedi : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Kedi miyavlıyor...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hayvan hayvan = new Hayvan();
        hayvan.SesCikar();

        Kedi kedi = new Kedi();
        kedi.SesCikar();
    }
}
*/


//Örnek 2: Arayüz Polymorfizmi (Interface Polymorphism)

/*
using System;

interface ISekil
{
    void Ciz();
}

class Daire : ISekil
{
    public void Ciz()
    {
        Console.WriteLine("Daire çiziliyor...");
    }
}

class Kare : ISekil
{
    public void Ciz()
    {
        Console.WriteLine("Kare çiziliyor...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ISekil[] sekiller = new ISekil[2];
        sekiller[0] = new Daire();
        sekiller[1] = new Kare();

        foreach (ISekil sekil in sekiller)
        {
            sekil.Ciz();
        }
    }
}
*/



//2- inheritance ile ilgili 3 ayrı örnek yapınız.
//Örnek 1: Temel Sınıf ve Türetilmiş Sınıf
/*
using System;

class Hayvan
{
    public void YemekYe()
    {
        Console.WriteLine("Hayvan yemek yiyor...");
    }
}

class Kedi : Hayvan
{
    public void Miyavla()
    {
        Console.WriteLine("Kedi miyavlıyor...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kedi kedi = new Kedi();
        kedi.YemekYe();
        kedi.Miyavla();
    }
}
*/

//Örnek 2: Çok Düzeyli Miras (Multi-level Inheritance)

/*
using System;

class Canli
{
    public void SolunumYap()
    {
        Console.WriteLine("Canlı solunum yapıyor...");
    }
}

class Hayvan : Canli
{
    public void YemekYe()
    {
        Console.WriteLine("Hayvan yemek yiyor...");
    }
}

class Kedi : Hayvan
{
    public void Miyavla()
    {
        Console.WriteLine("Kedi miyavlıyor...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kedi kedi = new Kedi();
        kedi.SolunumYap();
        kedi.YemekYe();
        kedi.Miyavla();
    }
}
*/

//Örnek 3: Üyelerin Üzerine Yazma (Overriding Members)
/*
using System;

class Hayvan
{
    public virtual void SesCikar()
    {
        Console.WriteLine("Hayvan sesi...");
    }
}

class Kedi : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Kedi miyavlıyor...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hayvan hayvan = new Hayvan();
        hayvan.SesCikar();

        Kedi kedi = new Kedi();
        kedi.SesCikar();
    }
}
*/

//3- Generic type örneği yapınız
/*
using System;
using System.Collections.Generic;

class Program
{
    // Generic metod örneği
    static void Yazdir<T>(T veri)
    {
        Console.WriteLine("Veri: " + veri);
    }

    static void Main(string[] args)
    {
        // Generic sınıf örneği
        List<int> sayilar = new List<int> { 1, 2, 3, 4, 5 };
        foreach (int sayi in sayilar)
        {
            Yazdir(sayi);
        }

        // Generic metod kullanımı
        Yazdir<string>("Merhaba, dünya!");
        Yazdir<double>(3.14);
    }
}

*/

//5-Encapsulation:

/*

using System;

class Hesap
{
    // Private özellikler
    private string ad;
    private double bakiye;

    // Constructor
    public Hesap(string ad, double bakiye)
    {
        this.ad = ad;
        this.bakiye = bakiye;
    }

    // Public metodlar
    public void ParaYatir(double miktar)
    {
        if (miktar > 0)
        {
            bakiye += miktar;
            Console.WriteLine($"{miktar} TL yatırıldı. Yeni bakiye: {bakiye} TL");
        }
        else
        {
            Console.WriteLine("Yatırılacak miktar pozitif olmalıdır.");
        }
    }

    public void ParaCek(double miktar)
    {
        if (miktar > 0 && miktar <= bakiye)
        {
            bakiye -= miktar;
            Console.WriteLine($"{miktar} TL çekildi. Yeni bakiye: {bakiye} TL");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye veya geçersiz miktar.");
        }
    }

    public double BakiyeGoster()
    {
        return bakiye;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hesap hesap = new Hesap("Ahmet Yılmaz", 1000);
        hesap.ParaYatir(500);
        hesap.ParaCek(200);
        Console.WriteLine($"Güncel bakiye: {hesap.BakiyeGoster()} TL");
    }
}

*/