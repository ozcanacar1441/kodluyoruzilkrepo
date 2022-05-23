using System;

namespace struct_kavrami // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen dikdörtgen= new Dikdörtgen();
            dikdörtgen.KisaKenar=3;
            dikdörtgen.UzunKenar=4;
            Console.WriteLine("Class Alan hesabı:{0}",dikdörtgen.AlanHesapla());

            Dikdörtgen_Struct dikdörtgen_Struct=new Dikdörtgen_Struct(3,4);
            
             Console.WriteLine("Class Alan hesabı:{0}",dikdörtgen_Struct.AlanHesapla());


        }
    }
    class Dikdörtgen
    {
        public int KisaKenar;
        public int UzunKenar;
        public Dikdörtgen(){
            KisaKenar=3;
            UzunKenar=4;
        }

        public long AlanHesapla(){
            return this.KisaKenar*this.UzunKenar;
        }
    }
    struct Dikdörtgen_Struct{
       public int KisaKenar;
       public int UzunKenar;
       public Dikdörtgen_Struct(int kisaKenar,int uzunKenar){
            KisaKenar=kisaKenar;
            UzunKenar=uzunKenar;
        }
       public long AlanHesapla(){
            return this.KisaKenar*this.UzunKenar;
        }
    }
}