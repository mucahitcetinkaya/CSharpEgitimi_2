
//using System;

//namespace Bolum_17_OOP_Kalitim
//{
//    public class Urun160 : BaseClass160
//    {

//        private decimal _alisFiyat;
//        private decimal _satisFiyat;
//        private decimal _kampanyaFiyat;

//        public string Marka { get; set; }
//        public string Model { get; set; }

//        public decimal AlisFiyat
//        {
//            get
//            {
//                return _alisFiyat;
//            }
//            set
//            {
//                if (value <= 0)
//                {
//                    Console.WriteLine("Alış Fiyatı sıfırdan küçük veya eşit olamaz.");
//                }
//                else
//                {
//                    _alisFiyat = value;
//                }

//            }
//        }
//        public decimal SatisFiyat
//        {
//            get
//            {
//                return _satisFiyat;
//            }
//            set
//            {
//                if (value < _alisFiyat)
//                {
//                    Console.WriteLine("Satış Fiyatı Alış Fiyatından küçük olamaz.");
//                }
//                else
//                {
//                    _satisFiyat = value;
//                }
//            }
//        }
//        public decimal KampanyaFiyat
//        {
//            get
//            {
//                return _kampanyaFiyat;
//            }
//            set
//            {
//                if (value <= 0)
//                {
//                    Console.WriteLine("Kampanya Fiyatı sıfırdan küçük veya eşit olamaz.");
//                }
//                else
//                {
//                    _kampanyaFiyat = value;
//                }
//            }
//        }


//    }
//}


///*
 
//2. not bitiş
 
//3. not baslangıc

//BaseClass dan miras alacak
 
//gerekli probları yazdık

//Marka kısmında bir kontrol olacak
//bir liste içerisinde marka kontrolu yapacagız
//belirtiğimiz markaların dısında bir ürün satamayacak
//buradan encapsulation dogru ilerliyoruz

//AlisFiyat 0 dan kucuk olmamalı
//SatisFiyat AlisFiyat dan kucuk olmamalı
//KampanyaFiyat 0 dan kucuk olamaz
 
//Televizyon ve bilgisayar adında class lar acalım

//3. not bitiş

//10. not bitiş

//11. not baslangıc

//---------------------------------------------------------
//2. İSTEK 
//ALIS FİYATI 0 DAN KUCUK OLAMAZ 
//KAMPANYA 0 DAN KUCUK OLAMAZ
//SATIS FİYAT ALIS FİYATTAN KUCUK OLAMAZ
//---------------------------------------------------------

//önceki hali 

//public class Urun160 : BaseClass160
//    {

//        public string Marka { get; set; }
//        public string Model { get; set; }

//        public decimal AlisFiyat { get; set; }
//        public decimal SatisFiyat { get; set; }
//        public decimal KampanyaFiyat { get; set; }


//    }

//buradaki kapsullemeyi yapmamız gerek

//önce hepsinin private field alanlarını olusturmamız lazım
//sonra problarda 
//get bloklarında sadece veriyi return edeceğiz
//set bloklarında istediklerimizi kodlayalım

//son durum
 
//public class Urun160 : BaseClass160
//    {

//        private decimal _alisFiyat;
//        private decimal _satisFiyat;
//        private decimal _kampanyaFiyat;

//        public string Marka { get; set; }
//        public string Model { get; set; }

//        public decimal AlisFiyat
//        {
//            get
//            {
//                return _alisFiyat;
//            }
//            set
//            {
//                if (value <= 0)
//                {
//                    Console.WriteLine("Alış Fiyatı sıfırdan küçük veya eşit olamaz.");
//                }
//                else
//                {
//                    _alisFiyat = value;
//                }

//            }
//        }
//        public decimal SatisFiyat
//        {
//            get
//            {
//                return _satisFiyat;
//            }
//            set
//            {
//                if (value < _alisFiyat)
//                {
//                    Console.WriteLine("Satış Fiyatı Alış Fiyatından küçük olamaz.");
//                }
//                else
//                {
//                    _satisFiyat = value;
//                }
//            }
//        }
//        public decimal KampanyaFiyat
//        {
//            get
//            {
//                return _kampanyaFiyat;
//            }
//            set
//            {
//                if (value <= 0)
//                {
//                    Console.WriteLine("Kampanya Fiyatı sıfırdan küçük veya eşit olamaz.");
//                }
//                else
//                {
//                    _kampanyaFiyat = value;
//                }
//            }
//        }


//    }

// program.cs e gidelim

//11. not bitiş

//*/