//namespace Bolum_15_OOP_Static_Kavrami
//{
//    public class Personel137
//    {

//        public static string domainAdres = "firmam.com";
//        public string Isim { get; set; }
//        public string SoyIsim { get; set; }

//        private string _emailAdres;
//        public string EmailAdres
//        {
//            get
//            {
//                return this._emailAdres;
//            }

//            set
//            {
//                this._emailAdres = value.ToLower() + "@" + Personel137.domainAdres;
//            }
//        }

//        public int Cinsiyet { get; set; }



//    }
//}




///*

//1. not bitiş 

//2. not baslangıc

//class ı public yapalım

//Static field lar normal personel field ları metotlar static metotlar olarak
//bu class ımızı genişleteceğiz 

//gerekli field ları yazalım
 
//        public static string domainAdres = "firmam.com";

//daha sonra bir personel olusturdugumuzda bu personelin
//temel ihtiyacı olan bazı degerleri var 
//isim soyisim emailadres tckimlikno 

//Program.cs e gidelim

//2. not bitiş
//3. not bitiş

//4. not başlangıc

//_emailAdres private oldugu için sadece class içinden ulasabilirsin
//EmailAdres prop get set var ama kullanmadık field olarak da kullanılabilir böyle
//get set bloklarını duzenleyelim

//private string _emailAdres;
//        public string EmailAdres
//        {
//            get;

//            set;
//        }

//get dedigimiz de private olana gönder return et dicez
//set dedigimiz de işlem yaptıracagız
//value ile gelen degeri yakalayıp ToLower ile hepsini kucuk yapıp
//+ ile birleştirip @ ekleyip sonrada Personel.domainAdres ile uzantısını ekleyeceğiz

//        private string _emailAdres;
//        public string EmailAdres
//        {
//            get
//            {
//                return this._emailAdres;
//            }

//            set
//            {
//                this._emailAdres = value.ToLower() + "@" + Personel137.domainAdres;
//            }
//        }

//bu @ ekleme personel.domainadres olayını program.cs de 
//emailadres eklerkende yapabilirsiniz
//ama bu class içinde yapmak daha mantıklı 
//neden
//Personel nesnesini ben uygulama içinde kullanılıyor olabilirim
//her mudahale uygulamayı zora sokacaktır

//4. not bitiş
//5. not bitiş

//6. not baslangıc

//ama oraya da breakpoint koymanız lazım


//set
//{
//    this._emailAdres = value.ToLower() + "@" + Personel137.domainAdres;
//}

//EmailAdres property sının set problarına dustu kod 

//value da hepsinin kucuk harfli yazdıgını göruyoruz

//birde @ ve domainadresi eklendıgın de 

//mail adresim

//mucahitcetinkaya@firmam.com olarak olusacak

//devam edince get bloguna gitti ve olustu 

//f10 ile devam edince program.cs e geliyor kod

//6. not bitiş
 
 
//*/