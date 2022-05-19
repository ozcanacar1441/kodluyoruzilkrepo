using System;

namespace hazir_metotlar_string // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken="Dersimiz CSharp,    Hoşgeldiniz";
            string degisken2="CSharp";
            //length
            Console.WriteLine(degisken.Length);
            //büyük harf yapma,küçük harf yapma
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            //concat

            Console.WriteLine(String.Concat(degisken," Merhaba!")); 
            //compare

            Console.WriteLine(degisken.CompareTo(degisken2));//0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));
            //contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
             Console.WriteLine(degisken.StartsWith("Merhaba"));

             //indexof
             Console.WriteLine(degisken.IndexOf("CS"));
             Console.WriteLine(degisken.IndexOf("Ozcan"));
              Console.WriteLine(degisken.LastIndexOf("i"));
            //İnsert
            Console.WriteLine(degisken.Insert(0,"Merhaba! "));
           //Padleft,Padright
           Console.WriteLine(degisken + degisken2.PadLeft(30));
           Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
           Console.WriteLine(degisken.PadRight(50,'-') + degisken2);
            //remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));
            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));





        }
    }
}