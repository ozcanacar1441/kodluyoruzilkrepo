using System;

namespace odev1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Pozitif bir sayı giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] b=new int[a];
            Console.WriteLine(a+"tane sayi giriniz ");
            for(int i=0;i<a;i++)
            {
                b[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Çift sayı olanlar:");
            foreach (int item in b)
            {
                if(item%2==0)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("***2.soru cevabı***");
            //2
            Console.WriteLine("Pozitif iki sayı giriniz:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y=Convert.ToInt32(Console.ReadLine());
            int[] z=new int[x];
            Console.WriteLine(x+"tane sayi giriniz ");
            for(int j=0;j<x;j++)
            {
                z[j]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Tam bölünen ya da eşit olan sayılar");
             foreach (int item in z)
            {
                if(item%y==0 || item ==y)
                {
                    Console.WriteLine(item);
                }
            }
            //**************3*************
            Console.WriteLine("***3.soru cevabı***");
             Console.WriteLine("Pozitif bir sayı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] kelime=new string[n];
            Console.WriteLine(n + "adet kelime giriniz:");
            for(int k=0;k<n;k++)
            {
                kelime[k]=Console.ReadLine();
            }
            Array.Reverse(kelime);
            foreach (string item in kelime)
            {
                Console.WriteLine(item);
            }
            //**************4*************
            Console.WriteLine("***4.soru cevabı***");
            Console.WriteLine("Bir cümle giriniz");
            string cumle=Console.ReadLine();
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine("Kelime Sayısı :"+kelimeler.Length);
            Console.WriteLine("Yukarıdaki ifade toplam {0} karakter içerir.", cumle.Length);

            

        }
    }
}