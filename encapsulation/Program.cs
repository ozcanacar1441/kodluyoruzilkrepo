using System;

namespace encapsulation // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Öğrenci ogrenci=new Öğrenci();
            ogrenci.Isim="Ayşe";
            ogrenci.Soyisim="Yılmaz";
            ogrenci.OgrenciNo=293;
            ogrenci.Sinif=3;
            ogrenci.ogrenciBilgileriniGetir();
            ogrenci.SinifAtlat();
            ogrenci.ogrenciBilgileriniGetir();
            Öğrenci ogrenci1=new Öğrenci("Deniz","Arda",256,1);
            ogrenci1.SinifDüşür();
            ogrenci1.SinifDüşür();
            ogrenci1.ogrenciBilgileriniGetir();

        }
    }
    class Öğrenci
    {
         private string isim;
         private string soyisim;
         private int ogrenciNo;
         private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { get => sinif;
         set {
             if(value<1)
             {
                 Console.WriteLine("Sınıf en düşük 1 olabilir");
                 sinif=1;
             }
             else
             sinif=value;
         } 
        }

        public Öğrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Öğrenci(){}
        public void ogrenciBilgileriniGetir(){
            Console.WriteLine("******Öğrenci Bilgileri*******");
            Console.WriteLine("Öğrenci adı     :{0}",this.Isim);
            Console.WriteLine("Öğrenci soyadı  :{0}",this.Soyisim);
            Console.WriteLine("Öğrenci no      :{0}",this.OgrenciNo);
            Console.WriteLine("Öğrenci sınıfı  :{0}",this.Sinif);

        }
        public void SinifAtlat(){
            this.Sinif=this.Sinif+1;


        }
        public void SinifDüşür(){
            this.Sinif=this.Sinif-1;

        }

    }
}