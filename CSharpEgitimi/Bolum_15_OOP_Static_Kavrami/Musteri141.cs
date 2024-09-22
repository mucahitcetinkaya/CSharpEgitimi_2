//using System;
//using System.Collections;

//namespace Bolum_15_OOP_Static_Kavrami
//{
//    public class Musteri141
//    {

//        #region Sanal Database

//        static ArrayList musteriDatabase;

//        #endregion

//        #region Static Yapıcı Metot

//        static Musteri141()
//        {
//            musteriDatabase = new ArrayList();
//        }

//        #endregion

//        #region Field

//        public int musteriID { get; set; }
//        public string isim { get; set; }
//        public string soyIsim { get; set; }
//        public string emailAdres { get; set; }
//        public string sifre;

//        #endregion

//        #region Kapsulleme

//        private string _kullaniciAdi;

//        public string KullaniciAdi 
//        { 
//            get {  return this._kullaniciAdi; } 
//            set 
//            {
//                bool kullaniciAdiKontrol = musteriKullanıcıAdiKontrol(value);
//                if (kullaniciAdiKontrol)
//                {
//                    Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistem içerisinde kayıtlı.");
//                    this.KullaniciAdi = string.Empty;
//                }
//                else
//                {
//                    this._kullaniciAdi = value;
//                }
//            }
//        }

//        #endregion

//        #region Static Metotlar

//        private static bool musteriKullanıcıAdiKontrol(string _kullaniciAdi)
//        {
//            bool kontrol = false;

//            for (int i = 0; i < musteriDatabase.Count; i++)
//            {
//                Musteri141 Temp = (Musteri141) musteriDatabase[i];

//                if (Temp.KullaniciAdi == _kullaniciAdi)
//                {
//                    kontrol = true;
//                    break;
//                }
//            }

//            return kontrol;
//        }


//        public static void MusteriEkle(Musteri141 M)
//        {
//            #region Parametre Kontrol

//            if (M != null && !string.IsNullOrEmpty(M.KullaniciAdi) && !string.IsNullOrEmpty(M.emailAdres))
//            {
//                bool emailAdresKontrol = musteriEmailAdresKontrol(M.emailAdres);
//                if (emailAdresKontrol)
//                {
//                    Console.WriteLine("Eklemek istediğiniz kullanıcı sistemde kayıtlı.");
//                }
//                else
//                {
//                    musteriDatabase.Add(M);
//                    Console.WriteLine("Yeni kayıt işlemi başarılı.");
//                }
//            }

//            #endregion

//        }

//        private static bool musteriEmailAdresKontrol(string _emailAdres)
//        {
//            bool kontrol = false;
//            for (int i = 0; i < musteriDatabase.Count; i++)
//            {
//                Musteri141 Temp = (Musteri141)musteriDatabase[i];
//                if (Temp.emailAdres == _emailAdres)
//                {
//                    kontrol = true;
//                    break;
//                }

//            }
//            return kontrol;
//        }

//        #endregion

//    }
//}

///*
 
//1. not sonu
//2. not baslangıc

//region olarak alanlar acılacak once fieldlarımızı yazacagız
//_kullaniciAdi bir kapsulleme olacak ondan dolayı _ ile olarak ve private olarak yazalım
//yeni bir region acalım kapsülleme alanı 
//get ve set bloklarını dolduralım
//datayı gösterirken herhangi bir filtrem yok o nedenle get kısmı 
//            get {  return this._kullaniciAdi; } 
// bu sekılde kalacak 
//set kısmında bir detay olacak kullanıcı adını bir database den aramam gerekecek
//ve bu database bir arraylist olacak 

//baska bir region acalım SanalDatabase 
 
//ArrayList olan bir koleksiyon olusturmam gerek ve static olması lazım 

//        static ArrayList musteriDatabase;

//ben Musteri nesnesini cagırdıgım da eger static yapıcı metot içerisinde musteriDatabase ini new ile orneklemezsem

//musteriDatabase i default olarak null degerini alır 
//bunu once görelim 

//Program.cs gidelim ve Musteri141 i new ile cagıralım 

//2. not bitiş
//3. not bitiş

//4. not baslangıc

//yeni bir region acalım Static yapıcı metot 


//         #region Static Yapıcı Metot

//        static Musteri141()
//        {

//        }

//        #endregion
 
//static yapıcı metot bir kere calısacagı için musteriDatabase i ni cagırıp new ile örnekliyorum 

//        static Musteri141()
//        {
//            musteriDatabase = new ArrayList();
//        }

//artık ben Musteri141 i kullandıgımda bunun new ile orneklenmıs halini yakalayabilirim

//Program.cs e gidip tekrar calıstıralım bakalım static membersler ne durumda olmus 

//4. not bitiş
//5. not bitiş

//6. not baslangıc

//Kapsulleme region ın daki set kısmını ayarlayalım 

//kullanıcıadı içerisinde ben datayı set blogundan value olarak alırken bunu içeride bir kontrol mekanizmasına sokmam gerekiyor

//musteriKullanıcı adında bir tane metot yapalım 

//yeni bir region acalım Static Metotlar 

//burada olusturacagım metot benim içeride ve dısarıda kullanacagım bir metot mu 
//hayır sadece içeride kullanacagım o zaman private olarak olusturabilirim
//geri bana bool döndurecek dogru mu yanlıs mı var mı yok mu gibi 
//metotun adı musteriKullaniciAdiKontrol() 
//parametre olarak kullanıcıadını kontrol etmek istiyorum 
//musteriKullaniciAdiKontrol(string _kullaniciAdi) 
//metodun body sine indidiğimde elimde static bir ArrayList var 
//bu ArrayList içerisinde dönmem degeri bulursam buldum diye söylemem gerekiyor 

//içerisine bool konrol = false; diye bir degisken olusturuyorum 

//ve bunu return ediyorum 

//return kontrol;



//        #region Static Metotlar

//        private static bool musteriKullanıcıAdiKontrol(string _kullaniciAdi)
//        {
//            bool kontrol = false;

//            return kontrol;
//        }


//        #endregion

//bunun içinde de for ile arraylist içinde dönecegiz count kadar

//  for (int i = 0; i < musteriDatabase.Count; i++)
//            {
                
//            }

//ArrayList i hatırlarsanız ArrayList degerleri obje olarak alıyordu 
//benim Musteri nesnem ArrayList içerisinde obje olarak saklı 

//bunu unboxing etmem gerek boxing olarak saklı obje olarak duruyor

//bunu Musteri nesnesine cevirip kontrolü öyle yapmam gerek 

//Musteri Temp = (Musteri)musteriDatabase[i];

//Musteri tipinde temp adında bir degisken olusturup
//musteriDatabase in i ninci degerini unboxing yaparak 
//i ninci yani sıradaki degerini Musteri nesnesine ceviriyoruz

//elimde i ninci degerine ait bir deger oldu 
//gelen musterinin kullanıcıadını bana parametre olarak gelen kullanıcıadıyla eşleştirmeye calısıyorum

//bunu da if ile yapıyoruz 

//for (int i = 0; i < musteriDatabase.Count; i++)
//            {
//                Musteri141 Temp = (Musteri141) musteriDatabase[i];

//                if (Temp.KullaniciAdi == _kullaniciAdi)
//                {

//                }
//            }


//eger ben bunu buluyorsam database içerisinde böyle bir kullanıcıadı varsa 

//kontrol true olacak o zaman 
//sonra break ile for döngusunu kırıyoruz 

//sonrada kontrol u return ettik zaten 

// if (Temp.KullaniciAdi == _kullaniciAdi)
//                {
//                    kontrol = true;
//                    break;
//                }

//set bloguna gittiğimde benim ihtiyacım olan kod blogu nerde musteriKullaniciAdiKontrol blogunun içerisin de 

//benim bunu cagırmam gerek 

//musteriKullanıcıAdiKontrol deger istiyor bizden o da set içinde value olarak geliyor 

// public string KullaniciAdi 
//        { 
//            get {  return this._kullaniciAdi; } 
//            set 
//            {
//                bool kullaniciAdiKontrol = musteriKullanıcıAdiKontrol(value);

                   
//            }
//        }

//sonra if ile kontrol leri yapmamız gerek 

//eger kullaniciAdiKontrol true ise yani sistemde var ise o zaman var diye mesaj döneriz

// bool kullaniciAdiKontrol = musteriKullanıcıAdiKontrol(value);
//                if (kullaniciAdiKontrol)
//                {
//                    Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistem içerisinde kayıtlı.");
//                    this.KullaniciAdi = string.Empty;
//                }

//eger sistemde kayıtlı degilse 

//o zaman yeni bir kullacı adı bu sanaldatabase de yok 

//if (kullaniciAdiKontrol)
//                {
//                    Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistem içerisinde kayıtlı.");
//                    this.KullaniciAdi = string.Empty;
//                }
//                else
//                {
//                    this._kullaniciAdi = value;
//                }

//_kullaniciAdi na value daki degeri atarım 

//birde sifre degerimiz var Field alanına bir de sifre ekleyelim 

//        public string sifre;


//        private string _kullaniciAdi; nı Kapsulleme region ına cektik

//musteriyi eklemek istediğimiz de bazı sartlarımız vardı 

//yeni bir static metot olusturalım Static Metot region kısmına yazacagız

//bu metot ne yapacak musteri ekleyecek yani public olması lazım 
//neden public dısarıdan erişilecek Program.cs de Musteri141. dediginde benım metotuma ulasacak

//geriye birşey dönmeyecek void olacak metot adı MusteriEKle() olsun 

//parametre olarak Musteri nesnesinden M nesne ornegını istiyorum

//        public static void MusteriEkle(Musteri141 M)
//        {

//        }

//bu metot içinde once parametre kontrol yapacagız bir region acalım 

//bana parametre olarak gelen deger esit degilse null a null degilse yani 
//VE
//bana parametre olarak gelen deger içindeki kullanıcıAdi esit degilse string.Empty ye yani bos degilse

// public static void MusteriEkle(Musteri141 M)
//        {
//            #region Parametre Kontrol

//            if (M != null && M.KullaniciAdi != string.Empty)
//            {

//            }


//            #endregion

//        }

//buralardan gectiyse ben neyi biliyorum 
//yeni bir musteri tanımı yapılmıs 
//kullanıcıadı kısmında ilgili kontroller devreye girmiş 
//ve kullanıcıadı doluysa bu database de olmayan bir kullanıcıdır demısımdır 

//yani ben artık kullanıcıadı na göre kontrol saglamısım bir ek maddem vardı
//kullanıcının email adresine göre kontrol saglamak 

//bunun içinde bir metot yazalım 

//bu metot kendısıne parametre olarak gelen email adresini sanal olusturmus oldugumuz database içerisinde kontrol edecek
//public olmayacak iç metot olarak cagıracagım 

//private bool musteriEmailAdres()

//private yazmazsan da private olur 
//public için public yazmak zorundasın ama

//private static bool musteriEmailAdresKontrol(string _emailAdres)
//        {
//            bool kontrol = false;
//            for (int i = 0; i < musteriDatabase.Count; i++)
//            {
//                Musteri141 Temp = (Musteri141)musteriDatabase[i];
//                if (Temp.emailAdres == _emailAdres)
//                {
//                    kontrol = true;
//                    break;
//                }

//            }
//            return kontrol;
//        }

//içeride kullanıcak private 
//bir kere kullanılacak static
//true false dönecek bool
//parametre olarak string _emailAdres alacak
//içeride bir kontrol sagladım
//for ile musteriDatabase in count u kadar döndüm
//gelenler obje bunları musteri nesnesine cevirdim
//cevirme nedenim içerisindeki field a göre işlem yapabilmek
//temp içindeki emailadres parametre olarak gelen _emailAdres e eşitse true yaptık
//break ile donguden cıktık

//neden for ile dönuyoruz
//generic tipleri görunce geceric koleksiyonları da göreceğiz
//orda bu işlemler daha basit daha kolay
//bu asamada biraz daha uzun yazıyoruz ki 
//eski konular otursun direk yeni konuları ogrenırsek bu sefer tamamiyle hiç bişey bilmeyecek durumada düşebiliyoruz

//MusteriEkle metotu boyleydi en basta 

//public static void MusteriEkle(Musteri141 M)
//        {
//            #region Parametre Kontrol

//            if (M != null && M.KullaniciAdi != string.Empty)
//            {

//            }

//            #endregion

//        }

//emty degilde null olabilir null olursa gecer bundan dolayı
//burda bir degisiklik yapıp 

//public static void MusteriEkle(Musteri141 M)
//        {
//            #region Parametre Kontrol

//            if (M != null && !string.IsNullOrEmpty(M.KullaniciAdi))
//            {

//            }

//            #endregion

//        }

//boyle yapıyoruz 

//IsNullOrEmpty içerisine vermiş oldugunuz string in null veya empty olmasına bakıyor
//ben degilse demek istiyorum basına ! koyalım

//MusteriEkle metotu son durum bu 

//public static void MusteriEkle(Musteri141 M)
//        {
//            #region Parametre Kontrol

//            if (M != null && !string.IsNullOrEmpty(M.KullaniciAdi) && !string.IsNullOrEmpty(M.emailAdres))
//            {
//                bool emailAdresKontrol = musteriEmailAdresKontrol(M.emailAdres);
//                if (emailAdresKontrol)
//                {
//                    Console.WriteLine("Eklemek istediğiniz kullanıcı sistemde kayıtlı.");
//                }
//                else
//                {
//                    musteriDatabase.Add(M);
//                    Console.WriteLine("Yeni kayıt işlemi başarılı.");
//                }
//            }

//            #endregion

//        }

//m.kullanıcıadi ve m.emailadres null veya empty degilse dedik

//musteriEmailAdresKontrol metodunu cagırdık bizden parametre istiyor emailAdres buraya da M.emailAdres verdik
//bool geri dönuyor 
//bool emailAdresKontrol dedik
//emailAdresKontrol true ise sistemde var diye yazdırdık

//degilse sistemde yoktur

//musteriDatabase.Add(M) dedik m dediğimiz parametre olarak gelen nesne

//musteriDatabase in içine add metotu ile ekledik ve ekledik diye bildirim verdik

//sımdı program.cs e gecelim

//6. not bitiş



 
//*/