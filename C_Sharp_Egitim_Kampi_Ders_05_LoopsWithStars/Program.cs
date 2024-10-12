using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Egitim_Kampi_Ders_05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region alt alta 10 adet yıldız oluşturma

            //int i = 1;

            //while (i<=10)
            //{
            //    Console.WriteLine("*");
            //    i++;
            //}

            #endregion

            #region yan yana 10 adet yıldız oluşturma

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.Write("*");
            //    i++;
            //}

            #endregion

            #region alt altan ve yan yana 10 adet yıldız oluşturma

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("**********");
            //    i++;
            //}

            #endregion

            #region Dik üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Dik üçgen

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik üçgen ve ters dik üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //        for (int j = n - 1; j > 0; j--)
            //        {
            //            Console.Write(" ");
            //        }

            //        for (int k = 1; k <= (2 * i) - 1; k++)
            //        {
            //            Console.Write("*");
            //        }
            //    Console.WriteLine();
            //}

            //for (int i = n-1; i >= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= (2 * i) - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region piramit

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region ters piramit

            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            Console.ReadKey();
        }
    }
}
