
//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public interface IV162Musteri
//    {
//        //public int Id { get; set; }
//        int Id { get; set; }
//        //string isim;
//        string isim { get; set; }
//        string soyisim { get; set; }

//        // metot

//        int yeniKayit(string isim, string soyisim);
//        int kayitDuzenle(int id, string isim, string soyisim);
//        int kayitSil(int id);

//    }
//}

///*
 
//1. not bitiş program.cs den geldik

//2. not baslangıc

//field metot ekleyelim

//ilk hali


//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public interface IV162Musteri
//    {

//    }
//}

//sonra field ekledik hata verdi

//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public interface IV162Musteri
//    {
//        public int Id { get; set; }
//    }
//}

//The modifier 'public' is not valid for this item in C# 7.3. Please use language version '8.0' or greater.

//bu zaten interface public yazmana gerek yok diyor 
 
// namespace Bolum_18_OOP_Interface_Abstract
//{
//    public interface IV162Musteri
//    {
//        //public int Id { get; set; }
//        int Id { get; set; }
//    }
//}

//get ve set eklemek zorundayız prob olması için get set olmazsa bunlar prob olmaz degisken olur interface içinde degisken tanımı yapılamaz.

//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public interface IV162Musteri
//    {
//        //public int Id { get; set; }
//        int Id { get; set; }
//        string isim;

//    }
//}
 
//Interfaces cannot contain instance fields

//prob eklediğinde arka tarafta bir degiskene baglı kaldıkları için prob tanımı kabul ediyor 

//field da ekledik

//metot eklemeye gecelim

//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public interface IV162Musteri
//    {
//        //public int Id { get; set; }
//        int Id { get; set; }
//        //string isim;
//        string isim { get; set; }
//        string soyisim { get; set; }

//        // metot

//        int yeniKayit(string isim, string soyisim);

//    }
//}

//metotlarda body almaz parametre alabilir

//interface de hiç bir tanımın body si olmaz buraya yazılan hersey şablon 

//metotlarda tamam interface imiz tamam


//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public interface IV162Musteri
//    {
//        //public int Id { get; set; }
//        int Id { get; set; }
//        //string isim;
//        string isim { get; set; }
//        string soyisim { get; set; }

//        // metot

//        int yeniKayit(string isim, string soyisim);
//        int kayitDuzenle(int id, string isim, string soyisim);
//        int kayitSil(int id);

//    }
//}

//biz bu interface i musteri class ında kalıttıgımız da bu şablon degerlerini bize sart kosacak 

//Musteri class ını olusturalım ve IMusteri interface ini miras verelim

//2. not bitiş

 
 
//*/