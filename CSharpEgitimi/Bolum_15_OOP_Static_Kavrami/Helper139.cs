//using System;

//namespace Bolum_15_OOP_Static_Kavrami
//{
//    public static class Helper139
//    {
//        public static void emailGonder(string aliciEmailAdres, string konu, string icerik)
//        {

//            // email gonderme işlemleri devam edecek

//            //Helper139 H1 = new Helper139();


//            Console.WriteLine("EMail gönderim işlemi başarılı.");

//        }


//        //public void Test()
//        //{

//        //}

//        //public int staticOlmayanField;
//        //public int staticOlmayanProp { get; set; }


//        //public Helper139()
//        //{

//        //}

//        static Helper139()
//        {
//            Console.WriteLine("Helper => Static class => static ctor");
//        }



//    }

//}


///*

//1. not bitiş

//2. not baslangıc

//video 138 den aldık bilgileri

//puclic class Helper139 du
//puclic statik class Helper139 yaptık
 
//static bir class olmus oldu 
//static class larda nesne ornegi alınamaz yanı new lenemez

//Program.cs e gidip bakalım oluyor mu 

//2. not bitiş
//3. not bitiş

//4. not baslangıc

//static olan class lar örneklenemez

//            //Helper139 H1 = new Helper139();

//içlerinde static olan metotlar barınabilir dedik
//sttatic olmayan metot barınabilir mi


//        public void Test()
//        {

//        }

//hata veriyor static class içinde static olmayan bir metot yazamazsın
//zaten nesne ornegini alamıyorsun yazsan da erişemezsin
//standart metotlar nesne ornegi alındıktan sonra erişilen metotlar

//içlerinde static olmayan field lar property ler de tanımlayamazsın

//        public int staticOlmayanField;
//        public int staticOlmayanProp { get; set; }

//yapıcı metotlar nasıl işliyor
//nesnemizi ornekledıgımız de calısan metot
//ctor tab tab

//static class lar cagrıldıgında arka tarafta ne gibi işlemler oluyor bundan bahsedelim

//static class larda yapıcı metotlar bulunur

//ama static class lar da yapıcı metotlar private olarak gecer

//private ister yaz ister yazma default olarak private olarak geçer

//ama static yazmak zorundasın

//boyle yazarsan hata alırsın

//        public Helper139()
//        {
            
//        }

//böyle yazman lazım

//        private static Helper139()
//        {
            
//        }

//        static Helper139()
//        {
            
//        }


//public ve static ctor arasındaki fark

//public olan standart yapıcı metot her nesne ornegi alındıgında uygulama
//standart yapıcı metotu calıstırır

//ne zaman new Helper desek yapıcı metot calısıyor static degilse

//ama

//static yapıcı metotlar uygulama boyunca bir kere calısıyor

//ilk cagrıldıgında calısırlar ve uygulama boyunca ne kadar cagırırsan
//cagır bir daha calısmazlar

//        static Helper139()
//        {
//            Console.WriteLine("Helper => Static class => static ctor");
//        }

//bu yazıyı bir kere görmek istiyorum 

//program.cs e donelim

//4. not bitiş




 
//*/