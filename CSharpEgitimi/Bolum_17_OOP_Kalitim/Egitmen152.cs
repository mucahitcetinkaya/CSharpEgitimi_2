
//using System;

//namespace Bolum_17_OOP_Kalitim
//{
//    //public class Egitmen152
//    //{
//    //    public TemelTip152 _TemelTip152 { get; set; }
//    //}

//    public class Egitmen152 : TemelTip152
//    {

//        public string Brans { get; set; }
//        public int BransSeviye { get; set; }

//        public DateTime IsBaslangicTarihi { get; set; }
//        public DateTime IsBitisTarihi { get; set; }
//        public int IzınGunSayisi { get; set; }

//    }


//}

///*
 
//2. not bitiş

//3. not baslangıc 

//innertype olusturup kullanmak için ornekleme yapacagız

// public class Egitmen152
//    {
//        public TemelTip152 _TemelTip152 { get; set; }
//    }

//boyle yapmak aklınıza gelebilir ama kalıtımın ana maksadı bu degıl arkadaslar 
//kalıtımın maksadı
//egitimin içerisinde temeltipi gösterebilmek 
//ben egitmen. dedigimde id field ına ulasmak istiyorum 
//egitmen.temeltip.id demek istemiyorum

//kalıtım konusunda tamamen bir miras alma var field i o nesnenin field i olarak görmemız gerekiyor 
//dolayısıyla bu kullanım tamemen yanlıs kalıtım için

//peki kalıtımı nası kullanabiliriz 

//kalıtımı kullanabilmek için ana class ımızın adının yanına : ekleyip istediğimiz class ı türemek istediğimiz class ı cagırıyoruz

//    public class Egitmen152 : TemelTip152
//    {

//    }

//bu demek ki 

//TemelTip152 içinde var olan field lar metotlar tamamiyle Egitmen class ı tarafından miras alınabilsin ve kullanılabilsin

//program.cs e gidip bakalım olmus mu 

//3. not bitiş

//4. not bitiş 

//5. not baslangıc

//bizim egitmenimize ozel olan 2 farklı field ımız var cunku isebaslangıc isbitis tarihi gibi degerler personel class ımız ile de birleşiyor

//onu farklı bir modelleme sekli ile cozmeye calısacagız 

//burda 2 tane field yazdık 

//    public class Egitmen152 : TemelTip152
//    {

//        public string Brans { get; set; }
//        public int Seviye { get; set; }

//    }

//program.cs de E1. dedigimiz de artık bu 2 field da cıkıyor karsımıza 

//program.cs e gidelim

//5. not bitiş

//7. not bitiş

//8. not baslangıc

//Personelden geldik 

//        public DateTime IsBaslangicTarihi { get; set; }
//        public DateTime IsBitisTarihi { get; set; }
//        public int IzınGunSayisi { get; set; }

//bunları eklemek için

//program.cs e gidelim 

//8. not bitiş

//10. not bitiş

//11. not baslangıc

//Seviye field ı ogrenci ile karısmasın diye BransSeviye yaptık 

//evet temel olarak : operatöründen sonra türetmek istediğimiz class ı cagırarak aslında bir türemeyi elde etmiş olduk
//kalıtımı field bazında görmüş olduk
//bu kalıtımın yuzelsel anlatımı bir sonraki video da derinlere inip kalıtımdaki class ın calısma mantıgına bakacagız
 
//*/