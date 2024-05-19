//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bolum_13_OOP_Siniflar
//{
//    // 2. not
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
//    }

//    // 1. not
//    //public class Musteri124
//    //{

//    //    public Musteri124()
//    //    {
//    //        TcKimlikNumarasi = "12345678910";
//    //    }

//    //    public string TcKimlikNumarasi { get; set; }
//    //    public string Isim { get; set; }
//    //    public string SoyIsim { get; set; }
//    //    public int Cinsiyet { get; set; }
//    //}
//}


///*

//1. not program.cs den geldik

//fieldları yazdık public olarak erişim belirleyicini yazdık
//field ları prop olarak kolay yazabilirsin

//şimdi asıl konumuz olan yapıcı metotlara girelim
//bunlar constructor olarak geçiyor
//kısa yolları ctor olarak geçer
//ctor yazıp tab tab yaptıgınız da yapıcı metotlar yazılır

//nesnelerimizi orneklerken içerisinde bulunan field ların
//bir deger alması gerekir
//bu deger alma zorunlulugu .net içerisinde 
//yapıcı metotlar ile saglanır
//eger biz bu yapıcı metotlara mudahale etmezsek
//arka tarafta calısırken kodumuz calısırken bu metotlar bizim için olusuyor
//bos bir şekilde duruyor
//class ın içindeki
//field ların veri tiplerine göre default olarak degerler veriyor
//field lar default degerlerını aldıktan sonra işlem yapabilir hale geçiyor
//ve dinlemeye baslıyor içerisine bir deger girecek mı işlem olacak mı diye

//sistem o class ı bizim kullanabilirliğimize acıyor

//işte biz tam bu noktada yapıcı metotlara mudahale edebilirsek
//sistemin default degerlerini degistirebiliriz

//ornek olarak sunu soyleyebiliriz

//TcKimlikNumarasi string oldugu için
//default degeri null dı 
//null olmasında 

//yapıcı metot içinde 
// public Musteri124()
//        {
//            TcKimlikNumarasi = "12345678910";
//        }

//olsun diyebiliriz

//program.cs e gidip uygulamayı calsıtırıp debug edelim
//1. not bitişi

//2. not baslangıc

//program.cs den geldık
//ctor lar overload ediliyor mu ona bakacagız
//parametreler ile aynı isimde ctor lar yazacagız

//farklı farklı ctor lar olusturduk 
//yani biz dedıkki burda
//dilersen bos bırak default degerler gelsin
//dilersen sadece tckimlikno ver
//dilersen tc ile isim
//dilersen tc isim soyisim ver

//yani ctor da da overload oluyor

//parametre ile field kısımlarını birleştirme yapıyosun burda
//field ile parametre olarak gelen yapıyosun
//program.cs e gidelim

//2. not bitiş

//3. not baslangıc

//parametreden ctor dan gerekli metoda geldi 
//string _tcKimlikNo, string _isim olanı kullandık ona dustu kod
//diger tarafdan veri yolladık _ olanlara geldi

//sonra _ olanları digerlerine ata dedik kodun içinde 
//atama yaptı diger tarafa gecti

//3. not bitiş

//*/