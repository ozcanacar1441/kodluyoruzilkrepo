using System;

namespace generic_list // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi=new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi=new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");
            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);
            //foreach ve listForeach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
             foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }
            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));
            //Liste içerisinde arama

            if(sayiListesi.Contains(10)){
                Console.WriteLine("10 liste içerisinde bulundu");
            }
            //Eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));
            //Diziyi Liste çevirme 
            string[] hayvanlar={"Kedi","Köpek","Kuş"};
            List<string> hayvanListesi=new List<string>(hayvanlar);

            //Liste temizleme
            hayvanListesi.Clear();

            //Lİste içerisinde nesne tutma
            List<Kullanıcılar> kullanıcıListesi=new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.İsim = "Ayşe";
            kullanıcı1.Soyisim="Yılaz";
            kullanıcı1.Yas=26;
            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.İsim = "Özcan";
            kullanıcı2.Soyisim="Çalışkan";
            kullanıcı2.Yas=26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);
            List<Kullanıcılar> yeniListe=new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar{
                İsim="Deniz",Soyisim="Arda",Yas=24
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı adı:"+kullanıcı.İsim);
                Console.WriteLine("Kullanıcı soyadı:"+kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı yaşı:"+kullanıcı.Yas);
            }










        }
    }
    public class Kullanıcılar{
         private string isim;
         private string soyisim;
         private int yas;
         public string İsim{get=>isim;set=>isim=value;}
         public string Soyisim{get=>soyisim;set=>soyisim=value;}
         public int Yas{get=>yas;set=>yas=value;}
         

    }
}