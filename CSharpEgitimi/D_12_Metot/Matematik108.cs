//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace D_12_Metot
//{
//    public class Matematik108
//    {

//        public decimal ToplamaIslemi(decimal sayi1, decimal sayi2)
//        {
//            decimal sonuc = sayi1 + sayi2;
//            return sonuc;
//        }

//        public decimal CikartmaIslemi(decimal sayi1, decimal sayi2)
//        {
//            decimal sonuc = sayi1 - sayi2;
//            return sonuc;
//        }

//        public decimal BolmeIsleme(decimal sayi1, decimal sayi2)
//        {
//            decimal sonuc = sayi1 / sayi2;
//            return sonuc;
//        }

//        public decimal CarpmaIslemi(decimal sayi1, decimal sayi2)
//        {
//            decimal sonuc = sayi1 * sayi2;
//            return sonuc;
//        }

//        public void MenuHazirla()
//        {
//            Console.WriteLine("*** Menü ***");
//            Console.WriteLine("1- Toplama");
//            Console.WriteLine("2- Çıkartma");
//            Console.WriteLine("3- Bölme");
//            Console.WriteLine("4- Çarpma");
//            Console.Write("Lütfen değer seçiniz : ");
//        }

//        public void SonucEkranaYaz(decimal kullaniciSayi1, decimal kullaniciSayi2, decimal sonuc, string operators)
//        {
//            Console.WriteLine("{0} {1} {2} = {3}", kullaniciSayi1, operators, kullaniciSayi2, sonuc);
//        }



//    }

//}


///*
 
//program.cs den geldik
//public yaptık dısarıdan erişebilmek için

//Topla metodunu tasarlayalım
//dısarıdan erişilecek public olacak
//geriye deger dönecek mi evet decimal deger dönsün
//adı ne olacak nasıl cagıralım ToplamaIslemi
//parametre alacak mı evet decimal sayi1 decimal sayi2
//peki içeride ne yapacak gelen 2 degeri toplayıp geriye gönderecek
//bunlar dahilinde o zaman 
//        public decimal ToplamaIslemi(decimal sayi1, decimal sayi2)
//        {
//            decimal sonuc = sayi1 + sayi2;
//            return sonuc;
//        }
//bunun gibi oldu
//decimal oldugu için geriye deger dönüyor ondan dolayı return kullanıyoruz
//bir işlem yapıp bunu geriye dönüyor

//geriye deger dönmesi demek metot içinde işlemler yapıyor elde edilen bir sonuc result var
//bunu alıp gönderip kullanıyoruz return ediyoruz

//Cıkartma metodunu tasarlayalım
//Bolme metodunu tasarlayalım
//Çarpma metodunu tasarlayalım
//Menu içinde bir metot tasarlayalım

//Program.cs e geri dönelim

//Program.cs den geldik
//ekrana yazdırmak için metot hazırlayalım
//4 tane parametre isteyecek kullaniciSayi1 kullaniciSayi2 sonuc operators
//içerisinde string bir formatla bunu ekrana yazacak geriye bir deger dönmeyecek

//*/