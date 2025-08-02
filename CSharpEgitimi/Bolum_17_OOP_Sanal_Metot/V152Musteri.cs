
//namespace Bolum_17_OOP_Sanal_Metot
//{
//    public class V152Musteri
//    {
//        public int musteriID { get; set; }
//        public string isim { get; set; }
//        public string soyisim { get; set; }


//        //public override string ToString()
//        //{
//        //    return base.ToString();
//        //}

//        public override string ToString()
//        {
//            return isim + " " + soyisim;
//        }


//    }
//}


///*
 
//1.not bitiş program.cs den geldik

//2. not baslangıc

//public yapcaz
 
//normal sartlarda kalıtım yaparken : yazıp ne kalıtım yapacaksak onu yazıyorduk
//:Object yazmaya gerek yok zaten Framework tüm nesneleri object ten türetiyor
//zaten eğitimin basında boxing ve unboxing konularını hatırlarsanız eğer
//biz bütün nesnelerimizi object in içerisine sıgdırabiliyorduk buna boxing diyoduk
//object ten geri almaya da unboxing diyoduk

//yani ben musteri nesnesini ornekledıgımde arka tarafta 
//object ten musterıyi alıp sunuyorum

//prob ekleyelim

//3 adet prob ekledik

// public int musteriID { get; set; }
//        public string isim { get; set; }
//        public string soyisim { get; set; }

//baska bir şey yok class da 

//program.cs e geri donelim ve new leyelim

//2. not bitiş

//3. not bitiş

//4. not başlangıc program.cs den geldik

//tostring metodununu guncellememız lazım

//override adında bir anahtar kelimem var     

//bu anahtar kelimesini kullandıgınız da kullandıgımız class türemiş oldugu class ın içerisindeki tüm sanal metotları karsımıza getirir

//benım bu class ım object nesnesinden türediği için object nesnesinin sanal metotlarını getiriyor

//yani musteri içinde override yazarsan eğer tooltype olarak musteri nesnesi de objectten türediğinden object nesnesinin sanal metotlarını getiriyor

//override diyip duzeltmek istediğiniz metodu secinde imzası olarak gelir

// public override string ToString()
//        {
//            return base.ToString();
//        }

//publicmis heryere acık override zaten anahtar kelime
//geriye string donuyor adı da tostring

//return base. dedıgı kısım base object i gösteriyor

//nerede cagrıldıgıysa bu bir onceki kalıtıldıgı class ı gösterir
//musteri object ten geldıgı için object i gösteriyor

//mesela return kısmını degistirelim

// public override string ToString()
//        {
//            return isim + " " + soyisim;
//        }

//ne zaman tostring i cagırırsam bana isim soyisim dönsun dedim

//en basta debug ederken f11 ile gitmeye calısıgımız da gitmiyordu 
//şimdi override ettıgımız için f11 e basınca object içindeki tostring calısmaz da musteri içindeki tostring calısır

//sanal metota mudahale edınce mudahale ettıgımız kısım calısıyor

//program.cs e gidelim debug edelim

//4. not bitiş


//*/