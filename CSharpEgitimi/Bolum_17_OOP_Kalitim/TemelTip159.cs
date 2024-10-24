
//using System;

//namespace Bolum_17_OOP_Kalitim
//{
//    public class TemelTip159
//    {
//        public TemelTip159()
//        {
//            Console.WriteLine("TemelTip155 nesnesinin yapıcı metodu çalıştı.");
//            IdAtamaIslemi();
//        }

//        private void IdAtamaIslemi()
//        {
//            Random rnd = new Random();
//            this.Id = rnd.Next(1000, 9000);
//        }

//        public int Id { get; set; }
//        public string ReferansKod { get; set; }
//        public string TcKimlikNumarasi { get; set; }
//        public string Isim { get; set; }
//        public string SoyIsim { get; set; }
//        public int Cinsiyet { get; set; }
//        public DateTime KayitTarihi { get; set; }
//        public int KayitKullanici { get; set; }
//        public DateTime GuncellemeTarihi { get; set; }
//        public int GuncellemeKullanici { get; set; }
//        public bool Silindi { get; set; }

//        public void TemelTipMetot1()
//        {
//            Console.WriteLine("Temel Tip => Metot 1");
//            TemelTipMetot2();
//        }

//        protected void TemelTipMetot2() 
//        {
//            Console.WriteLine("Protected metot çalıştı.");
//        }

//    }
//}


///*
 
//1. not bitiş

//2. not baslangıc

//protected bir metot olusturalım 

// protected void TemelTipMetot2() 
//        {
//            Console.WriteLine("Protected metot çalıştı.");
//        }
 
 
//Program.cs e gidelim

//2. not bitiş
//3. not bitiş

//4. not baslangıc

//            TemelTipMetot2(); yi 
//            TemelTipMetot1(); in içinde cagıralım

//public void TemelTipMetot1()
//        {
//            Console.WriteLine("Temel Tip => Metot 1");
//            TemelTipMetot2();
//        }

//calısıyor sorun yok private gibi davranıyor

//2. olarak protected kendisini kalıtmıs olan nesneye public olarak gözükebiliyordu

//Benim TemelTipim den türemiş nesnem örnek olarak Ogrenci nesnesi 

//Ogrenci159 a gidelim

//4. not bitiş


 
//*/