using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Egitim_Kampi_Ders_06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Diziler

            //string[] renkler = new string[4];

            //renkler[0] = "Sarı";
            //renkler[1] = "Lacivert";
            //renkler[2] = "Mavi";
            //renkler[3] = "Mor";{

            //Console.WriteLine(renkler[3]);

            //string[] sehirler = new string[5];

            //sehirler[0] = "İstanbul";
            //sehirler[1] = "Bursa";
            //sehirler[2] = "Ankara";
            //sehirler[3] = "İzmir";
            //sehirler[4] = "Malatya";

            //Console.WriteLine(sehirler[2]);

            //int[] sayilar = new int[12];

            //sayilar[1] = 2;
            //sayilar[3] = 4;
            //sayilar[5] = 6;
            //sayilar[7] = 8;
            //sayilar[9] = 10;
            //sayilar[11] = 12;

            //Console.WriteLine(sayilar[7]);
            //Console.WriteLine(sayilar[6]);

            //string[] sehirler = { "İstanbul", "Bursa", "Ankara" };
            //Console.WriteLine(sehirler[0]);
            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] renkler = { "Sarı", "Lacivert", "Mavi", "Mor","Pembe" };

            //for (int i = 0; i < renkler.Length; i++)
            //{
            //    Console.WriteLine(renkler[i]);
            //}

            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, }

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 3 == 0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}

            //char[] chars = { 'a', 'b', 'c', 'd', '*', '-', '/', '+' };

            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}

            //int[] ints = { 1, 2, 3, 4, 65, 6, 7, 8, 9, 2310, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, };

            //int enbuyuksayi = ints[0];

            //for (int i = 0; i < ints.Length; i++)
            //{              
            //        if (ints[i] > enbuyuksayi)
            //        {
            //            enbuyuksayi=ints[i];
            //        }
            //}
            //Console.WriteLine(enbuyuksayi);

            //string[] isim = { "Ali", "Ahmet", "Cemre", "Derya", "Mehmet", "Beyza" };
            //Console.WriteLine(isim.Length);

            //int[] ints = { 11, 622, 83, 324, 65, 60, 67, 3348, 99,};

            //Array.Sort(ints);

            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.WriteLine(ints[i]);
            //}
            //Console.WriteLine("---------------------------");

            //Array.Reverse(ints); //diziyi tersten sıralıyor.
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.WriteLine(ints[i]);
            //}


            #endregion

            #region Dizi metotlar

            //string[] müsteriler = { "Ali", "Ahmet", "Cemre", "Derya", "Mehmet", "Beyza" };

            //int index = Array.IndexOf(müsteriler, "Beyza");
            //Console.WriteLine(index);

            //int[] ints = { 71, 21, 36, 412, 50, 6, 597, 18, 79, 130, 11, 126, 13, 134, };
            //Console.WriteLine("Dizinin en büyük elemanı: " + ints.Max() + " Dizinin en kücük elamanı: "+ ints.Min());

            #endregion

            #region Kullanıcıdan dizi alma

            //String[] sehirler = new String[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Lütfen " + (i + 1) + ". şehri yazınız: ");
            //    sehirler[i] = Console.ReadLine();
            //}

            //Console.WriteLine("----------------------");

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}


            //int[] ints = { 71, 21, 36, 412, 5, 99, 75, 64, 141, 126, 13, 134, };
            //int toplam = 0;

            //for (int i = 0; i < ints.Length; i++)
            //{
            //    toplam += ints[i];
            //}
            //Console.WriteLine(toplam);

            int[] numbers = { 1, 3, 5, 70, 9, 110, 13, 170, 19, 23, 290, 31, 71, 21, 36, 412, 5, 99, 75, 64, 141, 126, 13, 134, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

            Console.Write("Çift Sayılar");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("Tek Sayılar");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion

            Console.Read();
        }
    }
}
