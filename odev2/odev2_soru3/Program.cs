using System;

namespace odev2_soru3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bir cümle giriniz:");
            string cumle = Console.ReadLine();
            string[] dizi=new string[50];
            int degisken=0;
            string sesli = "aeıioöuü";
            int sayac=0;
               	
            for(int i=0;i<cumle.Length;i++)
            {
               if(sesli.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Sesli harf sayısı:"+sayac);


        }
        
    }
    
}