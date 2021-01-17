using System;
using System.Collections.Generic;
using System.Text;

namespace HesapMakinesi
{
    class Dortİslem
    {
        public void Topla(double sayi1, double sayi2)
        {
            double sonuc = sayi1 + sayi2 ;
            Console.WriteLine(sayi1+ " + " + sayi2 + " = " + sonuc);
        }
        public void Cikar(double sayi1, double sayi2)
        {
            double sonuc = sayi1 - sayi2 ;
            Console.WriteLine(sayi1 + " - " + sayi2 + " = " + sonuc);
        }
        public void Carp(double sayi1, double sayi2)
        {
            double sonuc = sayi1 * sayi2 ;
            Console.WriteLine(sayi1 + " * " + sayi2 + " = " + sonuc);
        }
        public void Böl(int sayi1, int sayi2)
        {
            int sonuc =sayi1 / sayi2 ;
            int mod = sayi1 % sayi2;
            if (mod==0)
            {
                Console.WriteLine(sayi1 + " / " + sayi2 + " = " + sonuc);
            }
            else
            {
                Console.WriteLine(sayi1 + " / " + sayi2 + " = " + sonuc +" || " + "kalan: "+mod);
            }
        }
    }
}
