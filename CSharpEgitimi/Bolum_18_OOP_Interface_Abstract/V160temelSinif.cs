
//using System;

//namespace Bolum_18_OOP_Interface_Abstract
//{
//    //public sealed abstract class V160temelSinif
//    public abstract class V160temelSinif
//    {

//        public DateTime kayitTarih { get; set; }
//        public DateTime guncellemeTarih { get; set; }

//        public V160temelSinif()
//        {
//            kayitTarih = DateTime.Now;
//            guncellemeTarih = DateTime.Now;
//        }

//        public void test()
//        {
//            Console.WriteLine("temelsınıfiçindekitestmetoducalıstı");
//        }

//        //public abstract void testAbstract()
//        //{

//        //}

//        public abstract void testAbstract();

//        public static void testAbstract2()
//        {
//            Console.WriteLine("temelsınıfiçindekitestAbstract2metoducalıstı");
//        }



//    }
//}


///*
 
//3. not bitiş program.cs den geldik

//4. not baslangıc

//ilk hali
 

//using System;

//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public abstract class V160temelSinif
//    {

//        public DateTime kayitTarih { get; set; }
//        public DateTime guncellemeTarih { get; set; }

//        public V160temelSinif()
//        {
//            kayitTarih = DateTime.Now;
//            guncellemeTarih = DateTime.Now;
//        }

//        public void test()
//        {
//            Console.WriteLine("temelsınıfiçindekitestmetoducalıstı");
//        }

//        //public abstract void testAbstract()
//        //{

//        //}

//        public abstract void testAbstract();


//    }
//}

//temel sınıfı sealed yapalım

//sonraki hali
 
//    public selaed abstract class V160temelSinif
 
//V160temelSinif hata veriyor 

//'V160temelSinif': an abstract type cannot be sealed or static

//abstract veya static oldugundan sealed olmaz diyor 

//sımdı bız buna abstract dedık yani sablon dedık sablonsa eger bunun kalıtılması lazım 
//sealed diyince de kalıtılmasın demıs oluyosun 
//ozaman ikisinden birisini sec diyor bize
//ikisi birden olmaz mantıga ters 

//sealed keyword unu kaldıralım 

//son durum 
//    public abstract class V160temelSinif

//konu bitti genel notlar için program.cs den gidelim

//4. not bitiş 


// */