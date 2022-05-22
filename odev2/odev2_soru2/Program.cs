using System;
using System.Collections;

namespace odev2_soru2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste=new ArrayList();
            int degisken=0;
            Console.WriteLine("Lütfen 20 adet sayı giriniz:");

            for(int i=0;i<20;i++)
            {
                degisken=Convert.ToInt32(Console.ReadLine());
                liste.Add(degisken);
            }
            liste.Sort();
            int x,y,z,a,b,c;
            x=Convert.ToInt32(liste[0]);
            y=Convert.ToInt32(liste[1]);
            z=Convert.ToInt32(liste[2]);
            Console.WriteLine("En küçük sayılar:"+x+" "+y+" "+z );
            int ortalama_kucuk=(x+y+z)/3;
            Console.WriteLine("En küçüklerin ortalaması:"+ortalama_kucuk);
            liste.Reverse();
            a=Convert.ToInt32(liste[0]);
            b=Convert.ToInt32(liste[1]);
            c=Convert.ToInt32(liste[2]);
            Console.WriteLine("En büyük sayılar:"+a+" "+b+" "+c);
            int ortalama_buyuk=(a+b+c)/3;
            Console.WriteLine("En büyüklerin ortalaması:"+ortalama_buyuk);
            int toplam=ortalama_buyuk+ortalama_kucuk;
            Console.WriteLine("Ortalama toplamları:"+toplam);



        }
    }
}