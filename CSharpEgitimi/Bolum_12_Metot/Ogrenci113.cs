//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bolum_12_Metot
//{
//    public class Ogrenci113
//    {
//        public void OgrenciPuanHesaplama(string ad, string soyAd, decimal not1, decimal not2, decimal not3)
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

//yeni bir metot olusturalım 

//OgrenciPuanHesaplama daki if sartlarını metot olarak yazacagız cagıracagız

//erişim beliryecisi yazmazsak eger default olarak private anlar ortalama

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

//private bir metot hazırladık decimal bir parametre istedik

// OgrenciPuanHesaplama a gidip yeni yazdıgımız metodu cagıralım 

//OrtalamaNotDegerlendir yazdıgımız da tooltype olarak bizden istedikleri geliyor 
//decimal OgrenciOrtalama yazıyor
//bu metot bizden decimal bir deger istiyor 
//adının illa OgrenciOrtalama olmasına gerek yok 
//sadece içine yazacagın decimal deger olmak zorunda

//bir önceki derste bosuna degisken tutmanın zarar olacagından bahsemiştik

//        decimal ortalama = OrtalamaHesapla(not1, not2, not3);

//bunu boyle yazıyoruz sadece metot içinde degısken adını kullanıyoruz herhangi bir işlemden geçmiyor if else gibi

//bunun yerıne metot içinde ortalama degiskenın yaptıgı işi yazalım 
//metot içinde metot cagırmıs olacagız

//            OrtalamaNotDegerlendir(OrtalamaHesapla(not1, not2, not3));

//bastan işleyişi anlatalım 

//OgrenciPuanHesaplama a gidecek degerleri alacak
//decimal ortalama = OrtalamaHesapla(not1, not2, not3); a gelecek
//OrtalamaHesapla metoduna gidip işlemleri yapıp return edecek sonuc ortalama degiskenıne gelecek
//ortalama değişkenıni de gittik 

//OrtalamaNotDegerlendir bu metoda verdik if sartlarını saglamak için

//o zaman degiskenı ortadan kaldırmak için metot içinde metot kullandık

//            OrtalamaNotDegerlendir(OrtalamaHesapla(not1, not2, not3));

//OrtalamaHesapla 3 degeri aldı decimal olarak deger gönderdi
//OrtalamaNotDegerlendir de decimal veri gönderiyor ikiside anlasmıs olacak


//*/