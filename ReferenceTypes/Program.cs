using System;

namespace ReferenceTypes
{
    class Program   //4. Gün 1. Ödev videosu.
    {
        static void Main(string[] args)
        {
            //int, decimal, float, enum, boolean; value types (sayısal veriler değer tiplerdir.)
            //hafızada STACK'de işlem görür ve orada depolanır.
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;  //"sayi1'in değeri = sayi2'nin değeri" diye okunur.
            sayi2 = 100;

            Console.WriteLine("sayi1 :" + sayi1);

            //array, class,interface reference types(referans tipler)
            //belleğin STAKC kısmına adını, değerlerini ise HEAP'te tutar. Her "new" dediğimizde heap'te yeni bir adres tanımlar.
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;    //"sayilar1'in adresi = sayilar2'nin adresi" diye okunur.
            sayilar2[0] = 1000;

            Console.WriteLine("sayilar1[0] = "+ sayilar1[0]);
            

        }
    }
}
