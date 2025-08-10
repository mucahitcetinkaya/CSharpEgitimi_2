
//using System;

//namespace Bolum_19_Partial_Class
//{
//    public partial class V165Ogrenci
//    {

//        public int yeniKayit(V165Ogrenci m)
//        {
//            Console.WriteLine("musteri yeniKayit");
//            return 1;
//        }

//        public int kayitGuncelle(V165Ogrenci m)
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

///*

//eski notlar

//benim şimdi son durumda V164OgrenciField ve V164OgrenciMetot adında 2 farklı cs dosyam var 
//bunların içinde girince ikisininde isimleri V164Ogrenci yazıyor

//hataya gelince 2 tane V164Ogrenci var diyor ben bunları tek bir class olarak bunları algılatmam lazım 

//field larına gidince field larını 
//metotlarına gidince metotlarını görebiliyoruz 

//2 V164Ogrenci class ını da tek bir V164Ogrenci gibi orneklemek kullanmak istiyorum

//bir sonraki dersimiz de tek bir tanım ile bu işlemi yapacagız

//program.cs e gidelim

//8. not bitis

//------------------------------------

//1. not bitiş program.cs den geldik

//2. not baslangıc

//hatayı çözmenin yolu bu class ların bir partial olmasını belirtmek gerekiyor
//publicten sonra partial eklememiz lazım

//önceki


//using System;

//namespace Bolum_19_Partial_Class
//{
//    public class V165Ogrenci
//    {

//        public int yeniKayit(V165Ogrenci m)
//        {
//            Console.WriteLine("musteri yeniKayit");
//            return 1;
//        }

//        public int kayitGuncelle(V165Ogrenci m)
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

//sonraki

//using System;

//namespace Bolum_19_Partial_Class
//{
//    public partial class V165Ogrenci
//    {

//        public int yeniKayit(V165Ogrenci m)
//        {
//            Console.WriteLine("musteri yeniKayit");
//            return 1;
//        }

//        public int kayitGuncelle(V165Ogrenci m)
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


//    public partial class V165Ogrenci

//V165OgrenciMetot.cs dosyası bir partial class dır yani V165Ogrenci nin bir parcasıdır dedik

//V165OgrenciField.cs e gidelim

//2. not bitis


//*/