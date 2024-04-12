//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace D_13_OOP_Siniflar
//{
//    public class Musteri124
//    {

//        public Musteri124()
//        {
//            TcKimlikNumarasi = "12345678910";
//        }

//        public Musteri124(string _tcKimlikNo)
//        {
//            TcKimlikNumarasi = _tcKimlikNo;
//        }

//        public Musteri124(string _tcKimlikNo, string _isim)
//        {
//            TcKimlikNumarasi = _tcKimlikNo;
//            Isim = _isim;
//        }

//        public Musteri124(string _tcKimlikNo, string _isim, string _soyIsim)
//        {
//            TcKimlikNumarasi = _tcKimlikNo;
//            Isim = _isim;
//            SoyIsim = _soyIsim;
//        }

//        public string TcKimlikNumarasi { get; set; }
//        public string Isim { get; set; }
//        public string SoyIsim { get; set; }
//        public int Cinsiyet { get; set; }


//        public bool MusteriKontrol()
//        {
//            bool kontrol = MusteriKontrolDataBase(TcKimlikNumarasi);
//            return kontrol;
//        }

//        private bool MusteriKontrolDataBase(string tcKimlikNumarasi)
//        {
//            // database e gidilir müşterinin tckimlik numarasına göre daha önce kayıt 
//            // edilip edilmediği bilgisi sorgulanır
//            return true;
//        }

//        internal bool MusteriKontrolDataBase1(string tcKimlikNumarasi)
//        {
//            // database e gidilir müşterinin tckimlik numarasına göre daha önce kayıt 
//            // edilip edilmediği bilgisi sorgulanır
//            return true;
//        }

//    }
//}




///*


//ilk ctor bos da olabilir direk hiç bir parametre verilmediyse default ayarlarını getir
//parametre verilmediği halde ilk kesin olarak bunu bu yap gibi bir sey de yazabilirsin

//123. video da anlatıldı zaten
//parametre ile de devam edebilirsin

//1. not baslangıc 
 
//program.cs den geldik 

//metot olusturacagız
//public bir metot olusturacagız public oldugu için nesneyi new leyen herkes buna erişebilecek

//geri donusu bool olacak true veya false donecek

//baska bir metot daha yapacagız oda private olacak ve public olanın içinde parametre ile cagıracagız


//        public bool MusteriKontrol()
//        {
//            bool kontrol = MusteriKontrolDataBase(TcKimlikNumarasi);
//            return kontrol;
//        }

//        private bool MusteriKontrolDataBase(string tcKimlikNumarasi)
//        {
//            // database e gidilir müşterinin tckimlik numarasına göre daha önce kayıt 
//            // edilip edilmediği bilgisi sorgulanır
//            return true;
//        }

//bu iki metodu acıklayalım 

//program.cs de M1.MusteriKontrol yazıp buraya breakpoint ekleyip debug yapalım

//anlatımını orda yazacagım

//1. not bitişi




 
//*/