namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class donguler
    {
        static void Main(string[] args)
        {
           int i,a,sonuc;
           Console.WriteLine("Bir sayı giriniz:");
           a=int.Parse(Console.ReadLine());
           for(i=1;i<=10;i++)
           {
               
               sonuc=a*i;
               Console.WriteLine(a+" x "+i+"= "+sonuc);

           }
           
        }
    }
}