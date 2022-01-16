using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = int.Parse(Console.ReadLine());

            // Ekrana girilen sayıya kadar olan tek sayıları ekrana yazdır.
            for (int i = 0; i <= sayac; i++)
            {
                if (i%2 == 1)// tek sayı ise
                {
                    Console.WriteLine(i);
                }
            }
            int tektoplam = 0;
            int cifttoplam = 0;
            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını ekrana yazdır.
            for (int i = 0; i <= 1000; i++)
            {
                if (i%2 == 1)
                {
                    // Tek sayılar
                    tektoplam += i;
                }
                else
                {
                    // Çift sayılar
                    cifttoplam += i;
                }
            }
            Console.WriteLine("Tek toplam :" + tektoplam);
            Console.WriteLine("Çift toplam :" + cifttoplam);


            // break, continue
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break; // i = 4 olduğunda, döngüden tamamen çıkar.
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue; // i = 4 olduğu adımı atlar bir sonraki adıma geçer.
                }
            }

            //for (; ;)
            //{
            //    // sonsuz döngü.
            //}
        }
    }
}
