//using System;

//namespace Bolum_14_OOP_Kapsulleme
//{
//    internal class Musteri130
//    {

//        private string _tcKimlikNumarasi;

//        public string TcKimlikNumarasi 
//        {
//            get { return _tcKimlikNumarasi.Substring(0, 3); }
//            set {

//                if (value.Length == 11)
//                {
//                    bool bayrak = false;
//                    for (int i = 0; i < value.Length; i++)
//                    {
//                        bool karakterKontrol = char.IsNumber(value[i]);
//                        if (karakterKontrol) { }
//                        else
//                        {
//                            bayrak = true;
//                            break;
//                        }
//                    }
//                    if (bayrak) 
//                    {
//                        Console.WriteLine("TC Kimlik Numarası içindeki değerler sayısal olmalıdır...");
//                    }
//                    else
//                    {
//                        this._tcKimlikNumarasi = value;
//                    }

//                }
//                else
//                {
//                    Console.WriteLine("TC Kimlik Numarası 11 hane olmalıdır...");
//                }

            
//            }
//        }


//    }
//}




///*
 
 
//hocanın yaptıgı 

//private field tanımladık 
//prop tanımladık set kısmı private olan

//get return geriye deger dönen kısım
//set işlemlerın oldugu kısım

//string yapmamızın nedeni Lenght geriye string döner Lenght i kullanabilmek
//için string yazdık

//value nun uzunlugu 11 e eşitse 
//bir tane bool olusturduk bunu kontrol için yazıyoruz sadece
//for ile value nun uzunlugu kadar içinde dönecegız

//char.IsNumber her value nun i nin degerine bakıyor numara mı diye tek tek
//numaraysa devam ediyor sorun yok 
//degilse bayrak true oluyo break ile dönguden cıkıyor

//gelen deger içinde sayı degilde harf yazınca döngude ona geldıgınde sıra artık hangi index e yazdıysak false gelir

//bayrak false olur break ile kırılır dönguden cıkar

//eger bayrak true ise

//ekrana hata yazdırır sayısal olmalıdır


//diger istenilen get olmasın kısmı private yazdık zaten atama yaptıgımız da cıkmaz 

//ilk 3 hanesini gösterelim kısmı

//get kısmında degisiklik yaparız

//önceden böyleydi

//            private get { return _tcKimlikNumarasi; }

//sonradan böyle oldu

//            get { return _tcKimlikNumarasi.Substring(0, 3); }

//private kısmı kaldırıldı Substring ile 0 dan basla 3 karakter göster demiş olduk

//burda konulardan 

//field deger ataması yapılsın ama okunamasın kısmını yapmıs olduk
//field deger ataması yapılsın ama degerin ilk 3 hanesi okunsun yapmıs olduk

//sonraki video da 

//field deger ataması ve okuma işlemleri yapılsın ama bu iki işlemde bizim belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin




// chatgpt nin yaptıgı

//using System;

//namespace Bolum_14_OOP_Kapsulleme
//{
//    internal class Musteri130
//    {

//        private string _tcKimlikNumarasi;

//        public string TcKimlikNumarasi
//        {

//            get {

//                if (_tcKimlikNumarasi.Length == 11)
//                {
//                    return _tcKimlikNumarasi.Substring(0, 3) + new string('*', 8);
//                }
//                return "Geçersiz Tc Kimlik Numarası";

//            }
//            set {

//                if (value.Length == 11 && long.TryParse(value, out _))
//                {
//                    _tcKimlikNumarasi = value;
//                }
//                else
//                {
//                    throw new ArgumentException("TC Kimlik numarası 11 haneli olmalı ve sayısal değer içermelidir.");
//                }


//            }


//        }

//    }
//}
 
 
//*/