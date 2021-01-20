using System;

namespace PeraOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Hesapla hesapla = new Hesapla();
            //Girilen parametrelere göre üçgen alanı hesaplama:
            Console.WriteLine("Üçgen alanı: "+hesapla.UcgenAlan(5, 6));

            //Girilen parametrelere göre dikdörtgen alanı hesaplama:
            Console.WriteLine("Dikdörtgen alanı: " + hesapla.DikdortgenAlan(7, 13));

            //Girilen parametrelere göre kare alanı hesaplama:
            Console.WriteLine("Kare alanı: " + hesapla.KareAlan(13));

            //Girilen parametrelere göre daire alanı hesaplama:
            Console.WriteLine("Daire alanı: " + hesapla.DaireAlan(13));
        }
    }
}
