using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = “Bom Oyunu” ;
            Console.ForegroundColor = ConsoleColor.Green;

            int siradaki_sayi = 1;
            string vermesi_gereken_cevap = “”;
            string kullanici_cevabi = “”;
            for (int i = 1; i < 5; i++)
            {
                if ((siradaki_sayi) % 5 == 0)
                {
                    Console.WriteLine(“BOM”);
                }
                else
                {
                    Console.WriteLine(siradaki_sayi);
                }
                if ((siradaki_sayi + 1) % 10 == 0)
                {
                    vermesi_gereken_cevap = “BOM”;
                }
                else
                {
                    vermesi_gereken_cevap = (siradaki_sayi + 1).ToString();
                }

                Reklam
            
Console.Write(“Sıra Sizde: “);
                kullanici_cevabi = Console.ReadLine();
                kullanici_cevabi = kullanici_cevabi.ToUpper();
                if (vermesi_gereken_cevap == kullanici_cevabi)
                {
                    i–;
                    siradaki_sayi = siradaki_sayi + 2;
                }
                else
                {
                    i = 5;
                    Console.WriteLine(“Yenildiniz”);
                    Console.ReadKey();
                }
            }

        }
    }
}