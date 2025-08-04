
//using System;

//namespace Bolum_17_OOP_Sanal_Metot
//{
//    public class V153Urun : V153BaseClass
//    {

//        //public override void EkranaYaz(string data)
//        //{
//        //    base.EkranaYaz(data);
//        //}

//        public override void EkranaYaz(string data)
//        {
//            Console.WriteLine("urun => " + data);
//        }



//    }
//}

///*
 
//2. not bitiş BaseClass dan geldik

//3. not başlangıc

//public yap
 
//bunu baseclass dan kalıtım yapacagız içeride herhangi bir işlem yapmamıza gerek yok

//urun uzerınden baseclass daki ekrana yaz metoduna ulasabilecegız

//program.cs e gidelim

//3. not bitiş

//5. not bitiş baseclass dan geldik

//6. not baslangıc

//baseclass da virtual olarak degistirdik metodu orda virtual yaptıgın metodu cagırmak için burda override ile cagırmak lazım

//override yazınca tooltype de ekrana yaz metotunun da sanal metotlara eklenmıs oldugunu görüyorum

//ben urunden baseclass ı baseclassdan da object nesnesini kalıttıgımı görüyorum burada 

//ekranayaz baseclass ın sanal metotu diger cıkanlar object in sanal metotu 

//içeriğini degistirmek istiyorsan override ile yapabilirsin

//override diyip ekrana yazı cagırınca 

//public override void EkranaYaz(string data)
//        {
//            base.EkranaYaz(data);
//        }

//cıkıyor 

//baseclass ıcındekı kısım geliyor 

        
//metot imzası aynı geldi  => public override void EkranaYaz(string data)
//farklı gelen yer metotun body si => base.EkranaYaz(data);

//base üstüne gelince V153BaseClass i işaret ediyor 

//base.EkranaYaz(data); kısmını degistirebilirsin diyor

//public override void EkranaYaz(string data)
//        {
//            Console.WriteLine("urun => " + data);
//        }


//baseclass içinde sanal metot olusturduk virtual ile
//onu urun class ının içinde override ile cagırdık ve degistirdik

//program.cs e gidelim

//6. not bitiş

 
//*/