public class Kitap
{
    public string KitapAdi { get; set; }
    public string YazarAdi { get; set; }
    public string ISBN { get; set; }
    public int YayinYili { get; set; }

    public Kitap(string kitapAdi, string yazarAdi, string isbn, int yayinYili)
    {
        KitapAdi = kitapAdi;
        YazarAdi = yazarAdi;
        ISBN = isbn;
        YayinYili = yayinYili;
    }

    public override string ToString()
    {
        return $"Kitap Adı: {KitapAdi}, Yazar: {YazarAdi}, ISBN: {ISBN}, Yayın Yılı: {YayinYili}";
    }
}
