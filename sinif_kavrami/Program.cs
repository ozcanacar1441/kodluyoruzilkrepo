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
            Calisan calisan1=new Calisan();
            calisan1.Ad="Ayşe";
            calisan1.soyAd="Kara";
            calisan1.No=23425634;
            calisan1.Departman="İnsan Kaynakları";
            calisan1.CalisanBilgileri();
            Console.WriteLine("**********************");
            Calisan calisan2=new Calisan();
            calisan2.Ad="Deniz";
            calisan2.soyAd="Arda";
            calisan2.No=25646789;
            calisan2.Departman="Satın Alma";
            calisan2.CalisanBilgileri();



        }
    }
    class Calisan
    {
        public string Ad;
        public string soyAd;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soydı:{0}",soyAd);
            Console.WriteLine("Çalışan numarası:{0}",No);
            Console.WriteLine("Çalışanın departmanı:{0}",Departman);


        }







    }
}