//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bolum_12_Metot
//{
//    public class Ogrenci114
//    {
//        public void OgrenciPuanHesaplama(string ad, string soyAd, decimal not1, decimal not2, decimal not3 = 45)
//        {
//            Console.WriteLine("Öğrencinin bilgileri aşağıdaki gibidir...");
//            Console.WriteLine("Ad Soyad : {0} {1}", ad, soyAd);

//            //decimal ortalama = OrtalamaHesapla(not1, not2, not3);
//            //OrtalamaNotDegerlendir(ortalama);

//            OrtalamaNotDegerlendir(OrtalamaHesapla(not1, not2, not3));
//        }

//        void OrtalamaNotDegerlendir(decimal ogrenciOrtalama)
//        {
//            if (ogrenciOrtalama > 45)
//            {
//                Console.WriteLine("Ortalama değeriniz : {0} - Geçtiniz!", ogrenciOrtalama);
//            }
//            else
//            {
//                Console.WriteLine("Ortalama değeriniz : {0} - Kaldınız!", ogrenciOrtalama);
//            }
//        }

//        private decimal OrtalamaHesapla(decimal privateNot1, decimal privateNot2, decimal privateNot3)
//        {
//            //decimal ortalama = (privateNot1 + privateNot2 + privateNot3) / 3;
//            //return ortalama;

//            return (privateNot1 + privateNot2 + privateNot3) / 3;
//        }

//    }
//}


///*

//şimdide parametrelerin biraz daha detaylarına girelim
//bazen metot içerisinde istemiş oldugumuz degerlerin hepsini kullanıcı bize vermez
//yada biz bunu uygulama içerisinden net olarak alamayabiliriz
//bu gibi durumlarda default bir deger atamamız gerekebilir
//yani eger not 3 girilmediyse bunu default olarak 45 olarak gir diyebiliriz

//mesela program.cs e gidelim
//program.cs den geldik zorunlulugu kaldırmak için

//decimal not3 = 45

//yazarsak eger default degeri 45 olarak atanır 
//girilmese de olur zaten biz girmiş oluyoruz

//program.cs e gidelim


//*/