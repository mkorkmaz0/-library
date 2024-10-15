using System.Collections.Generic;

public class KitapAra
{
    public static void Ara(List<Kitap> kitaplar)
    {
        Console.Write("Aramak istediğiniz kitabın adını girin: ");
        string kitapAdi = Console.ReadLine();

        var bulunanKitap = kitaplar.Find(k => k.KitapAdi.ToLower().Contains(kitapAdi.ToLower()));

        if (bulunanKitap != null)
        {
            Console.WriteLine(bulunanKitap.ToString());
        }
        else
        {
            Console.WriteLine("Kitap bulunamadı.");
        }
    }
}
