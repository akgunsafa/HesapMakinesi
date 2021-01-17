using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dortİslem dortİslem = new Dortİslem();
            Console.WriteLine("yapmak istediğiniz işlemi giriniz(toplama/çıkarma/çarpma/bölme):  ");
            string islem = Console.ReadLine();
           
            Console.WriteLine("ilk sayıyı giriniz : ");
            int sayi1 = Int32.Parse(Console.ReadLine());
           
            Console.WriteLine("ikinci sayıyı giriniz : ");
            int sayi2 = Int32.Parse(Console.ReadLine());

            switch (islem)
            {
                case "toplama":
                    dortİslem.Topla(sayi1 ,sayi2);
                    break;
                case "çıkarma":
                    dortİslem.Cikar(sayi1 ,sayi2);
                    break;
                case "çarpma":
                    dortİslem.Carp(sayi1 ,sayi2);
                    break;
                case "bölme":
                    dortİslem.Böl(sayi1 ,sayi2);
                    break;
                default:
                    Console.WriteLine("işlem ismi yanlış yazıldı!!");
                    break;

            }
        }
    }
}
