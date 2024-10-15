using System.Collections.Generic;

public class KitapEkle
{
    public static void Ekle(List<Kitap> kitaplar)
    {
        Console.Write("Kitap Adı: ");
        string kitapAdi = Console.ReadLine();
        Console.Write("Yazar Adı: ");
        string yazarAdi = Console.ReadLine();
        Console.Write("ISBN: ");
        string isbn = Console.ReadLine();
        Console.Write("Yayın Yılı: ");
        int yayinYili = int.Parse(Console.ReadLine());

        kitaplar.Add(new Kitap(kitapAdi, yazarAdi, isbn, yayinYili));
        Console.WriteLine("Kitap başarıyla eklendi!\n");
    }
}
