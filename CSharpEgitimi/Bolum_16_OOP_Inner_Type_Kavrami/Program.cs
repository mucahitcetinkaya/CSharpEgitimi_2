using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolum_16_OOP_Inner_Type_Kavrami
{
    internal class Program
    {

        //#region VIDEO

        //static void Main(string[] args)
        //{

        //}

        //#endregion

        #region VIDEO 144 Bilgilendirme

        //static void Main(string[] args)
        //{
        //    /*

        //     Bolum 16 OOP Inner Type Kavrami V144 Bilgilendirme

        //    */

        //    /*

        //    1. not başlangıç 

        //    OOP - Inner Type

        //    Nesne yönelimli programlama - İç içe nesne kullanımı

        //    Bu bölümde nesne yönelimli programlama da inner type nedir bunu inceleyeceğiz

        //    Bu bölüm içerisinde aşağıdaki konular ele alınacaktır.

        //    Inner Type Nedir ?

        //    Neden Kullanılır ? Bir ihtiyaç mıdır ?

        //    Örnekler ile innertype kullanımı

        //    Bölüm sonu uygulaması

        //    Nesne yönelimli programlama konusunda sık kullandıgımız bir tanımlama olan ınnertype olarak isimlendirdiğimiz iç içe nesne kullanımı konusuna geldik.
        //    Aslında bu zamana kadar da bilinçsiz bir şekilde kullanıdıgımız bir kavramdı sistemin tiplerini kendi özel tiplerimizin içerisinde kullandıgımızda da 
        //    aslında bir innertype yapıyoduk nedeni .netframework zaten genel olarak bir class mimarisi üzerine kurulu 
        //    kendi veri tipleri de arka tarafta class olarak barınmakta.

        //    bundan dolayı class içerisinde class kullanmak innertype ın tam karsılıgıdır

        //    innertype nedir neden kullanırız 

        //    innertype i kullandıgımız yerler ilişkisel veri tabanı modellerimizi uygulama katmanında örnekleyebilmek datamızı daha dogru daha okunabilir 
        //    şekilde tek bir class içerisinde toparlayabilme isteğimizdir
        //    yazmıs oldugumuz uygulamalarımız da bir musteri dediğimiz zaman aslında o musterinin bir cok farklı ozellıgıni database tarafında 
        //    ilişkisel tablo duzeyınde dagınık bir şekilde tuttugumuz için bunun C# programlama tarafında ise yine dagınık bir şekilde olan nesneleri 
        //    tek bir nesnenin içerisine toparlayarak datayı bir bütün olarak elde ederiz 

        //    tabiki ilişkisel veri tabanını bilen arkadaslarımız oldugu gibi bilmeyen arkadaslarımız da vardır 
        //    ilişkisel veri tabanından biraz bahsetmek gerekirse aslında şudur 

        //    örnek olarak bir Musteri tanımına geldiğimiz de 
        //    musterimizin id si ismi soyismi bize ne zaman kayıt oldugu iletişim bilgileri ve bizden yapmıs oldugu alısverişlerin bir listesi 
        //    aklımıza en basit sekilde gelenlerdir

        //    biz bunu ilişkisel veri tabanı dedıgımız mantıkla dagıtacak olursak 
        //    Oncelıkle musteri nesnesi olusturmak gerekiyor 
        //    musterinin id si olur id uniqe tir ve bir tane olur bunu int olarak tutabiliriz
        //    isim ve soyisim degerleri de o musteriye ait tekil degerlerdir string olarak tutulabilir
        //    musterinin database e kayıt tarihi datetime tipindedir
        //    peki musterinin adres bilgisi
        //    musterinin bir cok adresi olabilir
        //    ev iş veya birden fazla da iş adresleri olabilir yani bir adresleri olabilir

        //    bundan dolayı adreslerini farklı bir data kumesı üzerinde tutmak isterim 

        //    burda adres bilgileri yer alır 
        //    adresin tanımı
        //    il ilçe mahalle vs 
        //    ve adresin kendisi 

        //    burası 1 e n bir yapıda olur yani
        //    1 müşterinin n tane adresi olabilir 

        //    aynı sekılde iletişim bilgileri de bu sekildedir
        //    cep mi ev mi iş mi 
        //    dahili numarası vs 

        //    sımdı ben bunların hepsini musteri nesnemin içerisinde toparlamak istersem 

        //    Musteri class ının içinde 1 den fazla adres olabilmesi için bir arraylist adres tipinde tutabilirim
        //    Musteri class ının içinde 1 den fazla iletişim olabilmesi için bir arraylist iletişim tipinde tutabilirim

        //    su an arraylist i bildiğimiz için arraylist diyorum
        //    ilerleyen konularda list generic anlatıldıgın da bu arraylist lerin hepsi list generic olacak 

        //    bir dizi yani bir koleksiyon içeriye atmam gerekiyor 
        //    koleksiyonun içericeği deger Adres tipi Iletisim tipi olmalı 

        //    Musteri içerisinde olusturdugumuz Custom nesnelerimizi cagırdıgımız zaman 
        //    nesne içindeki nesneyi
        //    aslında bir innertype yapmıs oluyoruz 

        //    ben Musteri nesnesine odaklandıgım da musterinin ve musterinin içerisinde bulunan
        //    adres ve iletişim bilgilerinden yararlanarak musterinin tum datasına erişip
        //    uygulama katmanında kullanabilirim
        //    nesne yönlü programlama da gerçek hayatta innertype lar standart olarak kullanılır 
        //    tek basına bir nesnenin kullanılması cok dusuk bir ihtimaldir

        //    nası bir ihtimal olur il ilçe gibi il ilçe mahalle gibi
        //    veya bazı standart tanımlar nesne tekil olarak hiç bir farklı ozel nesneye ihtiyac duymadan cagrılıp kullanılabilir
        //    ama musterı kullanıcı urun ve benzeri openasyonel surecler içerisinde yaptıgımız ve kullandıgımız nesnelerimiz
        //    tamamiyle kendi içlerinde iç nesneler yani innertype lar barındırır

        //    -------------------------------

        //    Bir ihtiyaç mıdır ?

        //    evet anlatmıs oldugum openasyonel işlemler de bir ihtiyactır 
        //    database iniz de farklı tablolar uzerınde duran datalarımızı birleştirmeye yarayan bir tanımdır 

        //    database bolumune gectiğimiz de ilişkisel veri tabanı konusunu detaylı olarak anlatacagım 
        //    bu noktada bir veri kumesını parcalarayak tablolama olarak bilmenız yeterli 

        //    */

        //}

        #endregion

        #region VIDEO 145-146 Inner Type Modelleme - 1 - 2

        //static void Main(string[] args)
        //{

        //    /*
             
        //     Bolum 16 OOP Inner Type Kavrami V145 - V146 Inner Type Modelleme - 1 - 2
             
             
        //    */

        //    /*
             
        //    1. not baslangıc
            
        //    Once ne yapmak istiyoruz Musteri nesnesine ihtiyacımız var onu olusturalım 
        //    Musteri145 olacak

        //    Musteri145 e gidip orda devam edelim

        //    1. not bitiş

        //    7. not bitiş

        //    8. not baslangıc

        //    Musteri145 i ornekleyelim

        //    145 ve 146. videolar ortak oldu surelerı kısa oldugu için 
        //    147. video uzun olacak ornekleme ve devam etme anlatma metotlar vs olacak ordan devam edelim
             
        //    */

        //    Musteri145 M1 = new Musteri145();

        //}

        #endregion





    }
}
