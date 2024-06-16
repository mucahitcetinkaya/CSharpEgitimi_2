//using System;

//namespace Bolum_13_OOP_Siniflar
//{
//    public class Arac126
//    {
//        public string Marka;
//        public string Model;
//        public int ModelYil;
//        public decimal KM;
//        public int YakitTip;
//        public int VitesTip;
//        public decimal AlisFiyat;
//        public decimal SatisFiyat;
//        public decimal MaxIndirimTutar;
//        public decimal Fiyat;

//        public Arac126()
//        {

//        }

//        public Arac126(string _marka, string _model)
//        {
//            Marka = _marka;
//            Model = _model;
//        }

//        public Arac126(string _marka, string _model, int _modelYil)
//        {
//            Marka = _marka;
//            Model = _model;
//            ModelYil = _modelYil;
//        }

//        public Arac126(string _marka, string _model, int _modelYil, decimal _km)
//        {
//            Marka = _marka;
//            Model = _model;
//            ModelYil = _modelYil;
//            this.KM = _km;
//        }

//        public void BilgileriGoruntule()
//        {
//            Console.WriteLine("Marka {0} - Model {1} - Model Yil {2}", Marka , Model , ModelYil);
//        }

//        public void FiyatAta(decimal _fiyat)
//        {
//            decimal fiyatHesap = SatisFiyat - MaxIndirimTutar;

//            if (_fiyat < fiyatHesap)
//            {
//                Console.WriteLine("Geçersiz fiyat girişi");
//            }
//            else
//            {
//                this.Fiyat = _fiyat;
//                Console.WriteLine("Fiyat güncellendi.");
//            }

//        }

//    }

//}


///*

//1. not baslangıc 

//gerekli alanları doldurduk ctor ları ayarladık metotları yazdık
//this kullanımına baktık

//Program.cs e gidelim
 
//1. not bitiş



//*/