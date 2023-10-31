using Metotlar;
using System.Security.Claims;

internal class Program
{
    private static void Main(string[] args)
    {
        string urunAdi = "elma";
        double urunFiyati = 15;
        string aciklama = "Amasya elması";

        Urun urun1= new Urun();//bir class tanımlamak için oluşturulan örnek yapı
        urun1.Adi = "Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "Amasya Elması";

        Urun urun2=new Urun();
        urun2.Adi = "Çilek";
        urun2.Fiyati = 20;
        urun2.Aciklama = "Çilek gibi çilek";
        Urun[] urunler= new Urun[] {urun1, urun2};
        foreach (Urun urun in urunler)
        {
            Console.WriteLine("Ürün Adı:" + urun.Adi);
            Console.WriteLine("Ürün Fiyatı:" + urun.Fiyati);
            Console.WriteLine("Ürün Açıklaması:" + urun.Aciklama);
            Console.WriteLine("---------------------------");
        }
        Console.WriteLine("----------Metotlar----------");
        //instance ----> örneğini oluşturma işlemi 
        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);
        

    }
}