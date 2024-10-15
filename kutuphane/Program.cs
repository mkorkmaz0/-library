using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Kitap> kitaplar = new List<Kitap>();
        bool devam = true;

        while (devam)
        {
            Console.WriteLine("\n--- Kütüphane Yönetim Sistemi ---");
            Console.WriteLine("1. Kitap Ekle");
            Console.WriteLine("2. Kitapları Listele");
            Console.WriteLine("3. Kitap Ara");
            Console.WriteLine("4. Kitap Sil");
            Console.WriteLine("5. Çıkış");
            Console.Write("Seçiminizi yapın: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    KitapEkle.Ekle(kitaplar);
                    break;
                case "2":
                    KitapListele.Listele(kitaplar);
                    break;
                case "3":
                    KitapAra.Ara(kitaplar);
                    break;
                case "4":
                    KitapSil.Sil(kitaplar);
                    break;
                case "5":
                    devam = false;
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                    break;
            }
        }
    }
}

