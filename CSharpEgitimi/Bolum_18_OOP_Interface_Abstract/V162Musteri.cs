
//using System;

//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public class V162Musteri : IV162Musteri
//    {
//        int _id;
//        string _isim;
//        string _soyisim;

//        public int Id 
//        {
//            get { return _id; }
//            set { _id = value; }
//        }
//        public string isim
//        {
//            get { return _isim; }
//            set { _isim = value; }
//        }
//        public string soyisim
//        {
//            get { return _soyisim; }
//            set { _soyisim = value; }
//        }

//        public int kayitDuzenle(int id, string isim, string soyisim)
//        {
//            Console.WriteLine("kayıt kayitDuzenle");
//            return 1;
//        }

//        public int kayitSil(int id)
//        {
//            Console.WriteLine("kayıt kayitSil");
//            return 1;
//        }

//        public int yeniKayit(string isim, string soyisim)
//        {
//            Console.WriteLine("kayıt yeniKayit");
//            return 1;
//        }
//    }
//}

///*
 
//2. not bitiş IMusteri den geldik

//3. not baslangıc

//ilk durum

//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public class V162Musteri
//    {


//    }
//}
 
//IMusteri i miras verince hata veriyor 

//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public class V162Musteri : IV162Musteri
//    {


//    }
//}
 
//'V162Musteri' does not implement interface member 'IV162Musteri.Id'
//'V162Musteri' does not implement interface member 'IV162Musteri.isim'
//'V162Musteri' does not implement interface member 'IV162Musteri.soyisim'
//'V162Musteri' does not implement interface member 'IV162Musteri.yeniKayit(string, string)'
//'V162Musteri' does not implement interface member 'IV162Musteri.kayitDuzenle(int, string, string)'
//'V162Musteri' does not implement interface member 'IV162Musteri.kayitSil(int)'

//sen interface den kalıtım yaptın ben onun içinde tanım görüyorum bu tanımların bende olması lazım diyor implement et aktar diyor diyor 

//IV162Musteri de hata veriyor kızıyor üstüne okla gelince implement interface e basınca otomatik aktarır 

//son durum


//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public class V162Musteri : IV162Musteri
//    {
//        public int Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
//        public string isim { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
//        public string soyisim { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

//        public int kayitDuzenle(int id, string isim, string soyisim)
//        {
//            throw new System.NotImplementedException();
//        }

//        public int kayitSil(int id)
//        {
//            throw new System.NotImplementedException();
//        }

//        public int yeniKayit(string isim, string soyisim)
//        {
//            throw new System.NotImplementedException();
//        }
//    }
//}
 
//id isim soyisim bunlar problar bunlar bir degiskene ihtiyac duyarlar get ve set blokları ondan böyle uzun uzun geldi 
//field ekleyelim ve problara verelim

//problar son durum


//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public class V162Musteri : IV162Musteri
//    {
//        int _id;
//        string _isim;
//        string _soyisim;

//        public int Id 
//        {
//            get { return _id; }
//            set { _id = value; }
//        }
//        public string isim
//        {
//            get { return _isim; }
//            set { _isim = value; }
//        }
//        public string soyisim
//        {
//            get { return _soyisim; }
//            set { _soyisim = value; }
//        }

//        public int kayitDuzenle(int id, string isim, string soyisim)
//        {
//            throw new System.NotImplementedException();
//        }

//        public int kayitSil(int id)
//        {
//            throw new System.NotImplementedException();
//        }

//        public int yeniKayit(string isim, string soyisim)
//        {
//            throw new System.NotImplementedException();
//        }
//    }
//}

//metotlar da IMusteri de imzaları vardı body leri yoktu body leri buraya geldi
//metotları guncelleyelim


//using System;

//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public class V162Musteri : IV162Musteri
//    {
//        int _id;
//        string _isim;
//        string _soyisim;

//        public int Id 
//        {
//            get { return _id; }
//            set { _id = value; }
//        }
//        public string isim
//        {
//            get { return _isim; }
//            set { _isim = value; }
//        }
//        public string soyisim
//        {
//            get { return _soyisim; }
//            set { _soyisim = value; }
//        }

//        public int kayitDuzenle(int id, string isim, string soyisim)
//        {
//            Console.WriteLine("kayıt kayitDuzenle");
//            return 1;
//        }

//        public int kayitSil(int id)
//        {
//            Console.WriteLine("kayıt kayitSil");
//            return 1;
//        }

//        public int yeniKayit(string isim, string soyisim)
//        {
//            Console.WriteLine("kayıt yeniKayit");
//            return 1;
//        }
//    }
//}

//su anlık sadece console yazdırdık sql i gorunce id isim soyisim degerlerine gore kayıt olustur duzenle sil standart yapmamız gereken işlemleri zaten yapacagız
//return 1 dememizin nedeni int döndürdük metotları ondan öylesine bir return yaptık hata vermesın diye

//gercek hayat olarak not

//bir program yazımına dahil oluyorsunuz ve ekipce class ları duzenliyorsunuz ve burada bir standarta oturması gerekiyor 
//bir interface paylaşımı yapılır ve ilgili interface i uzerimize aldıktan sonra zaten yazacagımız kodu direk burada gorebiliyor oluruz 
//gormus oldugumuz kodlar doldurduktan sonra ilgili sunucuya ekleriz kontrolü yapılır işlemlere devam edilir

//kendı basınıza uygulama yaptıgınız da geliştirdiginiz de bir zorunluluk degil olmazsa olmaz interface i bilmezsenız olmaz degil bu işi profesyonel bir şekilde bir firmada yapacaksanız 
//o zaman interface leri bilmek zorundasınız 

//3. not bitiş program.cs e gidelim dersi bitirelim
 
 
//*/