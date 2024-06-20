//using System;

//namespace Bolum_14_OOP_Kapsulleme
//{
//    internal class Musteri129
//    {
//        public Musteri129()
//        {
//            this.idField = IdUret();
//        }

//        private int idField;

//        public int idProp {
//            get
//            {
//                return this.idField;
//            } 
//            private set
//            {
//                this.idField = value;
//            }
//        }

//        public string isim;
//        public string soyIsim;
//        public string eMailAdresField;
//        public string EmailAdresProp { get; set; }

//        private int IdUret()
//        {
//            Random random = new Random();
//            return random.Next(10000, 90000);
//        }


//    }
//}





///*

//1. not bitiş

//2. not baslangıc

//        // 2. not baslangıc

//        // Class => Field

//        public int id;

//        public string isim;
//        public string soyIsim;


//        // Class => Property prop tab tab

//        public string eMailAdresField;

//        public string EmailAdresProp { get; set; }

//benim id yi class ın içinde saklamam lazım
//property bunun önüne gecsin
//arkada private olarak saklamıs oldugum 
//field a degeri kontrollu bir sekilde verebilelim ve alabilelim
//emailadresinde oldugu gibi gecen derste

//eger herhangi bir erişim belirleyicisi yazmazsan
//defult olarak private olarak gecer
//onune private olarak da yazabilirsin aynı sey

//        int id;

//        private int id;

//Program.cs e gidip Musteri129 u newleyerek alanları nı dolduralım

//2. not bitiş

//3. not bitiş

//4. not baslangıc

//public olarak ıd olusturalım

//         private int idField;

//        public int idProp {
//            get
//            {

//            } 
//            set
//            {

//            }
//        }

//get bloklarında
//içeride private olarak saklamıs oldugum degerimi 
//property yardımıyla onu cagıran kot parcasına gönderiyorum
//içerideki private field in degerini alıp propperty yardımıyla 
//onu cagıran koda gönderiyorum
//amacım neydi kod okunabilsin ama degistirilme olmasın set edilemesin

//public int idProp {
//            get
//            {
//                return this.idField;
//            } 
//            set
//            {

//            }
//        }

//                return this.idField;
//yazarak field a gönderim yaptım

//burda benim isteğime göre işlem yapmam gereken yer set blokları

//şimdi set bloklarında bir tekrar yapalım
//hatırlarsanız biz müdahale etmesekte calısan bir yapı var demıstik

//constructor ctor tab tab yapıcı metot

//class ımın yapıcı metodunu neden modifiye etme geregı duydum onu birazdan anlatacagız

//set bloklarında veya ctor da bir işlem yapmammız lazım
//neden
//bir işlem olacak ki benim id degerim bir yerden deger okusun
//ve onu da içeride ki field ıma yazsın

//set bloguna atama yapalım

//        public int idProp {
//            get
//            {
//                return this.idField;
//            } 
//            set
//            {
//                this.idField = value;
//            }
//        }

//üretilecek olan metodu yapıcı metotta cagıracagız

//yapıcı metoda diyecegiz ki bu nesne örneklendıgı zaman sen git
//bir metot yardımıyla bir deger üret
//ürettiğin degeri içeride private olarak duran
//field in içerisine ata genel görevin bu

//yapıcı metot zaten class calısırken default olarak calısacak
//benim vermiş oldugum kurala göre bir yerden deger ogrenecek
//ögrenmıs oldugu degeri içeride private olarak saklamıs oldugum 
//field in içerisine atayacak ana görevi bu

//bir metot yazalım private olacak

//        private int IdUret()
//        {
//            Random random = new Random();
//            return random.Next(10000, 90000);
//        }

//random nesnesini new ledik
//next ile yeni bir sayı ürettirdik

//nesne orneklendıgın de yapıcı metot calısacak
//yapıcı metot calısırken içeride private olarak saklamıs oldugum
//field ıma deger ataması yapacagım

//peki ben private field a ulasmak için property uzerınden mı gitmeliyim
//hayır gerek yok
//neden property class ın dısarısındaki alanlar için gerekli 
//ben zaten class ın ıcerısındeyım su anda private olsada buna erişebiliyorum

//        public Musteri129()
//        {
//            this.idField = IdUret();
//        }

//boyle yazabiliyoruz

//peki set kısmı noldu orası bosa cıktı onu kullanmayacagız

//neden

//cunku ben dısarıdan bir deger set edilebilsin istemiyorum sadece okunsun istiyorum

//önce inceleyelim sonra set kısmını iptal edelim

//program.cs e gidelim

//4. not bitiş
//5. not bitiş

//6. not baslangıc

//F11 ile buraya geldık yapıcı metot calıstı
//burası önemli neden yapıcı metotta iken ben id e deger ataması yapacagım

//this.idField benim içeride private olarak saklamıs oldugum field ım 

//bu field kendısıne IdUret adındaki bir metottan alacak bu metotta private
//F11 ile devam ettim metota gitti random olarak id uretti yapıcı metota geri döndu
//bir deger ataması yaptı devam edince Program.cs e gidecek

//6. not bitiş

//7. not bitiş

//8. not baslangıc

//get kısmına dustu kod console kısmında 
//Musteri129 un içindeki 
//IdProp un get kısmındayız

//get private olarak saklamıs oldugum alandan degeri cekiyor
//return this idField içerideki degeri dıs dunyaya return et diyor

//devam edince ekrana yazdıracak Program.cs e gidiyor kod 

//8. not bitiş

//9. not bitiş

//10. not baslangıc

//ne yapabiliriz
//set kısmına bişey yazmayız set edilmesini onlerız
//işe yarar ama böyle yapmıyoruz
//bizim amacımız içeride olan lojic i kapatmak
//kodu kapatmak degil

//tek bir dokunusla o lojic i acıp kapama işlemini yapabilmem gerekiyor

//peki property nin ana amacı neydi
//dıs dunya ile baglantı
//yanı get ve set blokları aslında public
//yanı dıs dunyaya acık demek public 
//ben bunlardan birinin kullanılmasını istemiyorsam
//kullanılmasını istemediğimizi private yapmam yeterli

//set blogunun kullanılmasını istemiyorum o zaman private yaparım

//        public int idProp {
//            get
//            {
//                return this.idField;
//            } 
//            private set
//            {
//                this.idField = value;
//            }
//        }

//kayıt edip program.cs e gidince idprob a deger atadıgım kısım hata verecek

//10. not bitiş
 
//*/