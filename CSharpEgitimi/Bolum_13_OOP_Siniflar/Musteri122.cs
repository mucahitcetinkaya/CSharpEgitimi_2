//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bolum_13_OOP_Siniflar
//{

//    ////1. not hali 

//    //class Musteri122
//    //{
//    //    string TcKimlikNumarasi;
//    //    string isim;
//    //    string soyIsim;
//    //    int cinsiyet;
//    //}


//    //// 2. not hali
//    //class Musteri122
//    //{
//    //    public string TcKimlikNumarasi;
//    //    string isim;
//    //    string soyIsim;
//    //    int cinsiyet;

//    //    public void Selam1()
//    //    {
//    //        Console.WriteLine("metotu gormek için yazdım sadece");
//    //    }

//    //    public static void Selam2()
//    //    {
//    //        Console.WriteLine("static farkı new lemeye gerek kalmıyor direk class ismi ile cagırabiliyorsun");
//    //    }
//    //}

//    // 3. not hali
//    public class Musteri122
//    {
//        public string TcKimlikNumarasi;
//        public string isim;
//        public string soyIsim;
//        public int cinsiyet;

//    }


//}


///*

//her yerden ulaşabilmek için public yapıyoruz

//Program.cs den geldik - 1 . not

//burda ne saklamak istiyoruz musterimizin temel ihtiyaclarını saklamak istiyoruz
//bunlar neydi hatırlayalim

//tc kimlik numarası
//isim
//soyisim
//cinsiyet

//ben bu bilgileri tutmak istiyorum
//peki ben bilgileri neyin içinde tutabilirim
//değişkenlerin içinde tutmam lazım

//demek ki benım bu isimlerde ve bunların isimlerine uygun 
//veri tiplerinde degiskenler tanımlamam lazım


//        cinsiyetin int olmasının sebebi mesela örnek olarak 
//        7177770001 girilirse Bay
//        7177770002 girilirse Bayan
//        bunu neden boyle yaptık sonra değineceğiz

//tanım olarak musteri class ımız tamam gibi gözüküyor
//program cs e donelim ve neler yapabiliriz bunlara bakalım

//1 . not bitişi

//2. not baslangıc

//M1. dedıgımızde Program.cs e buradaki ozelliklere ulasamıyoruz
//bunun sebebi class ın olusturuldugunda 
//erişim belirleyicilerinin uygun olarak ayarlanmamıs olması
//diger taraftan gormek için
//class ımızıdaki alanları public olarak degistirelim

//public olunca genele acık oluyor 
//private olunca kendı içinde kullanabiliyoruz

//class tanımlarımız da da bu böyle 
//class ımızı ve içerisindeki field larımızı 
//public dersek dıs dunyaya acabiliyoruz
//private dersek class ın içerisinde kullanabiliyoruz

//o zaman yazdıgımız ozellikleri de public olarak yazalım
//sadece TcKimlikNumarasi nı public yapalım o gozuksun digerleri gozukmesin
//kolay yazmak için
//prop tab tab yazdıgında kolay olarak property olusturabilirsin

//baslarına public yazıp program.cs de M1. dediğimizde bunlara artık ulasabiliriz

//program.cs e bakalım gözüküyor mu

//burdan sonraki notlar da ben metot denemesi yaptım

//classs ıcındeki olusturalan ozelliklere property deniyor genel isim olarak
//bunların her birine de program içinde field deniyor
//mesela M1. dedıgımızde yanında tooltype olarak field yazdıgını gorursun

//metotlar turuncu bir küp olarak gözüküyor tooltype olarak

//2. not bitiş

//3. not baslangıc

//diger alanları da public yapalım
//diger alanlarda public oldu
//artık herhangi bir yerden bunlara erişebiliriz
//class ımızı da public olarak degistirelim
//program.cs e geri gidip diger alanları da dolduralım

//3. not bitiş







//*/