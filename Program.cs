using System;



namespace PracticalForExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }
            Console.WriteLine("-----------------------------------------------------------------------");

            for (int sayi = 2; sayi < 20; sayi++)
            {
                Console.WriteLine($"1 ile 20 arasındaki sayılar : {sayi}");
            }
            Console.WriteLine("-----------------------------------------------------------------------");
            for (int sayi1 = 2; sayi1 < 20; sayi1++)
            {
                if (sayi1 % 2 == 0)
                {
                    Console.WriteLine($" 1 ile 20 arasındaki çift sayılar : {sayi1}");
                }
            }
            Console.WriteLine("-----------------------------------------------------------------------");
            int toplam = 0;
            for (int sayi2 = 51; sayi2 < 150; sayi2++)
            {
                toplam += sayi2;
            }
            Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {toplam}");
            Console.WriteLine("-----------------------------------------------------------------------");
            int oddNumber = 0;
            int evenNumber = 0;
            for (int sayi3 = 1; sayi3 < 120; sayi3++)
            {

                if (sayi3 % 2 == 0)
                {
                    evenNumber += sayi3;
                }
                else
                {
                    oddNumber += sayi3;
                }
            }
            Console.WriteLine($"Cift sayiların toplamı : {evenNumber}");
            Console.WriteLine($"Tek sayiların toplamı : {oddNumber}");


        }
    }
}
