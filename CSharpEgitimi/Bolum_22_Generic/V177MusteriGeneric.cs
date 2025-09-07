
//#region 3. not baslangıc

////using System;

////namespace Bolum_22_Generic
////{
////    public class V177MusteriGeneric
////    {
////        public int ID { get; set; }
////        public string MusteriNo { get; set; }
////        public string TcKimlikNo { get; set; }
////        public string Isim { get; set; }
////        public string SoyIsim { get; set; }
////        public DateTime DogumTarihi { get; set; }

////    }
////}

//#endregion

//#region 4. not generic class ları anlatmak için ornek


////using System;

////namespace Bolum_22_Generic
////{
////    public class V177MusteriGeneric<T>
////    {

////        public T ID { get; set; }
////        public T MusteriNo { get; set; }
////        public string TcKimlikNo { get; set; }
////        public string Isim { get; set; }
////        public string SoyIsim { get; set; }
////        public DateTime DogumTarihi { get; set; }

////    }
////}

//#endregion

//#region 6. not generic metot

////using System;

////namespace Bolum_22_Generic
////{
////    public class V177MusteriGeneric<T>
////    {
////        public T ID { get; set; }
////        public T MusteriNo { get; set; }
////        public string TcKimlikNo { get; set; }
////        public string Isim { get; set; }
////        public string SoyIsim { get; set; }
////        public DateTime DogumTarihi { get; set; }

////        public T MusteriNumarasiAl()
////        {
////            return MusteriNo;
////        }

////    }
////}

//#endregion

//#region 8 NOT YANLIS KULLANIM HAKKINDA

////using System;

////namespace Bolum_22_Generic
////{
////    public class V177MusteriGeneric<T, K>
////    {
////        public T ID { get; set; }
////        public T MusteriNo { get; set; }
////        public K TcKimlikNo { get; set; }
////        public K Isim { get; set; }
////        public K SoyIsim { get; set; }
////        public DateTime DogumTarihi { get; set; }


////        public T MusteriNumarasiAl()
////        {
////            return MusteriNo;
////        }



////    }
////}

//#endregion

//#region 8 NOT YANLIS KULLANIMI DUZENLE

//using System;

//namespace Bolum_22_Generic
//{
//    public class V177MusteriGeneric<T>
//    {
//        public T ID { get; set; }
//        public T MusteriNo { get; set; }
//        public string TcKimlikNo { get; set; }
//        public string Isim { get; set; }
//        public string SoyIsim { get; set; }
//        public DateTime DogumTarihi { get; set; }


//        public T MusteriNumarasiAl()
//        {
//            return MusteriNo;
//        }


//    }
//}

//#endregion





///*
 
//3. not bitiş program.cs den geldik

//4. not baslangıc

//Musterinin problarını buraya da yazalım 

//using System;

//namespace Bolum_22_Generic
//{
//    public class V177MusteriGeneric
//    {
//        public int ID { get; set; }
//        public string MusteriNo { get; set; }
//        public string TcKimlikNo { get; set; }
//        public string Isim { get; set; }
//        public string SoyIsim { get; set; }
//        public DateTime DogumTarihi { get; set; }

//    }
//}

//ve MusteriGeneric class ını generic hale getirecek son dokunusu yapalım <T>

//ilk hali 
//    public class V177MusteriGeneric
//generic hali
//    public class V177MusteriGeneric<T>

//<T> işaretler içindeki harf T herhangi  bir şey olabilir default olarak T kullanılır abc vs hersey olabilir

//<T> yazarak generic hale getirdik

//<T> yazarak MusteriGeneric class ına sunu söylemiş oluyorsun
//sen orneklenirken karsı tarafa bir soru sor 
//beni orneklemek istiyorsun ama içeri de bir T tipi var bu tipi doldur cunku kendi class ım içerisinde kullanma ihtimalim var 
//generic class ım bu bana yazılmıs beni orneklemek istiyorsan benı belirtmek zorundasın

//daha once string int olan tipleri T tipi yapabiliriz

//Mesela MusteriNo string idi

//oncesi
//        public string MusteriNo { get; set; }
//sonrası
//        public T MusteriNo { get; set; }

//orneklenirken bir <> tip verilecek buradaki T tipi de onu sahiplenecek

//aynısını id alanı içinde yapalım

//        public int ID { get; set; }
//        public T ID { get; set; }

//son durum 4. not region


//4. not bitiş program.cs e gidelim

//5. not bitiş

//6. not baslangıc

//generic bir metot olusturup bakalım nası oluyor

//6. not bitiş program.cs e gidelim

//7. not bitiş program.cs den geldik


//8. not baslangıc

//yanlıs kullanımı anlatmak için

//t tipinin yanına farklı bir tip verelim
//2 tane generic tipimiz olur

//ilk durum
//    public class V177MusteriGeneric<T>
//        public string TcKimlikNo { get; set; }
//        public string Isim { get; set; }
//        public string SoyIsim { get; set; }
//sonraki durum
//    public class V177MusteriGeneric<T,K>
//        public K TcKimlikNo { get; set; }
//        public K Isim { get; set; }
//        public K SoyIsim { get; set; }

//T tipinin yanına K tipi verdik 2 tane generic parametremiz oldu
//string olanları da K tipine degistirdik

//musterigeneric girdiğinde T olarak int ve musterino değerine K tipi girdiğinde TcKimlikNo Isim SoyIsim degerlerine atama yapacak boylece her yerde kullanabilirim

//GİBİ BİR KULLANIM YOK BIZIM OLUSTURDUGUMUZ TIPLERIMIZ SQL TABLOLARIMIZIN BİR KOPYASI OLARAK PROGRAMLARIMIZIN İÇERİSİNDE DURUR 
//BIZ TABLO ICERISINDEN OKUYACAGIMIZ DATANIN ZATEN TIPINI BILIYOR OLURUZ ONA GORE CLASS IMIZI MODELLERIZ 
//BOYLE BİR KULLANIM SOZ KONUSU DEGILDIR 

//TEKRAR string TIPINE GERI DONELIM

//benim zaten sql tablomda bu alanlar string bunları ben farklı bir deger tutamam ki neden generic tutayım 
//o zaman generic class neden var 

//id ve musterino içinde bu durum aynı standart bir degerdir

//id int veya guid dir

//musterino int veya string olur runtime da degisir mi degismez 

//database uniq dir 
//uygulama database e bakar içerisindeki tabloyu okur 
//class ı modeller programı sunar 
//programcı datayı row olarak alır işler karsı tarafa gönderir 

//işte generic class lar nerde kullanılıyor 

//generic class ları biz gercek hayatta bu sekılde kullanmıyoruz ornegi bu sekılde bırakıyorum fakat boyle kullanmıyoruz

//id ne musterino ya t tipi veriyorum ki hata vermesin program.cs de kullandık diye sırf

//bu yukarıda anlatılan ornek ınternette kitaplar da generic mimarinın anlatımı oluyor ben boyle anlatılmasını yanlıs buluyorum 
//bakıldıgında bazı arkadaslar bir class olusturup ilgili veri tiplerini vermiş oldugu generic ifadelerle donatıp bunu kullanmak istiyolar 
//bu sizi bir hataya sevkeder bizim class larımız sql tablolarımızın bir kopyasıdır 
//biz o class larımızı içerisinde sql datalarımı barındrır işler ve database tekrar gönderiririz

//bir sonraki derste generic class lar hangi amacla kullanılır 
//kullanmamızın bize etki eden avantajları nelerdir 

//generic class olusturup nediri tekrar konusacagız

//generic class ne degildir bunu anlatmak istemiştik tanımı budur <T> gibi tanımlanır new lerken verdiğin tipe bürünür vs ama bu yöntemle kullanılmaz 

//gelecek derste n katmanli mimari kısmına ufak bir giriş yapıp generic class lara bakacagız 

//8. not bitiş program.cs e gidelim

 
//*/
