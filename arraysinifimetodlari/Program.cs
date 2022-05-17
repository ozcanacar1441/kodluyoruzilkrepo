using System;

namespace arraysinifimetodlari // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] sayiDizisi={23,12,4,86,72,3,11,17};
            Console.WriteLine("***Sırasız Dizi***");
           foreach(var sayi in sayiDizisi)
           Console.WriteLine(sayi);
           
           Console.WriteLine("***Sıralı Dizi***");
           Array.Sort(sayiDizisi);
           foreach(var sayi in sayiDizisi)
           Console.WriteLine(sayi);
           
           //Clear
           Console.WriteLine("***Array Clear***");
           //sayi dizisi elemanlarını kullan arak 2. indexten itibaren 2 elemanı sıfırlar
            Array.Clear(sayiDizisi,2,2);
            foreach(var sayi in sayiDizisi)
             Console.WriteLine(sayi);
           
           //reverse
            Console.WriteLine("***Array Reverse***");
           Array.Reverse(sayiDizisi);
             foreach(var sayi in sayiDizisi)
             Console.WriteLine(sayi);

             //indexof
             Console.WriteLine("***indexof***");
             Array.IndexOf(sayiDizisi,23);   
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));
            //resize
            Console.WriteLine("***Array Resize***");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
            foreach(var sayi in sayiDizisi)
             Console.WriteLine(sayi);



           
        }
    }
}