//using System;

//namespace Bolum_16_OOP_Inner_Type_Kavrami
//{
//    public class Musteri148
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

//        public MusteriAdres148[] musteriAdres148Liste;
//        public MusteriIletisimBilgisi148[] musteriIletisimBilgisi148Liste;
//        public MusteriSiparisBilgisi148[] musteriSiparisBilgisi148Liste;

//        #endregion

//        public Musteri148()
//        {
//            musteriAdres148Liste = new MusteriAdres148[5];
//            musteriIletisimBilgisi148Liste = new MusteriIletisimBilgisi148[3];
//            musteriSiparisBilgisi148Liste = new MusteriSiparisBilgisi148[10];
//        }

//    }
//}