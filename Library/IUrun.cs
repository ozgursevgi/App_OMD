using System;

//Belli özellikler bir arada interface olarak yazılmalı
public interface IUrunTemel
{
    int ID { get; set; }
    string UrunAd { get; set; }
    string UrunKısaAd { get; set; }
   
}

public interface IUrunFiyat
{
     int UrunFiyat1 { get; set; }
     int UrunFiyat2 { get; set; }
     int UrunEtkinKur { get; set; }
     int UrunTL { get; set; }
     //enum UrunParaBirimi { }


}

public interface IUrunKod
{
    //Bu Bölümü Değiştirdim 
     int UrunBarkod { get; set; }
     int UrunKoliAdet { get; set; }
     //enum UrunReyon{ }
     //enum UrunGrup { }
     //enum UrunBirim { }
     //public string UrunSatınAlmacı { get; set; }
    
}


