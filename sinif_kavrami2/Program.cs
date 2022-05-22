using System;

namespace sinif_kavrami // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Söz Dizini
            //class{
           //         [Erişim belirleyici][veri tipi]Özellik adı;
           //         [Erişim belirleyici][geri dönüş tipi] Metod Adı([Parametre Listesi])    {
           //               Metot komutları    
          //            }
           //       }
            //Erişim belirleyiciler
            //*Public
            //*Private
            //*internal
            //*Protected
            Console.WriteLine("**********Çalışan1************");
            Calisan calisan1=new Calisan("Ayşe","Kara",23425634,"İnsan Kaynakları");
            calisan1.CalisanBilgileri();
            Console.WriteLine("**********Çalışan2************");
            Calisan calisan2=new Calisan();
            calisan2.Ad="Deniz";
            calisan2.soyAd="Arda";
            calisan2.No=25646789;
            calisan2.Departman="Satın Alma";
            calisan2.CalisanBilgileri();
            Console.WriteLine("**********Çalışan3************");
             Calisan calisan3=new Calisan("Özcan","Acar");
             calisan3.CalisanBilgileri();


        }
    }
    class Calisan
    {
        public string Ad;
        public string soyAd;
        public int No;
        public string Departman;

        public Calisan(string ad,string soyad,int no,string departman)
        {
            this.Ad=ad;
            this.soyAd=soyad;
            this.No=no;
            this.Departman=departman;
        }
         public Calisan(string ad,string soyad)
        {
            this.Ad=ad;
            this.soyAd=soyad;
           
        }
        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soydı:{0}",soyAd);
            Console.WriteLine("Çalışan numarası:{0}",No);
            Console.WriteLine("Çalışanın departmanı:{0}",Departman);


        }







    }
}