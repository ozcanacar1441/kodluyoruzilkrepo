using System;
using System.Collections;

namespace odev2_soru1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degisken=0;
            ArrayList liste=new ArrayList();
            ArrayList listeAsal=new ArrayList();
            Console.WriteLine("20 adet sayi giriniz");
            for(int i=0;i<20;i++)
            {   
                
                degisken=Convert.ToInt32(Console.ReadLine());
                if(degisken>0 && IsNumeric(Convert.ToString(degisken))==true )
                {
                    if(Asalmi(degisken)==0)
                    {
                       liste.Add(degisken);             
                    }
                    else if(Asalmi(degisken)==1)
                    {
                        listeAsal.Add(degisken);
                    }
                                    
                }
                else{
                    Console.WriteLine("Hatalı giriş!!");
                    break;
                }
                
            }
            Console.WriteLine("***Girilen asal olmayan sayılar büyükten küçüğe***");
            liste.Sort();
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Dizinin eleman sayısı "+liste.Count);
            int toplam1=0;
            foreach (int item in liste)
            {
                toplam1+=item;
            }
            Console.WriteLine("Dizinin ortalaması "+toplam1/liste.Count);

            Console.WriteLine("***Girilen asal olan sayılar büyükten küçüğe***");
            listeAsal.Sort();
            listeAsal.Reverse();
             foreach (var item in listeAsal)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Dizinin eleman sayısı "+listeAsal.Count);
            int toplam2=0;
             foreach (int item in listeAsal)
            {
                toplam2+=item;
            }
            Console.WriteLine("Dizinin ortalaması "+toplam2/listeAsal.Count);
            
        }
         private static int Asalmi(int sayi)
        {
            int i;
            for (i = 2; i <= sayi - 1; i++)
            {
                if (sayi % i == 0)
                {
                    return 0;
                }
            }
            if (i == sayi)
            {
                return 1;
            }
            return 0;
        }
        private static bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }   
    }
    
}