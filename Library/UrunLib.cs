using System;

public class Urun : IUrunTemel,IUrunFiyat,IUrunKod
{

    //Bu proplar formdan okunacak ya da set edilecek
    public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string UrunAd { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string UrunKısaAd { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int UrunFiyat1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int UrunFiyat2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int UrunEtkinKur { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int UrunTL { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int UrunBarkod { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int UrunKoliAdet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void UrunKaydet() //Kaydet butonuna olay olarak eklenecek
    {
        //eğer gerekli yerler boşsa işlem yapmayacak
        //if (txtUrunID==null||txtUrunAd==null || txtUrunFiyat == null || txtUrunBarkod == null)
        //{
        //    return;
        //}
        //ürün oluşturacak
        Urun urun = new Urun {ID=this.ID, UrunAd=this.UrunAd,UrunKısaAd=this.UrunKısaAd,UrunBarkod=this.UrunBarkod,UrunEtkinKur=this.UrunEtkinKur,UrunFiyat1=this.UrunFiyat1};
        //tablolara yazım işlemi aşşağıda olacak
        //...
    }

    public void UrunSil() //ürün silme işlemini yapacak
    {

    }

    public void UrunAra()// ürün arama işlemini yapacak
    {

    } 
}
