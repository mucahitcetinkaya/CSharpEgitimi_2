//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bolum_12_Metot
//{
//    public class Ogrenci108
//    {

//        public void OgrenciMetot1(string ogrenciAdi, string ogrenciSoyadi)
//        {
//            Console.WriteLine("Öğrenci Bilgileri : {0} {1}" , ogrenciAdi , ogrenciSoyadi);
//        }
//        private void OgrenciMetot2(string ogrenciAdi, string ogrenciSoyadi)
//        {
//            Console.WriteLine("Öğrenci Bilgileri : {0} {1}", ogrenciAdi, ogrenciSoyadi);
//        }
//        public void OgrenciMetot3()
//        {
//            OgrenciMetot2("Mücahit","Çetinkaya");
//        }

//    }
//}



///*

//Bölüm 12 Metot VİDEO 108
//öncelikle bizim metotlarımızın

//Metot yazarken olması gerekenler

//[ErişimBelirleyicisi] <GeriDönüşDeğeri> MetotAdı()
//{
//    metotun calısması için gereken kodlar
//}

//mevcut metot işlem yapmaya baslarken kendısını cagıran noktadan herhangi bir parametre alıp
//parametre uzerınde işlem yapacaksa parantezler içine parametreler yazılır
//işlem yapılmayacaksa parametre yollanmaz
//daha sonrada metot içindeki scop içine
//yani metotun body si de denir buna işlemler buraya yazılır


//[ErişimBelirleyicisi] <GeriDönüşDeğeri> MetotAdı(Parametreler)
//{
//    metotun calısması için gereken kodlar
//}


//Erişim Belirleyicisi Nedir ??

//5 farklı erişim belirleyicisi bulunmaktadır.

//Public Private Protected Internal InternalProtected

//Public 
//Ben metotuma sadece class ın içinden degil classıma ulasan herkesinde buna ulasmasına izin veriyorum demektir.

//Private
//metot sadece içerisinde bulunan class duzeyinde cagırabilir 
//yani private bir metot nerde olusturulduysa orda kullanılır
//Ogrenci classına ulasabilir ama metoda ulasamaz
//metoda ulasmak için metotun olustugu yerde işlem yapmak gerekir

//Protected
//Kalıtım konusunda yoğun olarak işleyeceğiz
//Birbirinden nesneler kalıtıldıgında Protected kullanılabilir.

//Internal
//İlgili kutuphane içerisinde ulaşabilirsin

//InternalProtected
//Uygulama içerisinde veya kalıtıldıysa ulasabilirsin diyoruz

//bu kısımda sadece public ve private kısımlarına giriyoruz
//diğer kısımları Polymorphism kalıtım konularında göreceğiz

//şimdi bir metot tanımı yapalım 
//classın dısarısından erişilmesini istiyorum
//class ıma ulasan herkes metotumu görebilsin
//erişim belirleyicisi public olacak
//geri dönüşü olmayacak void olacak
//parametre alsın ogrenciAdi ogrenciSoyadi

//public void OgrenciMetot(string ogrenciAdi, string ogrenciSoyadi)
//        {
//            Console.WriteLine("Öğrenci Bilgileri : {0} {1}" , ogrenciAdi , ogrenciSoyadi);
//        }

//Program.cs e gidelim bu metotu cagıralım

//Program.cs den geldik

//        private void OgrenciMetot2(string ogrenciAdi, string ogrenciSoyadi)
//        {
//            Console.WriteLine("Öğrenci Bilgileri : {0} {1}", ogrenciAdi, ogrenciSoyadi);
//        }
//        public void OgrenciMetot3()
//        {
//            OgrenciMetot2("Mücahit","Çetinkaya");
//        }

//private oldugu halde aynı class içinde oldugundan cagırma yapabildik.

//OgrenciMetot2 private OgrenciMetot3 public

//OgrenciMetot3 içinde 2 yi cagırdık oldu aynı yerde oldukları için
//peki 3 de public oldugu için diger class da cagırsak

//Program.cs e gidelim

//*/