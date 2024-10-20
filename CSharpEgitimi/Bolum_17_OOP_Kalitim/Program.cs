﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolum_17_OOP_Kalitim
{
    internal class Program
    {
        //#region VİDEO

        //static void Main(string[] args)
        //{


        //}

        //#endregion

        #region VİDEO 151 Nesne yönelimli programlama dünyasında kalıtım nedir ?

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 17 OOP Kalıtım V151 Nesne yönelimli programlama dünyasında kalıtım nedir ? 

        //    */

        //    /*

        //    1. not başlangıç

        //    Bu bölümde oop de kalıtım konusunu inceleyeceğiz 
        //    bir önceki bölümde innertype demiştik innertype kısmında standart bir nesne olusumunun icerisinde field olarak 
        //    kendi yapmıs oldugumuz nesnelerimizi cagırmaya innertype diyoduk bunu gördük
        //    cok basit bir konu oldugu için cok örnek yapamadık ama kalıtım konusu öyle degil 
        //    kalıtım konusu nesne yönelimli programlamanın tam ortası diyebileceğimiz bir sonraki konunun habercisi olan zorlukta bir konudur 

        //    Nesne Yönelimli Programlama - Kalıtım

        //    Nesne yönelimli programlama içerisinde önemli bir yere sahip bir başka konuya ulaştık.
        //    Konumuz kalıtım veya miras alma da diyebiliriz başka kaynaklar kullanıyorsanız inharance olarak geçebilir

        //    Kalıtım yolu ile oluşturmuş oldugumuz nesnelerimiz birbirlerinden türetilebilir ve türeyen nesne türetilen nesnenin tüm özelliklerini kullanabilir
        //    C# programlama diline başlarken tip dönüşümlerinde tüm nesneleri tanıyan her türden nesneyi kabul eden
        //    - hatta boxing unboxing diye özel video cektigimiz bir object tipi vardı işte bu object tipi ----
        //    object tipinden bahsetmiştik.

        //    Object tipi framework içerisindeki tüm nesnelerin atası olan bir tip olduğu için ( tüm nesneler object nesnesinden kalıtıldığı için ) türetilen tip kendisinden türeyen tüm tipleri tanır ve tam bir uyumluluk sağlar.

        //    Ogrenci O1 = new Ogrenci();

        //    Yukarıda nesne örneği alınan ögrenci nesnesi aslında object tipinden türetilmiş bir nesnedir.

        //    inceleyelim ve sunumumuza devam edelim

        //    kod kısmından devam edelim ..

        //    Ogrenci151 adında bir class olusturalım 

        //    ordan devam edelim 

        //    1. not bitiş

        //    2. not bitiş 

        //    3. not başlangıc

        //    ogrenci yi new leyeceğiz 

        //    Ogrenci151 O1 = new Ogrenci151();

        //    O1. dedigimiz de yazdıgımız field lar geldi ama ek olarak 4 tane de metot geldi 

        //    Equals GetHashCode GetType isim ogrenciId soyisim ToString

        //    peki bu metotlar nası geldi ben bunları yazmadım 
        //    demekki bir yerden ogrenilip geldi buraya 
        //    benım ogrenci nesnemin bu metotları ögrendiği yani miras aldıgı tipimizin adı object

        //    ben bunu nası biliyorum belki object degil 

        //    O1. dedigimiz de yanda tooltype cıkıyor C# programlama dilini ogrenmek istiyorsanız bunlara dikkat etmek okumak gerek

        //    Equals uzerıne geldimiz de bool object.Equals(object obj) yazıyor
        //    bool veri tipi döner 
        //    object. dediği yer object nesnesinin içinden geliyor

        //    mesela ToString metoduna bakalım 

        //    string object.ToString() yazıyor bunu daha sık kullanacagız
        //    geriye string deger dönerim diyor 
        //    object nesnesinin bir metodu olan metot oldugunu () lerden anlıyoruz
        //    metodu olan ToString i seninle paylaşıyorum diyor 

        //    peki bunu nası yapıyor benim ogrenci nesnem orneklenirken .netframework un ana mantıgından yararlanıyor 
        //    gidip object nesnesini alıyor ondan bir kopya alarak kendini türetiyor 
        //    benim içerisine yazmıs oldugum field lar ogrenci nesnesi için konusuyorum field lar metotlar vb tüm işlemler 
        //    aslında bir şablon olarak alınan object nesnesinin üzerinden geçip benım özel tipim haline geliyor

        //    ve ben bu olusturmus oldugum özel tipimi de türetip farklı tipler de kullanabiliyorum 
        //    şimdi slaytımıza geri dönelim bunları zaten detaylı olarak inceleceğiz...

        //    3. not bitiş 

        //    4. not başlangıç - dk 8

        //    Uygulama içerisinde gördüğünüz gibi ögrenci nesnesi aslında bizim olusturdugumuz özel bir tip ama içeride bizim ona yazmdıgımız metotların oldugunu ve bunların object nesnesinden kalıtılma ile geldiğini söyledik.

        //    Kalıtım konusunu biz aslında yine ilişkisel veri tabanı mantıgında ortak değerlere sahip olan alanlarımızı nesnesel olarak modellerken kullanırız.

        //    (Kalıtım konusunu biz aslında yine ilişkisel veri tabanı mantıgını modellerken kendisini tekrar eden field lar metotlar vb işlemleri kullanabilmemiz için bir merkezilik saglayabilmek için ki bunu cok biçimlilik Polymorphism konusunda biraz zor bir konudur orda biraz daha net anlayacagız modelleme için kullanırız biz aslında class ları database içindeki datamıza erişip o datayı c# tarafında kullanabilmek için modelleriz modellediğimiz olan class ı da uygulama içerisinde kullanırız hiç class kullanmasak cok guzel uygulamalar yapamaz mıyız yaparız tabiki ama cok uzun sürer neden uzun sürer herseyi defalarca yazmamız gerekir ama nesne yönelimli programlama da ana amac zaten bir veriyi bir ana noktayı merkezileştirmek merkezileştirip referanslar üzerinden giderek işlemleri alabilmek dolayısıyla kalıtım nesne yönelimli programlanın tam ihtiyacı olan bir konudur.)

        //    C# programlama dilinde olusturmus oldugumuz tüm nesnelerimiz default olarak türetilmeye acık olarak gelmektedir.

        //    istersek olusturmus oldugumuz nesnelerimizin türetilmesini engelleyebiliriz
        //    neden kapama ihtiyacı duyarız bırakalım türesinde diyebiliriz ama 
        //    kendi uygulamamız içerisinde biz bu nesnelerimizi bir anahtar kelime ekleyerek class ın uzerıne kapatmayabiliriz 
        //    fakat uygulamayı dıs programcılara verdigimiz de benim bir kutuphane yazdıgımı dusunun 
        //    public olarak internete dagıttıgımı düşünün yada bir banka entegrasyonu olabilir yada bir 3. parti bir yazılımcı ile kutuphaneyi verip paylaştıgım söz konusu olabilir
        //    ki bunlar olabilir ama nesnemin kullanılmasını istemem aldıgı hatayı benim nesneme atar bir program cıksa anlamazsa işten geri döner nesneyi onla paylaşmam ileride bende güvenlik problemleri olusturabilir cunku kalıtıyorum ve diyorum ki sen bu nesne gibi bir nesne türet bunu istemediğimiz durumlarda nesnemizi kalıtıma kapatmaya geceriz ve baska nesneler tarafından katılmasını engelleriz cok basit bir işlemdir.

        //    Bu bölüm içerisinde erişim belirleyicilerinden internal erişim belirleyecisini inceleyeceğiz

        //    kalıtım konusu önemli bir konu detaylı bakacagız Polymorphism konusuna geldiğimiz de işte orda biraz kafamız karısacak ki kalıtım konusunu net olarak anlamamız buna baglı Polymorphism konuna gectigimiz de bir class daki bir metot bir işlem yaparken aynı class daki aynı isimli aynı metot farklı işlem yapabilecek
        //    çok biçimlilik olacak işte bu nokta da karısmamak için kalıtım konusunu yavas ve detaylı atlatmadan izleyin 


        //    */

        //    /* 3. not kod kısmı baslangıc */

        //    //Ogrenci151 O1 = new Ogrenci151();
        //    //O1.

        //}

        #endregion

        #region VİDEO 152 Kalıtım ile nesne modelleme

        //static void Main(string[] args)
        //{
        //    /*

        //        Bolum 17 OOP Kalıtım V152 Kalıtım ile nesne modelleme

        //    */

        //    /*

        //    1. not başlangıc

        //    bir önceki bölümde kalıtılım ne oldugunu inceleyip slaytlar ile konusmustuk 
        //    ogrenci adında nesne tasarlayıp bunun içerisine bir kaç tane field ekleyip bunu daha da acacagımızı guzellestireceğimizi söylemiştik

        //    Uygulamalarımızın veri tabanlarını olusturacagımız zaman bazen uygulama seviyesindeki bazı ayarların kayıt bazında tutulmasının istenmesinden veya 
        //    uygulamamızın içerisindeki tanımların birbirinin bazı alanlarının aynı olması nedeni ile tablolar aynı kolonları içerebilirler

        //    yazmıs oldugumuz kodlarımız ise veri tabanlarımızdan data alma veya data gönderme temel görevlerini yerine getirebilmek için şemasal olarak database tiplerinin modelleri olarak olusurlar 

        //    OOP'da kalıtım tam bu noktada bize yardımcı olur ve sınıflarımızı tanımlarken merkezi bir mimari ile daha az ve daha merkezli kod yazmamızı sağlar 

        //                                    Personel                        Egitmen                         Ogrenci
        //                                    Id                              Id                              Id
        //                                    ReferansKod                     ReferansKod                     ReferansKod
        //                                    TcKimlikNo                      TcKimlikNo                      TcKimlikNo
        //                                    Isim                            Isim                            Isim
        //                                    SoyIsim                         SoyIsim                         SoyIsim
        //                                    Cinsiyet                        Cinsiyet                        Cinsiyet
        //                                    IsBaslangicTarih                IsBaslangicTarih                Bolum
        //                                    IsBitisTarih                    IsBitisTarih                    Seviye
        //                                    IzinGun                         IzinGun                         KayitTarih
        //                                    KayitTarih                      Brans                           KayitKullanici
        //                                    KayitKullanici                  Seviye                          GuncellemeTarih
        //                                    GuncellemeTarih                 KayitTarih                      GuncellemeKullanici
        //                                    GuncellemeKullanici             KayitKullanici                  Silindi
        //                                    Silindi                         GuncellemeTarih                 
        //                                                                    GuncellemeKullanici             
        //                                                                    Silindi                         

        //    yukarıda bulunan tablo uzerınden gideceğiz Personel Egitmen ve Ogrenci
        //    kendi field leri oldugu gibi ortak olan field lerı var
        //    kalıtım nesnelerimizi database modellerimizi .netframework tarafında modellerken bizim bu ortak özellikleri aldıgımız kısımlarda işimize yarıyor 

        //    şu sekilde bir islevsellik olacak birazdan 
        //    Solutions içerisine eklemiş oldugumun console uygulamasında ki ogrenci nesnesinin içerisindeki field ları bosaltıp daha sonra diger entityleri de olusturup
        //    personel ve egitmen class larını da olusturup burada ki modeli .netframework ortamına tasıyacagız

        //    peki biz neden bu sekılde tablo yapıları kullanırız 

        //    personel egitmen ogrenci adında 3 farklı tablom var bunların 3 nun de kendı ortaklarında kesismiş oldugu field lar var 
        //    uygulamarımız veri tabanlarını olusturacagımız zaman bazen uygulama seviyesinde bazen de kayıt bazında biz bu dataların tutulmasını isteriz

        //    burda kayıt bazında tutulma söz konusu uygulama bazında olsaydı buraya bir tablo tipi ve tablonun referansid ve kodunu alarakta bu işlemi çözebilirdim 
        //    ama o zaman daha bir ilişkiselliğe dogru gidiyor 
        //    bu tamamiyle database tasarımcısının tasarımcı sizseniz sizin o uygulamanın içerisine adam bolu maliyete göre degisebiliyor 

        //    ama her halukarda ne kadar ilişkisel tabloları kucultup kucultup kullansakta .netframework içerisinde biz onu bir nesne olarak cekmek istediğimiz de kalıtım konusunu kullanıyoruz 

        //    yazmıs oldugumuz kodlarımız veritabanın dan data alınım veya data gönderme en temel gorevlerı bunları yerine getirebilmek için semasal olarak database tiplerinin modellerini olustururlar bizde bu dersimiz de bu modelleri olusturup daha sonraki derslerimiz de de kalıtımın detaylarına iniyor olacagız 

        //    Ogrenci152 Personel152 Egitmen152 class larını olusturalım 

        //    hepsini olusturup hepsini public yaptık ve olusturmus oldugumuz class larımız kendi içerisinde bir baska class a ihtiyac duyacaklar
        //    benim en temel anlamda bir tip olusturmam ve olusturmus oldugum tipin içerisinde de ortak seviyede denk gelen field ları kullanabilmem lazım

        //    3 nesnemizinden türemesini istediğimiz ortak class ımızı olusturup ortak olanları bu class içine yazalım 
        //    TemelTip adında baska bir class olusturalım normalde bu BaseType BaseClass olarak gecer egitim anlasılsın diye boyle isimlendirdik

        //    TemelTip içerine gidip ortak field larımızı olusturalım

        //    1. not bitiş

        //    3. not bitiş

        //    4. not baslangıc

        //    Egitmen class ını new leyerek bakalım TemelTip class ını almıs mı 
        //    Egitmen152 E1 = new Egitmen152();
        //    E1. dedigimiz de temeltip içindeki bütün field lar gelmıs görüyoruz

        //    eger ben bunu innertype olarak yapmıs olsaydım E1.TemelTip. gibi gitmem gerekirdi

        //    Egitmen class ına gidip oradaki field ları olusturalım

        //    4. not bitiş

        //    5. not bitiş

        //    6. not baslangıc

        //    program.cs de 
        //    E1. dedigimiz de artık Egitmen içerisine yazdıgımız 2 field da cıkıyor karsımıza 
        //    tooltype okumanın onemınden bahsetmiştik
        //    E1. dedigimiz de Brans ın uzerıne gelince 
        //    string tipinde Egitmen152.Brans olarak gozukuyor
        //    Cinsiyet e baktıgımız da temeltip içerisinden geldiğini yani kalıtımdan gelmiş
        //    int deger aldıgını get ve set bloklarını okunabilir ve yazılabilir oldugunu anlıyoruz

        //    personel nesnesine gidelim

        //    6. not bitiş

        //    8. not bitiş

        //    9. not baslangıc

        //    egitmen den geldik

        //    ben burda egitmen E1. diyip temeltipe ulasabildiğim gibi
        //    personel uzerınden de p1. diyip temeltipe ulasabiliyorum

        //    ogrenci class ına gidelim

        //    9. not bitiş 

        //    */

        //    Egitmen152 E1 = new Egitmen152();
        //    //E1.

        //    Personel152 P1 = new Personel152();
        //    //P1.

        //}

        #endregion






    }
}
