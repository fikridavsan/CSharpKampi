using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Egitim_Kampi_Ders_07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach döngüsü
            //string[] sehirler = { "İstanbul", "Ankara", "Bursa", "İzmir" };

            //foreach (string s in sehirler)
            //{
            //    Console.WriteLine(s);
            //}

            //int[] ints = { 1, 2, 3, 4,5,6, 7, 8, 9 };

            //foreach (int i in ints)
            //{

            //    Console.WriteLine(i);
            //}

            //int[] sayilar = { 26, 98, 365, 145, 256, 259, 147, 25, 36, 69, 47, 95, 65, 32, 2547 };

            //foreach (int i in sayilar)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int[] sayilar = { 329, 988, 466, 299, 920, 571, 266, 167, 848, 724, 561, 580, 193, 440, 377, 698, 793, 523, 549, 992 };

            //int toplam = 0;

            //foreach (int i in sayilar)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);


            //List<int> list = new List<int>()
            //{
            //    1,2,3,4,5,6
            //};
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //string kelime = "ATATÜRK";

            //foreach (char c in kelime)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav

            Console.Write("***** Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.Write("Sınıfınızdaki Öğrenci Sayısı: ");
            int mevcut = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            string[] ogrenciisimleri = new string[mevcut];
            double[] sinavsonclari = new double[mevcut];

            for (int i = 0; i < ogrenciisimleri.Length; i++)
            {
                Console.Write($"{i + 1}. Öğrenci İsmini Giriniz: ");
                ogrenciisimleri[i] = Console.ReadLine();

                double toplam = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{ogrenciisimleri[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double sinav = double.Parse(Console.ReadLine());
                    toplam += sinav;

                }
                Console.WriteLine();
                sinavsonclari[i] = toplam / 3;
            }

            for (int i = 0; i < mevcut; i++)
            {
                Console.WriteLine($"{ogrenciisimleri[i]} adlı öğrencinin ortalaması: {sinavsonclari[i]}");
                if (sinavsonclari[i] >= 50)
                    Console.WriteLine($"{ogrenciisimleri[i]} adlı öğrenci dersten geçti.");
                else
                    Console.WriteLine($"{ogrenciisimleri[i]} adlı öğrenci dersten kaldı.");
            }

            Console.WriteLine();
            Console.Write("***** Sınav Uygulaması *****");
            #endregion

            Console.Read();
        }
    }
}
