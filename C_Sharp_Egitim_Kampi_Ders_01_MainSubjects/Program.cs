using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Egitim_Kampi_Ders_01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma
            /* Console.WriteLine("Merhaba Dünya");

             Console.WriteLine("--Kırtasiye Ürünleri--");
             Console.WriteLine();
             Console.WriteLine("1-Kalemler");
             Console.WriteLine("2-Defterler");
             Console.WriteLine("3-Silgiler");
             Console.WriteLine("4-Soru Bankaları");
             Console.WriteLine();
             Console.WriteLine("--Kırtasiye Ürünleri--");*/
            #endregion

            #region String

            /*

             string isim;
             isim = "Mehmet";
             Console.Write(isim);

             string customerName, customerSurname, customerPhone;
             string customerEmail, district, city;

             customerName = "Mehmet";
             customerSurname = "Bozkurt";
             customerPhone = "+90 512 214 95 14";
             customerEmail = "test@hotmail.com";
             district = "Pendik";
             city = "İstanbul";
             Console.WriteLine("-- Rezervasyon Kartı --");
             Console.WriteLine();
             Console.WriteLine("------------------------------");
             Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
             Console.WriteLine("İletişim: " + customerPhone);
             Console.WriteLine("Email Adresi: " + customerEmail);
             Console.WriteLine("Adres: " + district + "/" + city);
             Console.WriteLine("------------------------------");
             Console.WriteLine();          
            */
            #endregion

            #region integer
            int sayi = 702;
            Console.WriteLine(sayi);

            int kalemPrice = 125;
            int silgiPrice = 52;
            int defterPrice = 156;
            int sorubankasiPrice = 359;
            int ucPrice = 25;
            int romanPrice = 69;

            Console.WriteLine("-- Kırtasiye Fiyatları --");
            Console.WriteLine();
            Console.WriteLine("-kalem: " + kalemPrice + " TL");
            Console.WriteLine("-silgi: " + silgiPrice + " TL");
            Console.WriteLine("-defter: " + defterPrice + " TL");
            Console.WriteLine("-soru bankası: " + sorubankasiPrice + " TL");
            Console.WriteLine("-uç: " + ucPrice + " TL");
            Console.WriteLine("-roman: " + romanPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("-- Kırtasiye Fiyatları --");


            Console.WriteLine();
            int kalemCount, silgiCount, defterCount, sorubankasiCount, ucCount, romanCount;

            int totalkalemPrice, totalsilgiPrice, totaldefterPrice, totalsorubankasiPrice, totalucPrice, totalromanPrice;

            kalemCount = 1;
            silgiCount = 1;
            defterCount = 1;
            sorubankasiCount = 1;
            ucCount = 2;
            romanCount = 1;

            totalkalemPrice = kalemCount * kalemPrice;
            totalsilgiPrice = silgiCount * silgiPrice;
            totaldefterPrice = defterCount * defterPrice;
            totalromanPrice = romanCount * romanPrice;
            totalsorubankasiPrice = sorubankasiCount * sorubankasiPrice;
            totalucPrice = ucCount * ucPrice;

            Console.WriteLine("|||||||||||||||||");
            Console.WriteLine("kalem Tutarı: " + totalkalemPrice + " TL");
            Console.WriteLine("silgi Tutarı: " + totalsilgiPrice + " TL");
            Console.WriteLine("defter Tutarı: " + totaldefterPrice + " TL");
            Console.WriteLine("soru bankası Tutarı: " + totalsorubankasiPrice + " TL");
            Console.WriteLine("uc Tutarı: " + totalucPrice + " TL");
            Console.WriteLine("roman Tutarı: " + totalromanPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalkalemPrice + totalsilgiPrice + totaldefterPrice + totalsorubankasiPrice + totalucPrice + totalromanPrice;

            Console.WriteLine("Ödenecek Tutar: " + totalPrice + " TL");

            #endregion

            Console.Read();
        }
    }
}
