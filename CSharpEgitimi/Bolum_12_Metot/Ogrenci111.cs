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
//            decimal ortalama = (privateNot1 + privateNot2 + privateNot3) / 3;
//            return ortalama;
//        }


//    }

//}

///*

//OgrenciPuanHesaplama içindeki not hesap kısmını metot olarak alacagız
//metotun ustune gelirsen eger
//kup işareti metot oldugunu
//kilit işareti private oldugunu belirtiyor

//verilen degisken isimleri aynı olmak zorunda degil
//not1 i alacak privateNot1 e atacak mesela


//*/