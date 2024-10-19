using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Egitim_Kampi_Ders_08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void yazdir()
            //{
            //    Console.WriteLine(1);
            //    Console.WriteLine(2);
            //    Console.WriteLine(3);
            //    Console.WriteLine(4);
            //    Console.WriteLine(5);
            //    Console.WriteLine(6);
            //    Console.WriteLine(7);
            //    Console.WriteLine(8);
            //    Console.WriteLine(9);
            //    Console.WriteLine(10);
            //}
            //yazdir();
            //yazdir();


            //void toplama()
            //{
            //    int x = 1; int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //toplama();





            #endregion

            #region geriye değer döndürmeyen string parametreli metotlar

            //void yazdir(string deger)
            //{
            //    Console.WriteLine(deger);
            //}
            //yazdir("Mehmet");


            //void kunye(String ad, String soyad)
            //{
            //    Console.WriteLine("Müşterini adı ve soyadı: " + ad + " " + soyad);
            //}
            //kunye("Ali", "Yılmaz");
            //kunye("Derya", "Yılmaz");


            #endregion

            #region geriye değer döndürmeyen int parametreli metotlar

            //void toplam (int number1, int number2,int number3)
            //{
            //    int sonuc=number1 + number2+number3;
            //    Console.WriteLine(sonuc);
            //}

            //toplam(2, 6, 9);

            #endregion

            #region geriye değer döndüren metotlar

            //string ad()
            //{
            //    return "Ali Yılmaz";
            //}

            //ad();

            //String Ogrencikunyesi()
            //{
            //    String ad = "Ali";
            //    String Soyad = "Yılmaz";

            //    return ad + " " + Soyad;
            //}
            //Console.WriteLine(Ogrencikunyesi());

            #endregion

            #region geriye değer döndüren string parametreli metotlar

            //string ulkebilgisi(string isim, string baskent, string bayrakrengi)
            //{
            //    string kartbilgisi = "Ülke: " + isim + " Başkent: " + baskent + " Bayrak Rengi: " + bayrakrengi;
            //    return kartbilgisi;
            //}

            //string x, y, z;

            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Başkent Adını Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(ulkebilgisi(x, y, z));
            //Console.WriteLine(ulkebilgisi("Türkiye", "Ankara", "Kırmızı Beyaz"));

            #endregion

            #region geriye değer döndüren int parametreli metotlar

            //int toplam(int sayi1, int sayi2)
            //{
            //    int sonuc=sayi1 + sayi2;
            //    return sonuc;
            //}
            //Console.WriteLine(toplam(52, 48));

            #endregion

            #region Örnek

            string sinavsonucu(string ogrenci, int sinav1,int sinav2, int sinav3)
            {
                int sonuc = (sinav1 + sinav2 + sinav3) / 3;
                if (sonuc >= 50)
                    return ogrenci + " Matematik Dersini Geçti. Ortalama: " + sonuc;
                else
                    return ogrenci + " Matematik Dersininden Kaldı. Ortalama: " + sonuc;

            }

            Console.WriteLine(sinavsonucu("Ali", 45, 69, 16));
            Console.WriteLine(sinavsonucu("Ayşe", 96, 86, 23));
            Console.WriteLine(sinavsonucu("Beyza", 73, 86, 99));
            #endregion

            Console.Read();
        }
    }
}
