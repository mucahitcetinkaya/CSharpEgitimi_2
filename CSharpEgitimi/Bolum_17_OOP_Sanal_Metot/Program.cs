﻿
using System;

namespace Bolum_17_OOP_Sanal_Metot
{
    internal class Program
    {
        //#region VİDEO

        //static void Main(string[] args)
        //{


        //}

        //#endregion

        #region VİDEO 151 Nesne yönelimli programlama dünyasında sanal metot nedir ?

        //static void Main(string[] args)
        //{
        //    /*

        //    Bolum 17 OOP Sanal Metot V151 Nesne yönelimli programlama dünyasında sanal metot nedir ?
        //    Çok Biçimlilik Sanal Metot Kullanımı

        //    Bir önceki bölümde kalıtım konusunu inceledik bunla alakalı aslında diğer bolumleri de kapsayan bir uygulama yapmıştık.

        //    Şimdi çok biçimlilik konusunda sanal metot nedir ve polimorphszm içerisinde sanal metot nası kullanılır kısmını incelemeye çalışacagız

        //    Sanal Metotlar

        //    Bir önceki bölüm içerisinde kalıtım konusunu inceledik. Hatırlarsanız kalıtım içerisinde kalıtılan sınıf kendisini kalıtan sınıfa içerisindeki private metotlar haricinde bulunan tüm metotları kullanım izni sunmaktaydı.

        //    Örnek olarak baseClass adında bulunan sınıfımızı urun sınıfı kalıttığı zaman baseClass içerisinde bulunan metotlara ve özelliklere erişebiliyor baseClass içerisindeki tanımları gibi kullanabiliyordu.

        //    BaseClass içerisinde ekrana yaz adında bir metot olsa urun sınıfı içerisinde ekrana yaz metotu çağrıldığı zaman baseClass içerisinde bulunan şekli ile çalışıp metot işlemini tamamlayabiliyordu.

        //    Sanal metot dediğimiz bu bölümümüz de baseclass içerisinde bulunan bir metotun istenilirse türeyen sınıf içerisinde nasıl yeniden şekillenebileceğini inceleyeceğiz.

        //    Kalıtım konusunda tüm nesnelerin object nesnesinden kalıtıldığını ve bazı metotların object nesnesinden bize geldiğini söylemiştik.

        //    Birazdan sanal metot anlatımına object içerisinde bize standart olarak gelen tostring metotunu inceleyerek başlayacagız

        //    Sanal metotları X-men filminde bulunan mystique karakterine benzetebilirsiniz.

        //    Ortama göre kendi şeklini değiştirebilen bir karakter olması buna örnek olabilir.

        //    */

        //}

        #endregion

        #region VİDEO 152 object nesnesinden gelen ToString metotunu inceleyelim.

        //static void Main(string[] args)
        //{
        //    /*

        //    Bolum 17 OOP Sanal Metot V152 object nesnesinden gelen ToString metotunu inceleyelim.

        //    */

        //    /*
            
        //    1. not başlangıç

        //    şimdi tostring metotu ile sanal metotları tanımaya baslayalım

        //    kalıtım da bütün nesnelerin object ten türediğini söylemiştik

        //    object ten gelen de bazı metotların oldugunu soylemıstık mesela ToString() gibi
        //    calısmasından bahsedelim sonrada debug edecegız

        //    nesnelerimizi ornekledıgımız zaman yanı
        //    Musteri M = new Musteri();
        //    benım musteri nesnem object nesnesınden kalıtıyor ve olusuyor
        //    nesne olustugunda da object ile birlikte bazı metotlar ile birlikte geliyordu
        //    hiç bişey olusturmadan sadece new ledıgımızde 
        //    M. dedıgımızde karsımıza cıkan metotlar bunlar
        //    M.ToString(); gibi yanı musteri nesnesinde olmayan bir metoda erısmıs oluyordum objectin içerisinden bana kalıtım yoluyla geliyordu

        //    tostring metotunun kendıne ozgu bir calısma seklı var
        //    cagırdıgımız da cagrılan class ın namespace ve adını geriye döner 
        //    Bolum_17_OOP_Sanal_Metot.Musteri gibi
        //    bu .net framework içerisinde standart kullanım şekli
        //    m.tostring dedıgımde namespace ve class adını geriye doner
        //    string olarak doner konsola yazdırabiliriz

        //    object nesnesine gelen bu tostring metodu sanal bir metot yanı ben bu metodun body sini degistirebilirim
        //    namespace.musteri olarak gelme de benım yazdıgım koda göre gel diyebiliriz

        //    buda tam olarak sanal metotun acıklaması oluyor

        //    musteri nesnesi olusturalım nesnemizi ornekleyip cagıralım namespace.class adını geldıgını gorelım ve nası degistiririz onu görelım

        //    Musteri classına gidelim

        //    1. not bitiş
            
        //    2. not bitiş

        //    3. not başlangıç

        //    3 adet prob ekledik musteriye şimdi new leyelim
        //    V152Musteri M1 = new V152Musteri();
        //    M1. dedigimiz de içeriye eklediğimiz 3 adet prob ve ek olarak farklı sınıf lar geldi bunlar object metotunun içerisinden geldi
        //    //M1.Equals
        //    //M1.GetHashCode
        //    //M1.GetType
        //    //M1.ToString
        //    //M1.musteriID
        //    //M1.isim
        //    //M1.soyisim

        //    tostring için bakalım

        //    m1.tostring dedik bunu string üzerine aldık => string toStringMesaj = M1.ToString();

        //    sonrada cıkan degeri konsola yazdırdık => Console.WriteLine("toStringMesaj : " + toStringMesaj);

        //    kosola ne gelmesi lazım ? namespace.class adı gelmesi lazım

        //    console.writeline a breakpoint koy calıstır

        //    çıktısı

        //    toStringMesaj : Bolum_17_OOP_Sanal_Metot.V152Musteri

        //    bu sanal metotların ana davrasını oluyor bunların body sini degistirmekten bahsettik

        //    musteri class ına gidip tostring metotunu degistirelim

        //    3. not bitiş

        //    4. not bitiş

        //    5. not baslangıc

        //    override etmeden once debug yaparken tostring in içine f11 ile gidemedik sanal metot cunku
        //    musteri class ının ıcınde bunu guncelledık buraya geldik tekrar debug yapalım bakalım ne olacak
        //    isim soyisim yaptıgımız için birde atama yapalım bos gelmesin
        //    calıstırınca f11 ile devam edince musteri class ına gönderiyor ve override ettıgımız yere dusuyor kod 
            
        //    override ettıgım gibi calısıyor kendı calısma mantıgı olarak calısmıyor 

        //    ders bitti diger derste kendımız sanal metot olusturalım kalıtmıs oldugumuz nesnemizin içerisinde nası kullanırız bunlara bakalım
             
        //    */

        //    // 3. not

        //    V152Musteri M1 = new V152Musteri();
        //    M1.isim = "Mücahit";
        //    M1.soyisim = "Çetinkaya";
        //    string toStringMesaj = M1.ToString();


        //    Console.WriteLine("toStringMesaj : " + toStringMesaj);


        //}

        #endregion


    }
}
