using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Egitim_Kampi_Ders_04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For döngüsü
            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Test");
            //}

            //for (int i = 1; i <= 25; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i <= 51; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını isteğiniz adedi giriniz: ");
            //int deger = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= deger; i++)
            //{
            //    Console.WriteLine("Atatürk");
            //}
            #endregion

            #region For dongüsü ile karar yapıları

            //for (int i = 1; i <=100; i++)
            //{
            //    if (i % 5==00)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int toplam = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);

            //int toplam = 0;
            //for (int i = 0; i <20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine("---------------------------");
            //Console.WriteLine(toplam);

            //int toplam = 0;
            //for (int i = 1; i <=50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        toplam += 1;
            //    }                
            //}
            //Console.WriteLine("7'ye bölünen " + toplam + " sayı vardır.");

            //int toplambakteri = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    toplambakteri *= 2;
            //    Console.WriteLine(i + ". saat sonunda toplam bakteri sayısı: "+toplambakteri);
            //}

            #endregion

            #region While Döngüsü
            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 0;
            //int toplam = 0;

            //while (i <=10)
            //{
            //    toplam += i;
            //    i++;
            //}
            //Console.WriteLine(toplam);
            #endregion

            #region Örnek

            int birler, onlar, yuzler;

            Console.Write("Lütfen 3 basamaklı bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            //256

            yuzler = sayi / 100;
            onlar = (sayi - (yuzler * 100)) / 10;
            birler = sayi - (yuzler * 100) - (onlar * 10);

            Console.WriteLine(yuzler + " + " + onlar + " + " + birler + " = " + (yuzler + onlar + birler));

            #endregion

            Console.ReadKey();
        }
    }
}
