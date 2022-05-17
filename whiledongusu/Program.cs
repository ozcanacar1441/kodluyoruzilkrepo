using System;

namespace whiledongusu // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz:");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=1;
            while(sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);
            char character='a';

            while(character<'z')
            {
                Console.Write(character);
                character++;
            }
            Console.WriteLine(" ");
             Console.WriteLine("**** foreach ****");
             string[] arabalar={"BMW","FORD","TOYOTA","NİSSAN"};
             foreach(var araba in arabalar)
             {
                 Console.WriteLine(araba);

             }

        }
    }
}