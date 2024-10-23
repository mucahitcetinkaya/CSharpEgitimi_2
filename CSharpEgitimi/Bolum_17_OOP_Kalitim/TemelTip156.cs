
//using System;

//namespace Bolum_17_OOP_Kalitim
//{
//    public class TemelTip156
//    {
//        public TemelTip156()
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
//        }

//    }
//}