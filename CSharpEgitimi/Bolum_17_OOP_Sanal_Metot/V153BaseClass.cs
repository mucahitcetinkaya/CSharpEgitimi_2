

//using System;

//namespace Bolum_17_OOP_Sanal_Metot
//{
//    public class V153BaseClass
//    {
//        //public void EkranaYaz(string data)
//        //{
//        //    Console.WriteLine(data);
//        //}

//        public virtual void EkranaYaz(string data)
//        {
//            Console.WriteLine(data);
//        }


//    }
//}

///*
 
//1.not bitiş program.cs den geldik

//2. not baslangıç

//public yap class ı

//sanal olmayan bir metot olusturalım EkranaYaz()
//public void EkranaYaz(string data)
//        {
//            Console.WriteLine(data);
//        }

//dısa acık public
//geriye deger donmeyen void
//parametreli string data
//ekrana aldıgı datayı yazdıracak console.writeline(data)
//class ı ornekleyıp kullanabileceksin

//yeni bir class olusturalım Urun

//2. not bitiş

//4. not bitiş program.cs den geldik

//5. not baslangıc

//sanal metodu guncellemek için erişim belirleyicisinden sonra publicten sonra virtual yapmamız lazım
//ilk hali

//public void EkranaYaz(string data) => metodun imzası burası
//        {
//            Console.WriteLine(data); => metotun body si burası scop arası
//        }

//sonraki hali


//public virtual void EkranaYaz(string data) => metodun imzası burası
//        {
//            Console.WriteLine(data); => metotun body si burası scop arası
//        }

//virtual kullandıktan sonra metot sanal bir metot olur 

//sanal metotu hiç ellemezsen baseclass için de oldugu gibi calısır override ile türemiş sınıfın türetilmiş sınıfın metotlarına dokunursak 
//türemiş olan sınıf türetilmiş olan sınıfın sanal metodunu ezer ve kendi içindeki metodu kullanır

//urun class ına gidelim

//5. not bitiş
 
//*/