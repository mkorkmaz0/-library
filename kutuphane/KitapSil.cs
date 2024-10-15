using System.Collections.Generic;

public class KitapSil
{
    public static void Sil(List<Kitap> kitaplar)
    {
        Console.Write("Silmek istediğiniz kitabın ISBN numarasını girin: ");
        string isbn = Console.ReadLine();

        var kitap = kitaplar.Find(k => k.ISBN == isbn);

        if (kitap != null)
        {
            kitaplar.Remove(kitap);
            Console.WriteLine("Kitap başarıyla silindi.");
        }
        else
        {
            Console.WriteLine("Kitap bulunamadı.");
        }
    }
}
