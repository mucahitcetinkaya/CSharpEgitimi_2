//using System;

//namespace Bolum_16_OOP_Inner_Type_Kavrami
//{
//    public class Musteri145
//    {
//        #region Tekil olarak kullanılan field lar

//        public int musteriId { get; set; }
//        public string isim { get; set; }
//        public string soyIsim { get; set; }
//        public DateTime olusturmaTarihi { get; set; }
//        public int kullaniciAdi { get; set; }

//        #endregion

//        #region Inner Type Gerektiren Field lar

//        // MusteriAdres145 class ına tasındı
//        //public string AdresTip { get; set; }
//        //public string Il { get; set; }
//        //public string Ilce { get; set; }
//        //public string Adres { get; set; }

//        public MusteriAdres145[] musteriAdres145Liste;
//        public MusteriIletisimBilgisi146[] musteriIletisimBilgisi146Liste;
//        public MusteriSiparisBilgisi146[] musteriSiparisBilgisi146Liste;

        

//        #endregion



//    }
//}


///*
 
//1. not bitiş
//2. not başlangıc

//Musteri nesnem public olacak
//prop ile gereken bilgileri yazalım

//tekil olanları yazdık

//        #region Tekil olarak kullanılan field lar

//        public int musteriId { get; set; }
//        public string isim { get; set; }
//        public string soyIsim { get; set; }
//        public DateTime olusturmaTarihi { get; set; }
//        public int kullaniciAdi { get; set; }

//        #endregion

//ınner type ları yazacagız şimdi

//adres mesela benım musterimin birden fazla adresi olabilir
//ben burda 
//        public string Adres { get; set; }
//olarak yazarsam belirli bir kriter koymus olurum
//belirli bir adet kadar Musteri almıs olurum 
//bunun bir ornegını yapalım 

//        #region Inner Type Gerektiren Field lar

//        public string AdresTip { get; set; }
//        public string Il { get; set; }
//        public string Ilce { get; set; }
//        public string Adres { get; set; }

//        #endregion

//boyle yaptıgımızı dusunursek musterının farklı farklı adreslerının oldugunu dusunursek 
//AdresTip1 AdresTip2 AdresTip3 vs gibi aslında aynı ama içeride kendını tekrar eden field blokları olusturmus oluruz 
//bu tarz kullanım yerıne aslında modellemek istediğimiz konu su 
//Adres adında veya MusteriAdresı adında bir tip class olusturmak burda olusturduklarımızı 
//MusteriAdresi nesnesinin içerisine aktarmak ve musteri nesnemizin içerisinde bir koleksiyon olarak 
//adresımızı tanımlamak ve boylece innertype kullanımını gerceklestırmıs olacagız 

//yeni bir class olusturalım MusteriAdres145

//burda olusturdugumuz field lar MusteriAdres145 class ına tasınacak

//ben burda şimdi 2 farklı tipe sahip oldum Musteri ve MusteriAdres nesnesi 

//ama benım Musteri nesnem MusteriAdres nesnesinin varlıgını henuz bilmiyor 
//bunu bildirmek lazım bunun için de innertpye alanında bunu cagıralım

//        public MusteriAdres145[] musteriAdres145Liste;

//MusteriAdres145 adında bir dizi tanımı yaptık 
//benim Musteri nesnem birden fazla MusteriAdresini bu sekilde içinde barındırabilecek

//bunu ornekleyip uzerınden de gececegız arkadaslar sadece tanım yapıyoruz 

//2. not bitiş

//Video 146 a gecelim

//3. not baslangıc

//MusteriAdres nesnemizi Musteri nesnemizin içerisine dizi olarak verdik ve innertype tanımı yaptık 
//Musterimizin iletişim bilgilerini aynı metodu kullanarak olusturalım ve Musteri nesnemizin içerisine ekleyelim

//MusteriIletisimBilgisi146 nesnesini olusturalım
//gerekli ozellikleri yazalım MusteriIletisimBilgisi146 gidelim

//3. not bitiş
//4. not bitiş

//5. not baslangıc

//MusteriIletisimBilgisi146 olusturduk proplarını yazdık şimdi burda tanıtalım

//baska neyi olabilir musterinin alısverişleri olabilir 
//sipariş numaralarını burda tutabiliriz 
//biraz ucunu acık bırakacagım neden cunku musterinin siparişlerini burda yaptıgım anda 

//musterinin şipariş anında vermiş oldugu urunlerı de tutabiliriz vs vs vs böyle gider bu o kadar dallanmayı bu video da dusunmuyorum
//bolum sonu odevı olarak size hazırlamayı dusunuyorum 

//yeni bir class olusturalım 

//MusteriSiparisBilgisi146 oraya gidelim proplarını yazalım 

//5. not bitiş

//6. not bitiş

//7. not baslangıc

//MusteriSiparisBilgisi146 nesnesını tanıtalım bir dizi olacak

//Program.cs e gidelim Musteri145 i ornekleyelim

//bir sonraki video da ornekleme ve kullanma asamasına gececeğiz

//7. not bitiş

//*/