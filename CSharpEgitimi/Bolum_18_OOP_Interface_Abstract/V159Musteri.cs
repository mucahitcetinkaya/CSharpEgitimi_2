
//using System;

//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public class V159Musteri : V159temelSinif
//    {
//        public int musteriID { get; set; }

//        public V159Musteri()
//        {
//            musteriID = 1;
//        }

//        public override void testAbstract()
//        {
//            //throw new System.NotImplementedException();

//            //base.testAbstract();

//            Console.WriteLine("musteri içindeki testAbstract");
//        }
//    }
//}



///*

//2. not bitiş temelsınıftan geldik

//3. not baslangıc

//V159Musteri hata veriyor

//'V159Musteri' does not implement inherited abstract member 'V159temelSinif.testAbstract()'

//does not implement diyo yani bir şeyi burada acmadın diyor hata veriyor

//temelsınıf içindeki testAbstract metotunu bende kullanmadın diyor 

//zorundayım kullan bunu diyor 

//V159Musteri nin uzerıne gelince implement yazar ona basınca gereklileri burada kullanır

//oncesi


//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public class V159Musteri : V159temelSinif
//    {
//        public int musteriID { get; set; }

//        public V159Musteri()
//        {
//            musteriID = 1;
//        }


//    }
//}

//sonrası


//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public class V159Musteri : V159temelSinif
//    {
//        public int musteriID { get; set; }

//        public V159Musteri()
//        {
//            musteriID = 1;
//        }

//        public override void testAbstract()
//        {
//            throw new System.NotImplementedException();
//        }
//    }
//}


//public override olarak geliyor oranın body sini bana getiriyor 

//virtual olarak işaretlendiğin de override ediyorduk birde bu metotun base i oluyor du 

//            throw new System.NotImplementedException(); bunun yerine base. olarak base.testAbstract i cagıralım


// public override void testAbstract()
//        {
//            //throw new System.NotImplementedException();

//            base.testAbstract();
//        }

//testAbstract(); metotunun içi yok abstract cunku içeride virtual olmasına gerek yok abstract kalıtan bunun body sini kendisi yazacak

//son hali 

//public override void testAbstract()
//        {
//            //throw new System.NotImplementedException();

//            //base.testAbstract();

//            Console.WriteLine("musteri içindeki testAbstract");
//        }

//program.cs e gidelim

//3. not bitiş


// */
