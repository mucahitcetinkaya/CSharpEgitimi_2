//using System;

//namespace Bolum_16_OOP_Inner_Type_Kavrami
//{
//    public class Musteri147
//    {

//        #region Tekil olarak kullanılan field lar

//        public int musteriId { get; set; }
//        public string isim { get; set; }
//        public string soyIsim { get; set; }
//        public DateTime olusturmaTarihi { get; set; }
//        public int kullaniciId { get; set; }
//        public string tcKimlikNumarasi { get; set; }

//        #endregion

//        #region Inner Type Gerektiren Field lar

//        public MusteriAdres147[] musteriAdres147Liste;
//        public MusteriIletisimBilgisi147[] musteriIletisimBilgisi147Liste;
//        public MusteriSiparisBilgisi147[] musteriSiparisBilgisi147Liste;

//        #endregion

//        public Musteri147()
//        {
//            musteriAdres147Liste = new MusteriAdres147[5];
//            musteriIletisimBilgisi147Liste = new MusteriIletisimBilgisi147[3];
//            musteriSiparisBilgisi147Liste = new MusteriSiparisBilgisi147[10];
//        }

//    }
//}


///*
 
//1. not bitiş
 
//2. not baslangıc

//ctor olusturup new leyelim 

//  public Musteri147()
//        {
//                musteriAdres147Liste = new MusteriAdres147[5];
//        }

//digerleri için de bunları yapabiliriz
 
// public Musteri147()
//        {
//            musteriAdres147Liste = new MusteriAdres147[5];
//            musteriIletisimBilgisi147Liste = new MusteriIletisimBilgisi147[5];
//            musteriSiparisBilgisi147Liste = new MusteriSiparisBilgisi147[5];
//        }

//bunların dizi sayısının 3-5 adet olması su anlık ornek vermek amacıyla list generic konusuna geldiğimiz de istediğimiz kadar olabilecek
//henuz oraya hazır olmadıgımız için bu sekılde bırakıyorum 

//şimdi nesnenin davranıs biçimine bakalım 

//            musteriAdres147Liste = new MusteriAdres147[5]; buraya breakpoint koyalım

//program.cs e gidelim 

//2. not bitiş

//*/