
//using System.Collections;

//namespace Bolum_17_OOP_Kalitim
//{
//    public static class SanalDataBase
//    {

//        //public static ArrayList db;

//        //private static ArrayList db;
        
//        private static ArrayList db = new ArrayList();

//        public static void YeniUrunEkle(BaseClass160 data)
//        {
//            if (data != null && !string.IsNullOrEmpty(data.Barkod))
//            {
//                db.Add(data);
//            }
//        }

//        public static bool DbBarkodKontrol(string barkod)
//        {

//            bool kontrolIslemi = false;

//            if(db != null && db.Count > 0)
//            {
//                for (int i = 0; i < db.Count; i++)
//                {
//                    BaseClass160 bc = (BaseClass160)db[i];
//                    if (bc.Barkod == barkod)
//                    {
//                        kontrolIslemi = true;
//                    }
//                }
//            }
//            return kontrolIslemi;
//        }


//    }
//}



///*
 

//12. not bitiş

//13. not başlangıc
 
//        public static ArrayList db;

//böyle yaparak her yerden ulasılabilen bir arraylis yaptık

//dısarıdan erişilsin ama set edilsin istemiyorum bunun için private yapmamız lazım ve bir metot ile önce metota ulasırız sonrada ordan db e gideriz
        
//private static ArrayList db;
 
 
//bir tane de metot olusturduk ve bunun içinde yapacagımız kontrol 
//public dısarıdan erişilebilir olacak
//static . ile nesne üzerinden erişilebilir olacak
//void geriye herhangi bir şey dönmeyeceğim
//ismi de YeniUrunEkle olacak
//YeniUrunEkle metodu sadece televizyon bilgisayar gibi ürün nesnesinden yada baseclass dan türemiş nesneleri alsın istiyorsam 
//parametre olarak baseclass dersem bütün mimariyi kabul etmesini sağlarım ürün dersem üründen sonra türeyenleri kabul etmesini sağlarım
//parametre olarak da (BaseClass160 data) alsın

//son durum

//public static void YeniUrunEkle(BaseClass160 data)
//        {

//        }




//eger db içerisinde benim eklemek istediğim barkod var ise ben arraylist in içerisine bunu eklemeyeceğim

//bunuda bir encapsulation ile yapmak istiyorum 

//barkodu emcapsulation da datamı filtreleyeceğim 

//datanın nul olup olmadıgını kontrol edelim once ve datanın içerisindeli barkod alanı null veya bos mu diye kontrol edelim

//sonrada db.Add(data); ile db ye datayı ekleyelim.
 
//  if (data != null && !string.IsNullOrEmpty(data.Barkod))
//            {
//                db.Add(data);
//            }
 
// program.cs e gidelim

//13. not bitiş

//14. not bitiş

//son durum


//using System.Collections;

//namespace Bolum_17_OOP_Kalitim
//{
//    public static class SanalDataBase
//    {

//        //public static ArrayList db;
//        private static ArrayList db;

//        public static void YeniUrunEkle(BaseClass160 data)
//        {
//            if (data != null && !string.IsNullOrEmpty(data.Barkod))
//            {
//                db.Add(data);
//            }
//        }


//    }
//}


//15. not başlangıc

//son durum 


//using System.Collections;

//namespace Bolum_17_OOP_Kalitim
//{
//    public static class SanalDataBase
//    {

//        //public static ArrayList db;

//        //private static ArrayList db;
        
//        private static ArrayList db = new ArrayList();

//        public static void YeniUrunEkle(BaseClass160 data)
//        {
//            if (data != null && !string.IsNullOrEmpty(data.Barkod))
//            {
//                db.Add(data);
//            }
//        }


//    }
//}

//arraylist i new arraylist yaptık sadece
 
//program.cs e gidelim

//15. not bitiş

//18. not bitiş baseclass dan geldik

//19. not başlanıgıç

//bir metot olusturmamız lazım guncelleme olmadan ki kodlar


//using System.Collections;

//namespace Bolum_17_OOP_Kalitim
//{
//    public static class SanalDataBase
//    {

//        //public static ArrayList db;

//        //private static ArrayList db;
        
//        private static ArrayList db = new ArrayList();

//        public static void YeniUrunEkle(BaseClass160 data)
//        {
//            if (data != null && !string.IsNullOrEmpty(data.Barkod))
//            {
//                db.Add(data);
//            }
//        }


//    }
//}

//--------------------------------

//güncelleme sonrası

//public static bool DbBarkodKontrol(string barkod)
//        {
//            if(db != null && db.Count > 0)
//            {
//                for (int i = 0; i < db.Count; i++)
//                {
//                    if (db[i].)
//                    {

//                    }
//                }
//            }
//        }

//yukarıdaki gibi yazınca i. yazınca içine ulasamadık cunku birisi object arraylist object alır digeri baseclass tipleri tutmadı
//bundana dolayı once tiplerini eşitlemek lazım unboxing yapacagız


//public static bool DbBarkodKontrol(string barkod)
//        {

//            bool kontrolIslemi = false;

//            if(db != null && db.Count > 0)
//            {
//                for (int i = 0; i < db.Count; i++)
//                {
//                    BaseClass160 bc = (BaseClass160)db[i];
//                    if (bc.Barkod == barkod)
//                    {
//                        kontrolIslemi = true;
//                    }
//                }
//            }
//            return kontrolIslemi;
//        }

//baseclass a gidelim

//19. not bitiş

 
//*/