using System.Collections.Generic;

public class KitapListele
{
    public static void Listele(List<Kitap> kitaplar)
    {
        if (kitaplar.Count == 0)
        {
            Console.WriteLine("Kütüphanede kitap bulunmuyor.");
        }
        else
        {
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine(kitap.ToString());
            }
        }
    }
}
