//namespace Bolum_14_OOP_Kapsulleme
//{
//    public class Musteri128
//    {

//        /* 2. not */
//        /* bunlar class ın Field ları yani alanları */
//        public int id;
//        public string isim;
//        public string soyIsim;

//        private string eMailAdres;

//        /* Class => Property -- prop tab tab */

//        public string EMailAdres
//        {
//            set {
//                this.eMailAdres = value;
//            }

//            get {
//                return this.eMailAdres;
//            }


//        }



//    }
//}




///*
 
//1. not bitiş
//2. not baslangıc

//// bunlar class ın Field ları yani alanları
//public int id;
//public string isim;
//public string soyIsim;

//class her yerden ulasılsın diye public yapabilirsin
//internal de olabilir o zaman namespace altında olanlar aynı catıda olanlar ulasabilir
//mesela biz bir dll kutuphane hazırladık diyelim ama bu kutuphanenın bu class ı görmesini istemiyoruz o zaman internal yaparsın görmez

//field yazalım 
//Program.cs e gidelim

//2. not bitiş
//3. not bitiş

//4. not baslangıc

////public string eMailAdres;

//email adres alanını ekledik Program.cs e dönelim

//5. not bitiş

//6. not baslangıc

//// private string eMailAdres;

//benim field ıma direk olarak erişememem gerekiyor
//yani benim bu field i onu cagıran her yerden kapatmam lazım
//bunu yapmak için ilgili field in erişim belirleyicisini kapatmam lazım
//private demek gerekiyor
//private demek actıgın class içinde Musteri128 in içinde kullan baska yerde gözükmesin demek

//Program.cs de Musteri128 i new leyerek eMailAdres i kullandık public ken private yaptık şimdi hata veriyor olması gerek gidip bakalım
//Program.cs e gidelim

//6. not bitiş
//7. not bitiş

//8. not baslangıc

//benim öyle bir şeye ihtiyacım var ki dıs dunyaya public olacak
//aldıgı degeri iç dunyadaki email adresine gönderecek

//işte bu noktada property dedıgımız kavramla karsılasıyoruz

//Class içindeki property ler prop lar özellikler

//Class => Property -- prop tab tab

//prop tab tab kolay yazılımı olur

//public her yere acık olsun
//veri tipi string olsun
//EMailAdres olarak cagrılsın
//field lar da normal degisken gibi ilk harfi kucuk prop yazacaksan eger ilk harfi büyük olması genel bir yazılı olmayan kuraldır.

//buraya kadar üstüne geldiginde hala field olarak geçiyor
//bundan sonra süslü parantez acarsan 

//o zaman property olarak yani özellik olarak geçiyor
//süslü parantez içinde de get set blokları bulunur

//public string EMailAdres { get; set; }

//get ve set blokları ne iş yapar

//fieldlar class ın gercek deger tutan alanları
//yalıtmak için private olarak yazdık

//get; database veya farklı bir veri kaynagından datayı cektigimizi dusunun
//get dedigimiz metot degeri karsıya gösterir
//cagıran kişi .EMailAdres dediginde bir get işlemi yapmıs olurr
//ilgili datayı almak ister
//kim alıyor class ı cagıran programcı alıyor
//class ı cagıran programcıya datayı gösterdiğimiz kısım

//set; ben bu musteri class ının içerisindeki private olarak işaretlemiş oldugum
//email adresine deger ataması yaptıgım kısım 
//dıs dunyadan alıyorum datayı cektim istediğim işlemi yaptım

//eger işlemlerime uygunsa içeride private olarak sakladıgım 
//kimsenin görmesini istemediğim sakladıgım alanıma datayı atacagım kısım

//bunları özelleştirmezsen field yerine hepsine prop olarak da yazsan yine uygulama calısır
//her hangi bir şart olmadıgı için

//Program.cs e yine gidelim bu sefer prop olana deger ataması yapalım en son hata vardı priate olarak degistirdiğimiz için bakalım ne olacak

//8.not bitiş

//10. not baslangıc

//        public string EMailAdres {  get; set; }

//public string EMailAdres
//        {
//            set {

//            }


//        }

//öncelikle set edelim set ten baslayalım
//bana deger geldiğinde set blogu calısacak
//bana gelen degeri ben nasıl yakalarım
//value dediğimiz anahtar kelime ile
//ben bana gelen degeri yakalayabilirim
//value nun içinde su anda mucahit@hotmail.com bilgisi var
//ben bu bilgiyi nereye atayacagım
//                this.eMailAdres = value;
//bu class ın içerisinde private olarak sakladıgım 
//field ın içine atama yapacagım

//get içinde de return edecegiz
//field in içindeki bilgiyi cagıran kişiye gönder demiş olacagız

//public string EMailAdres
//        {
//            set {
//                this.eMailAdres = value;
//            }

//            get {
//                return this.eMailAdres;
//            }


//        }

//buralara da breakpoint koyalım ve bakalım neler oluyor

//10. not bitiş

//12. not baslangıc

//value da bizim degerimiz var yolladıgımız mail adresi
//ben bu value da istedigim işlemi yaparım
//metoda gönderirim dogrulugunu kontrol ettiririm
//if else sartına sokarım
//bunun sonucunca benim kriterlerime uyuyorsa
//this.email ile class ın içerisine private olarak saklamıs oldugum field a degeri atayacagım
//f10 ile geçelim program.cs e geri gönderecek

//12. not bitiş

//14. not baslangıc

//get blogu için console.write yazdık get bloguna dustu
//geri program.cs e döndü



//*/