//using System;

//namespace Bolum_15_OOP_Static_Kavrami
//{
//    public class Personel140
//    {
//        public static string domainAdres;
//        public string Isim { get; set; }
//        public string SoyIsim { get; set; }

//        private string _emailAdres;
//        public string EmailAdres
//        {
//            get
//            {
//                return this._emailAdres;
//            }

//            set
//            {
//                this._emailAdres = value.ToLower() + "@" + Personel140.domainAdres;
//            }
//        }

//        public int Cinsiyet { get; set; }

//        public Personel140()
//        {
//            Console.WriteLine("Her örneklemede calısan metot");
//        }

//        static Personel140()
//        {
//            domainAdres = "firmam.com";
//        }


//    }
//}




///*
 
//1. not bitiş

//2. not başlangıc

//notları Personel139 dan aldık 

//bir tane yapıcı metot yazacagız normal metot oldugu için her ornekleme de calısacak bu

//bir tane de static yapıcı metot tanımlayalım

//buna da domain adresini atama yapalım
 
//ilk calısmada standart ve statik yapıcı metotlar calısacak 
//2. örnekleme de standar olan calısacak ama statik olan calısmayacak

//Program.cs e gidelim

//2. not bitiş
 
 
 
 
//*/