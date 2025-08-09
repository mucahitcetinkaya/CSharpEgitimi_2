//using System;

//namespace Bolum_18_OOP_Interface_Abstract
//{
//    public abstract class V159temelSinif
//    {

//        public DateTime kayitTarih { get; set; }
//        public DateTime guncellemeTarih { get; set; }

//        public V159temelSinif()
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

///*
 
// V158 notları 
//---------------------------------------------------------------------------------------------------------------

//10. not baslangıc

//abstract metot olusturalım

// public abstract void testAbstract()
//        {

//        }

//böyle yazdık ve hata verdi diger dersimiz de
//abstract class tanıdık abstract metot nedir 
//neden hata verdi
//hata almayacagımız sekılde yazdıgımız da bizim basımıza ne gelir bunları inceleyecegiz 
//bu şablon tip bir şey şablon ise içeriği olmayabilir ufak bir ip ucu vereyim 

//10. not bitiş diger derse geç

//V158 notları 
//---------------------------------------------------------------------------------------------------------------
 
// */

///*

//1. not bitiş program.cs den geldik

//2. not baslangıc

//v158 temelsınıf içinde en son metot olusturduk ordan devam ediyoruz 159 için

//abstract işaretli metotların body leri olmaz 
//neden olmaz
//biz şunu söylüyoruz abstract yaparak 
//şablon sınıf yapacagım abstract şablona denk geliyor bu sablon sınıf içinde bazı metotlarında şablon olarak durmasını istiyorum
//ve bu sınıfı kalıtan diger nesne benım içeride şablon olarak hazırlamıs oldugum metotları kullanmak zorunda kalsın 

//ana temelim benım nesne ornegi alınamayan bir baska programcı tarafından erişilebiliyor olsa bile new ile orneklenemeyen içerisinde benım hazırlamıs oldugum metotları ve field ları 
//karsı tarafa verdıgım zaman kullanmasını zorunlu kıldıgım bir şablon olusturmak dolayısıyla test abstract metotu zaten sablon bir metot olacagı ıcın zaten bunu cagıran nesne bunu ezmek zorunda kalacagı için
//metotun body sıne ıhtıyac yoktur 

//sadece metot imzası vardır.

//ilk hali hata veren kısmı 

// public abstract void testAbstract()
//        {

//        }

//sonraki hali

// public abstract void testAbstract();

//metot imzası nedir acıklamasıdır yani metotu kullanacak kişiye bilgi veriyoruz

//public herkese acık
//void geriye bişey döndürmez
//testAbstract adında bir metot var 
//() parametre almaz

//kullanacak kişiye yani temelSinif metotu nu kullanacak kişiye diyoruz ki
//sen bu nesneyi kalıtıyosan eğer bu şekilde bir metot olustur ve bununda body sini yaz diyoruz 
//kime diyoruz bunu bunu kullanan yere yani buradaki senaryoda musteri sınıfına 
//musterı sınıfı temelSinifi kalıttıgı için oraya demıs oluyoruz

//Musteri sınıfına gittiğim de hata verecek diyor ki ben abstract bir sınıfı miras aldım içinde bir metot var bunu burada kullanmak zorundayım 

//Musteri sınıfına gidelim

//2. not bitiş


//*/