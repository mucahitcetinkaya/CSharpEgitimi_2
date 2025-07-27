
//using System;

//namespace Bolum_17_OOP_Kalitim
//{
//    public class BaseClass160
//    {

//        public static int sayac = 1;

//        public BaseClass160()
//        {
//            _id = sayac;
//            sayac = sayac + 1;
//        }

//        private int _id;
//        public int Id
//        {
//            get
//            {
//                return _id;
//            }
//            private set
//            {
//                //_id = sayac;
//                //sayac = sayac + 1;
//            }
//        }


//        private string _barkod;
//        public string Barkod
//        {
//            get
//            {
//                return _barkod;
//            }
//            set
//            {
//                bool kontrolIslemi = SanalDataBase.DbBarkodKontrol(value);
//                if (!kontrolIslemi) // false ise değeri sanaldatabase içinde bulamadım
//                {
//                    _barkod = value;
//                }
//                else
//                {
//                    Console.WriteLine("Sanal database içerisinde bu barkod daha önce girilmiştir.");
//                }

//            }
//        }
//        public DateTime OlusturmaTarihi { get; set; }
//        public int OlusturanKullanici { get; set; }
//        public DateTime GuncellemeTarihi { get; set; }
//        public int GuncelleyenKullanici { get; set; }
//        public bool SilindiMi { get; set; }


//    }
//}



///*
 
//1. not bitiş

//2. not baslangıc

//BaseClass ı olusturduk ve problarını yazacagız
//id alanı eklemıs oldugumuz nesnelerin id lerini temsil edecek tüm nesnelerimizin id degeri olacagı için bunu BaseClass a yazdık
//id kısmında bir kontrol yapacagız
//baseclass dan türemiş olan nesnelerin id lerini biz vermeyeceğiz
//arka tarafta bir yapı entegre edecegiz ve her olusturdugumuz nesne gidip o yapıdan yeni degeri ögrenip kendisine uniq bir id degeri alacak

//barkod alanı her ürünün barkodunun uniq olması lazım burada bir kontrol yapacagız
//barkod degerini biz verecegız ama eklemıs oldugumuz barkod degerını ise bir sanal database içerisinde
//aratıp daha once ekleyip eklemedıgımız kontrolunu birlikte yapacagız

//prob ları yazdık Urun classını olusturup ordan devam edelim

//2. not bitiş

//6. not bitiş

//7. not baslangıc

//2. soru için gerekli duzenlemeleri yapacagız önceki hali asagıdaki gibi

//        public int Id { get; set; }
//        public string Barkod { get; set; }
//        public DateTime OlusturmaTarihi { get; set; }
//        public int OlusturanKullanici { get; set; }
//        public DateTime GuncellemeTarihi { get; set; }
//        public int GuncelleyenKullanici { get; set; }
//        public bool SilindiMi { get; set; }

//önce private olarak bir field yazdık 
//        private int _id;
//sonrada Id degerinin get set alanlarını acıp guncelleyeceğiz

//get dedigimiz de aklımıza gelmesi gereken degeri içeriden dısarıya gönderme olmalı biz içeriden dısarıda gönderme için herhangi bir sart koşmadık bundan dolayı 
//return _id dememiz yeterli.

//set kısmına gelince burda bir işlem yapacagız 

//bir sayac içerisindeki degerden faydalanmak istiyoruz 

//sayac degerini hep bir arttırıp artan degeri takip edip sıradaki id yi almak istiyoruz

//birde dısarıdan bu işlem yapılamasın istiyoruz

//bunun içinde set kısmını private olarak işaretmemiz yeterli

//set kısmını private yapınca program.cs e bakarsanız B1.Id = 1; kısmında hata veriyor ve bu kısımda set kısmının private oldugunu söylüyor

//içeride kendisini takip eden bir deger istiyoruz 

//bir nesne orneklendıgınde sadece bir kere calısan yapının adı neydi ?? static 
//bundan dolayı ben int static bir sayac prob eklersem ilgili prob uzerınde işlem yapıp sayac degerımı kontrol edebilirim 

//public static int sayac = 1;

//ilk olustugunda otomatik olarak 1 degerını alacak

//private set kısmında bunları işleyebiliriz

//_id = sayac;
//sayac = sayac + 1;
//dedigimiz de bunları içeriden set edebiliriz 
//_id = sayac; dedigimiz de 1 degerini _id e atamıs olduk 
//sayac = sayac + 1; dediğimiz de de static tarafta olan degerımızı de guncelleriz

//son durum bu 

// public class BaseClass160
//    {

//        public static int sayac = 1;

//        private int _id;
//        public int Id 
//        { 
//            get 
//            {
//                return _id;
//            } 
//            private set
//            { 
//                _id = sayac;
//                sayac = sayac + 1;
//            }
//        }
//        public string Barkod { get; set; }
//        public DateTime OlusturmaTarihi { get; set; }
//        public int OlusturanKullanici { get; set; }
//        public DateTime GuncellemeTarihi { get; set; }
//        public int GuncelleyenKullanici { get; set; }
//        public bool SilindiMi { get; set; }


//    }

//program.cs e gidelim

//7. not bitiş

//8. not bitiş

//9. not baslangıc

//biz baseclass da ilgili işlemleri yaptıgımız halde neden id degerimiz artmadı ????
//bunun notları için baseclass a gidelim

//_id degerimiz içeride private olarak duruyor          private int _id;
//bunun dısarıda deger alma ve gönderme probları da 
//public int Id 
//        { 
//            get 
//            {
//                return _id;
//            } 
//            private set
//            { 
//                _id = sayac;
//                sayac = sayac + 1;
//            }
//        }
//burda duruyor 

//get dedigimiz de içeride private olarak sakladıgımız degeri dönuyoruz buraya bakmak gerekmıyor 
//set kısmında baktıgımız da bizim field ımıza bir deger GELMEYE calıstıgında 
//içeride saklamıs oldugumuz _id degerimizi statik olarak verdiğimiz sayac degerimize atıyoruz ve sayac degerimizi de 1 guncelliyoruz

//ama biz bu prob a bir deger gelmesini engelledik private yaptık bundan dolayı deger gelemez

//biz bunu nerde yapacagız nesneler orneklendıgın de yani baseclass içinde bir yapıcı metot içinde bu işlemi yapsam basarılı olurum

//bir ctor olusturalım

//ctor oncesi

// public class BaseClass160
//    {

//        public static int sayac = 1;

//        private int _id;
//        public int Id 
//        { 
//            get 
//            {
//                return _id;
//            } 
//            private set
//            { 
//                _id = sayac;
//                sayac = sayac + 1;
//            }
//        }
//        public string Barkod { get; set; }
//        public DateTime OlusturmaTarihi { get; set; }
//        public int OlusturanKullanici { get; set; }
//        public DateTime GuncellemeTarihi { get; set; }
//        public int GuncelleyenKullanici { get; set; }
//        public bool SilindiMi { get; set; }


//    }

//son durum 

//public class BaseClass160
//    {

//        public static int sayac = 1;

//        public BaseClass160()
//        {
//            _id = sayac;
//            sayac = sayac + 1;
//        }

//        private int _id;
//        public int Id 
//        { 
//            get 
//            {
//                return _id;
//            } 
//            private set
//            { 
//                //_id = sayac;
//                //sayac = sayac + 1;
//            }
//        }
//        public string Barkod { get; set; }
//        public DateTime OlusturmaTarihi { get; set; }
//        public int OlusturanKullanici { get; set; }
//        public DateTime GuncellemeTarihi { get; set; }
//        public int GuncelleyenKullanici { get; set; }
//        public bool SilindiMi { get; set; }


//    }

//program.cs e gidelim

//9. not bitiş


//18. not başlangıc program.cs den geldik

//barkod field i guncellenecek

//önceki kodlar


//using System;

//namespace Bolum_17_OOP_Kalitim
//{
//    public class BaseClass160
//    {

//        public static int sayac = 1;

//        public BaseClass160()
//        {
//            _id = sayac;
//            sayac = sayac + 1;
//        }

//        private int _id;
//        public int Id
//        {
//            get
//            {
//                return _id;
//            }
//            private set
//            {
//                //_id = sayac;
//                //sayac = sayac + 1;
//            }
//        }
//        public string Barkod { get; set; }
//        public DateTime OlusturmaTarihi { get; set; }
//        public int OlusturanKullanici { get; set; }
//        public DateTime GuncellemeTarihi { get; set; }
//        public int GuncelleyenKullanici { get; set; }
//        public bool SilindiMi { get; set; }


//    }
//}

//guncellemeden sonrası 

//private bir alan olusturmamız lazım ve onu get blogunda geriye return yapacagız

// private string _barkod;
//        public string Barkod 
//        { 
//            get 
//            { 
//                return _barkod; 
//            }
//            set
//            {

//            } 
//        }

//set kısmı burada önemli bana deger value ile geliyor 
//benim içeride bir işlem yapmam gerekiyor bunu dilersem bir metot ile yapabilirim dilersem setin içerisinde yapabilirim
//metot ile yapmak daha cok işime geliyor daha merkezi olacak
//set içine yazarsan eğer aynı kodu baska bir yerde kullanmak için kopyala yapıştır yapmak gerekecek metot olursa sadece cagırman yeterli olur 
//peki ben bu metodu nereye yazmalıyım bu işlem ne yapacak
//db de işlem yapacak arama yapacak varsa var yoksa yok diyecek
//peki ben bunu bu class ın içerisinde yaparsam dogru bir işlem mi yapmıs olurum => hayır
//sanaldatabase class ının içerisinde yaparsam dogru bir işlem mi yapmıs olurum => evet 
//neden sanaldatabase içinde yapmalıyım 
//sanaldatabase benim artık o database e özel metotlarımı barındırıyor zaten ve genele acık olmalı

//sanaldatabe e gidip bir metot tasarlamamız lazım

//18. not bitiş

//19. not bitiş sanaldatabse den geldik

//20. not başlangıc

//barkod set alanını guncelleyecegız öncesi

//    private string _barkod;
//        public string Barkod 
//        { 
//            get 
//            { 
//                return _barkod; 
//            }
//            set
//            {

//            } 
//        }

//sonrası


//  private string _barkod;
//        public string Barkod
//        {
//            get
//            {
//                return _barkod;
//            }
//            set
//            {
//                bool kontrolIslemi = SanalDataBase.DbBarkodKontrol(value);
//                if (!kontrolIslemi) // false ise değeri sanaldatabase içinde bulamadım
//                {
//                    _barkod = value;
//                }
//                else
//                {
//                    Console.WriteLine("Sanal database içerisinde bu barkod daha önce girilmiştir.");
//                }

//            }
//        }

//program.cs e gidelim

//20. not bitiş



//*/