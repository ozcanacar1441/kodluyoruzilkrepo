using System;

namespace csharp_enum // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık=32;
            if(sıcaklık<=(int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekleyelim");

            }
            else if(sıcaklık>=(int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Dışarıya çıkmak için sıcak bir gün");
            }
            else if(sıcaklık>=(int)HavaDurumu.Normal && sıcaklık<(int)HavaDurumu.CokSıcak)
            {
                Console.WriteLine("Hadi dışarıya çıkalım");
            }

        }
    }
    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu{
        Soğuk=5,
        Normal=20,
        Sıcak=25,
        CokSıcak=30

    }
}