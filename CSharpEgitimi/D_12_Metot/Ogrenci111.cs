//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace D_12_Metot
//{
//    public class Ogrenci111
//    {
//        public void OgrenciPuanHesaplama(string ad, string soyAd, decimal not1, decimal not2, decimal not3)
//        {
//            Console.WriteLine("Öğrencinin bilgileri aşağıdaki gibidir...");
//            Console.WriteLine("Ad Soyad : {0} {1}", ad, soyAd);
//            //decimal ortalama = (not1 + not2 + not3) / 3; 
//            decimal ortalama = OrtalamaHesapla(not1, not2, not3);
//            if (ortalama > 45)
//            {
//                Console.WriteLine("Ortalama değeriniz : {0} - Geçtiniz!", ortalama);
//            }
//            else
//            {
//                Console.WriteLine("Ortalama değeriniz : {0} - Kaldınız!", ortalama);
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
 
//burda bir return kelimesi kullandık bunu uygulama uzerınden anlatalım

//            decimal ortalama = OrtalamaHesapla(not1, not2, not3);

//burda bir metot cagırdık ve degerlerimi girdik
//uygulama bizim girdiğimiz degerleri ortalama hesapla metoduna gönderdi
//deger karsıtları olarakta 
//        private decimal OrtalamaHesapla(decimal privateNot1, decimal privateNot2, decimal privateNot3)

//daha sonra private metoda girdi OrtalamaHesapla içine girdi
//bir işlemden geçirdi
//sonra ortalama degiskenı uzerınde saklandı
//sonrada ortalama degiskeni return ile metodun dısarısına gönderildi
//metodun geri dönus tipi decimal 
//yani return da decimal olarak dönüyor
//döndugu kısımda cagıran nokta 
//yani public metotda olan kısım OgrenciPuanHesaplama
//            decimal ortalama = OrtalamaHesapla(not1, not2, not3);
//burda da ortalama degıskenıne atılmıs oldu return oldu yanı

//peki burda kodu azaltmak istersek ne yapmamız lazım
//            decimal ortalama = (privateNot1 + privateNot2 + privateNot3) / 3;
//burda bir deger saklanıyor ama işlem yapılmıyor gereksiz bir veri tipi olusturma var
//bunun yerıne aynısını return ile direk yollayabiliriz.
 
//            return (privateNot1 + privateNot2 + privateNot3) / 3;

//zaten metodun donus tipi decimal ordan anlasılıyor ne oldugu

//işlem hesaplanacak ordan yapılan deger decimal olarak cagrılan yere return edilecek

//not olarak
//uygulama içerisinde ortalama degiskenı uzerınde herhangi bir işlem yapılacak olsaydı eger 
//boyle de yazabilirdik ama herhangi bir işlem yapmıyoruz
//return da aynı işlemı yapıyor ortalama degiskenını baska bir yerde kullanmıyoruz
//bundan dolayı böyle yaptık

//*/