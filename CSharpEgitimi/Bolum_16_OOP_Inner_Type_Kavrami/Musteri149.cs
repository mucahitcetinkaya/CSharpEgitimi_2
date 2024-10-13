//using System;

//namespace Bolum_16_OOP_Inner_Type_Kavrami
//{
//    public class Musteri149
//    {

//        #region Tekil olarak kullanılan field lar

//        public int musteriId { get; set; }
//        public string isim { get; set; }
//        public string soyIsim { get; set; }
//        public DateTime olusturmaTarihi { get; set; }
//        public int kullaniciId { get; set; }
//        public string tcKimlikNumarasi { get; set; }

//        #endregion

//        #region Inner Type Gerektiren Field lar

//        public MusteriAdres149[] musteriAdres149Liste;
//        public MusteriIletisimBilgisi149[] musteriIletisimBilgisi149Liste;
//        public MusteriSiparisBilgisi149[] musteriSiparisBilgisi149Liste;

//        #endregion

//        public Musteri149()
//        {
//            musteriAdres149Liste = new MusteriAdres149[5];
//            musteriIletisimBilgisi149Liste = new MusteriIletisimBilgisi149[3];
//            musteriSiparisBilgisi149Liste = new MusteriSiparisBilgisi149[10];
//        }

//    }
//}