using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Egitim_Kampi_Ders_02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double
            /*
            double sayipi;
            sayipi = 3.14;
            Console.WriteLine(sayipi);
            Console.WriteLine("-- Fiyat Listesi --");
            Console.WriteLine();
             double elmaPrice, portaklPrice, cilekPrice, patatesPrice, domatPrice;

            elmaPrice = 14.85;
            portaklPrice = 20.95;
            cilekPrice = 45;
            patatesPrice = 9.74;
            domatPrice = 6.88;

            Console.WriteLine("* Elma Birim Fiyatı:" + elmaPrice + " TL");
            Console.WriteLine("* Portakal Birim Fiyatı:" + portaklPrice + " TL");
            Console.WriteLine("* Çilek Birim Fiyatı:" + cilekPrice + " TL");
            Console.WriteLine("* Patates Birim Fiyatı:" + patatesPrice + " TL");
            Console.WriteLine("* Domates Birim Fiyatı:" + domatPrice + " TL");

            Console.WriteLine();
            Console.WriteLine();

            double portaklGram, patatesGram, domatGram, elmaGram, cilekGram;

            portaklGram = 1.479;
            patatesGram = 7.502;
            domatGram = 5.120;
            elmaGram = 6.270;            
            cilekGram = 1.025;

            double portaklTotalPrice = portaklGram * portaklPrice;
            double patatesTotalPrice = patatesGram * patatesPrice;
            double domatTotalPrice = domatGram * domatPrice;
            double elmaTotalPrice = elmaGram * elmaPrice;            
            double cilekTotalPrice = cilekGram * cilekPrice;

            Console.WriteLine("--Alınan Ürün: portakal - " + "Birim Fiyatı: " + portaklPrice + " - Gramajı: " + portaklGram + " - Toplam Tutar: " + portaklTotalPrice);
            Console.WriteLine("--Alınan Ürün: domates - " + "Birim Fiyatı: " + domatPrice + " - Gramajı: " + domatGram + " - Toplam Tutar: " + domatTotalPrice);
            Console.WriteLine("--Alınan Ürün: Patates - " + "Birim Fiyatı: " + patatesPrice + " - Gramajı: " + patatesGram + " - Toplam Tutar: " + patatesTotalPrice);
            Console.WriteLine("--Alınan Ürün: elma - " + "Birim Fiyatı: " + elmaPrice + " - Gramajı: " + elmaGram + " - Toplam Tutar: " + elmaTotalPrice);
            Console.WriteLine("--Alınan Ürün: Çilek - " + "Birim Fiyatı: " + cilekPrice + " - Gramajı: " + cilekGram + " - Toplam Tutar: " + cilekTotalPrice);

            double shoppingTotalPrice = portaklTotalPrice + patatesTotalPrice + domatTotalPrice + elmaTotalPrice + cilekTotalPrice;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Toplam Tutar:" + shoppingTotalPrice + " TL");
            */
            #endregion

            #region char
            //char sembol;
            //sembol = 'D';
            //Console.WriteLine(sembol);
            #endregion

            #region kullanıcıdan veri alma (string)
            /*
            Console.WriteLine("** Hava Yolları Yolcu Bilgisi **");
            Console.WriteLine();
            string yolcuismi, yolcusoyadi, yolcuilcesi, yolcusehri, yolcuyasi, yolcutc;
            
            Console.Write("Yolcu Adı : ");
            yolcuismi = Console.ReadLine(); // okuma yapıyor

            Console.Write("Yolcu Soyadı : ");
            yolcusoyadi = Console.ReadLine();

            Console.Write("Şehir Bilgisi : ");
            yolcusehri = Console.ReadLine();

            Console.Write("İlçe Bilgisi : ");
            yolcuilcesi = Console.ReadLine();            

            Console.Write("Yolcu Yaşı : ");
            yolcuyasi = Console.ReadLine();

            Console.Write("Yolcu T.C. Kimlik Numarısı : ");
            yolcutc = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("-----------------------");
            Console.WriteLine("Yolcu TC Kimlik No: " + yolcutc + " - Yolcu Ad Soyad: " + yolcuismi + " " + yolcusoyadi + " " + yolcusehri+ " / " + yolcuilcesi + " " + yolcuyasi);
            */
            #endregion

            #region kullanıcıdan veri alma (integer) ve dönüşüm
            /*
            int ayakkabifiyati, pcfiyati, oyuncukoltugufiyati, tvfiyati;
            ayakkabifiyati = 950;
            pcfiyati = 65000;
            oyuncukoltugufiyati = 8000;
            tvfiyati = 15000;

            int ayakkabisayisi, pcsayisi, oyuncukoltugusayisi, tvsayisi;

            Console.Write("ayakkabı sayısını giriniz: ");
            ayakkabisayisi = int.Parse(Console.ReadLine());

            Console.Write("bilgisayar sayısını giriniz: ");
            pcsayisi = int.Parse(Console.ReadLine());

            Console.Write("ıyuncu koltuğu sayısını sayısını giriniz: ");
            oyuncukoltugusayisi = int.Parse(Console.ReadLine());

            Console.Write("televizyon sayısını giriniz: ");
            tvsayisi = int.Parse(Console.ReadLine());
            int toplam = ayakkabisayisi * ayakkabifiyati + pcsayisi * pcfiyati + oyuncukoltugusayisi * oyuncukoltugufiyati + tvsayisi * tvfiyati;
            Console.WriteLine();
            Console.WriteLine("Ödemeniz Gereken Tutar: " + toplam);
            */
            #endregion

            #region kullanıcıdan veri alma (double)

            //double sinav1, sinav2, sinav3, ortalama;

            //Console.Write("1.Sınav notunu giriniz: ");
            //sinav1 = double.Parse(Console.ReadLine());

            //Console.Write("2.Sınav notunu giriniz: ");
            //sinav2 = double.Parse(Console.ReadLine());

            //Console.Write("3.Sınav notunu giriniz: ");
            //sinav3 = double.Parse(Console.ReadLine());

            //ortalama = (sinav1 + sinav2 + sinav3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Ortalamanız: " + ortalama);

            #endregion

            #region kullanıcıdan veri alma karakter
            //char cinsiyet;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //cinsiyet = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + cinsiyet);
            #endregion

            Console.Read();
        }
    }
}
