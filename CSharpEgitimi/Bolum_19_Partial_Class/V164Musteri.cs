
//using System;

//namespace Bolum_19_Partial_Class
//{
//    public class V164Musteri
//    {

//        #region Fields

//        public int id { get; set; }
//        public string isim { get; set; }
//        public string soyisim { get; set; }
//        public string email { get; set; }

//        #endregion

//        #region metot

//        public int yeniKayit(V164Musteri m)
//        {
//            Console.WriteLine("musteri yeniKayit");
//            return 1;
//        }

//        public int kayitGuncelle(V164Musteri m)
//        {
//            Console.WriteLine("musteri kayitGuncelle");
//            return 1;
//        }

//        public int kayitSil(int id)
//        {
//            Console.WriteLine("musteri kayitSil");
//            return 1;
//        }

//        #endregion
//    }
//}

///*
 
//1. not bitiş program.cs den geldik

//2. not baslangıc

//field ve metotları yazdık 

//son durum 


//using System;

//namespace Bolum_19_Partial_Class
//{
//    public class V164Musteri
//    {
//        public int id { get; set; }
//        public string isim { get; set; }
//        public string soyisim { get; set; }
//        public string email { get; set; }

//        public int yeniKayit(V164Musteri m)
//        {
//            Console.WriteLine("musteri yeniKayit");
//            return 1;
//        }

//        public int kayitGuncelle(V164Musteri m)
//        {
//            Console.WriteLine("musteri kayitGuncelle");
//            return 1;
//        }

//        public int kayitSil(int id)
//        {
//            Console.WriteLine("musteri kayitSil");
//            return 1;
//        }

//    }
//}


//program.cs e gidelim

//2. not bitiş

//3. not bitiş program.cs den geldik

//4. not baslangıc

//musteride olusturduklarımızı program.cs de kullandık 
//şöyle düşünün mesela örnek olarak diyelim ki 
//kalıtım kullandık 
//get ve setleri ayırdık 
//bir çok işlem yaptıgımızı düşünün

//burası bir kod yıgını haline gelecek 

//region işlemleri bizi kurtabilir mesela 

//ilk durum

//using System;

//namespace Bolum_19_Partial_Class
//{
//    public class V164Musteri
//    {
//        public int id { get; set; }
//        public string isim { get; set; }
//        public string soyisim { get; set; }
//        public string email { get; set; }

//        public int yeniKayit(V164Musteri m)
//        {
//            Console.WriteLine("musteri yeniKayit");
//            return 1;
//        }

//        public int kayitGuncelle(V164Musteri m)
//        {
//            Console.WriteLine("musteri kayitGuncelle");
//            return 1;
//        }

//        public int kayitSil(int id)
//        {
//            Console.WriteLine("musteri kayitSil");
//            return 1;
//        }

//    }
//}

//region sonrası


//using System;

//namespace Bolum_19_Partial_Class
//{
//    public class V164Musteri
//    {

//        #region Fields

//        public int id { get; set; }
//        public string isim { get; set; }
//        public string soyisim { get; set; }
//        public string email { get; set; }

//        #endregion

//        #region metot

//        public int yeniKayit(V164Musteri m)
//        {
//            Console.WriteLine("musteri yeniKayit");
//            return 1;
//        }

//        public int kayitGuncelle(V164Musteri m)
//        {
//            Console.WriteLine("musteri kayitGuncelle");
//            return 1;
//        }

//        public int kayitSil(int id)
//        {
//            Console.WriteLine("musteri kayitSil");
//            return 1;
//        }

//        #endregion
//    }
//}

//böyle region lar her zaman bizim işimizi görmez disagne pattern ler konusunda daha net anlayacaksınız

//bazı class içindeki field ları ve metotları fiziksel olarak da bölmemiz gerekiyor 

//mesela V164Musteri.cs adında bir dosya var fiziksel bir dosya bu ben bu cs dosyasını cogaltmak ve musteri nesnesini parcalamak istiyorum 

//işlemlere baslayalım

//program.cs de gidelim
 
//4. not bitiş

//*/