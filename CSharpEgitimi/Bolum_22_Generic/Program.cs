using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolum_22_Generic
{
    internal class Program
    {
        //#region VİDEO

        //static void Main(string[] args)
        //{


        //}

        //#endregion

        #region VİDEO 177 Generic sınıflar ne degildir

        //static void Main(string[] args)
        //{

        //    /*

        //        Bolum 22 Generic V177 Generic sınıflar ne degildir

        //    */

        //    /*
            
        //    1. not baslangıc

        //    generic olmayan ve olan olarak 2 farklı sekılde bir anlatım yapacagız farklarına bakacagız

        //    Musteri class ı acalım 

        //    1. not bitiş

        //    2. not bitiş musteri den geldik

        //    3. not baslangıc

        //    Musteri i new leyelim ve problarını dolduralım

        //    //3. not baslangıc

        //    V177Musteri M1 = new V177Musteri();
        //    M1.ID = 1;
        //    M1.TcKimlikNo = "12254401254";
        //    M1.MusteriNo = "MS123";
        //    M1.Isim = "Mücahit";
        //    M1.SoyIsim = "Çetinkaya";
        //    M1.DogumTarihi = DateTime.Parse("13-06-1994");

        //    gerekli alanlarını doldurduk

        //    generic olmayan bir class tanımı yaptık generic class lar kısmını size anlatabilmem için bir senaryodan bahsetmem gerekiyor
        //    standart anlatımda su sekılde bahsedilir

        //    bir Musteri class ı olusturduk id degeri int ben bunu GUID olarak runtime da almak istersem şöyle yapmalıyım
        //    MusteriNo string ama biz bunu generic yapalım Runtime a göre değişsin her an musteri no tipi değişebilir gibi 

        //    orneklerle de generic class lar anlatılabiliyor gercek hatayı tam olarak yansıtmıyor

        //    oncelıkle yansıtmayan halini inceleyelim once onu anlayalım ki gercek hayattaki konularına sizi cekebileyim

        //    şimdi de MusteriGeneric class ını olusturalım ve bakalım

        //    3. not bitiş
            
        //    4. not bitiş musterigeneric ten geldik

        //    5. not baslangıc

        //    MusteriGeneric i newleyelim ve bakalım duruma

        //                //5. not baslangıc

        //    V177MusteriGeneric<int> M2 = new V177MusteriGeneric<int>();
        //    M2.ID = 1;

        //    new lerken ne veri tipi verirsek prob lara verdiğimiz T tipi de o tipi alıyor
        //    int verdik id de T tipi id int oldu

        //    V177MusteriGeneric<Guid> M3 = new V177MusteriGeneric<Guid>();
        //    M3.ID = Guid.NewGuid();

        //    guid verdik id t tipinden guid oldu

        //    MusteriGeneric e gidip bir metot olusturalım

        //    5. not bitiş

        //    6. not bitiş musterigeneric ten geldik
             
        //    7. not baslangıc

        //    metot için bir newleme yapalım

        //    V177MusteriGeneric<Guid> M4 = new V177MusteriGeneric<Guid>();
        //    M3.MusteriNumarasiAl();

        //    parametre almam ve geriye guid dönerim diyor generic ve t tipinden guid verdik onu alıyor

        //    int için bu metodu cagırınca int dönerim diyor

        //    M2.MusteriNumarasiAl();

        //    yanlıs anlasılan kısımı anlatmak için musterigeneric e gidelim

        //    7. not bitiş
            
        //    8. not bitiş musterigeneric ten geldik

        //    9. not baslangıc

        //    bu derste generic class ların mantıgnı gorduk fakat kullanma yontemi bu degil diger derste katmanlı mimari ile ogrenecegız

             
        //    */

        //    //3. not baslangıc

        //    V177Musteri M1 = new V177Musteri();
        //    M1.ID = 1;
        //    M1.TcKimlikNo = "12254401254";
        //    M1.MusteriNo = "MS123";
        //    M1.Isim = "Mücahit";
        //    M1.SoyIsim = "Çetinkaya";
        //    M1.DogumTarihi = DateTime.Parse("13-06-1994");

        //    //5. not baslangıc

        //    V177MusteriGeneric<int> M2 = new V177MusteriGeneric<int>();
        //    M2.ID = 1;

        //    V177MusteriGeneric<Guid> M3 = new V177MusteriGeneric<Guid>();
        //    M3.ID = Guid.NewGuid();

        //    //7. not baslangıc

        //    V177MusteriGeneric<Guid> M4 = new V177MusteriGeneric<Guid>();
        //    M3.MusteriNumarasiAl();

        //    M2.MusteriNumarasiAl();

        //}

        #endregion


    }
}
