using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Egitim_Kampi_Ders_03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ifelse

            //Console.Write("Şifreyi giriniz: ");
            //string sifre;
            //sifre=Console.ReadLine();

            //if (sifre == "123456")
            //{
            //    Console.WriteLine("Şifreniz Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifreniz Yanlış");
            //}

            //string baskent, ulke;


            //Console.Write("Başkenti Giriniz: ");
            //baskent = Console.ReadLine();

            //Console.Write("Ülke Giriniz: ");
            //ulke = Console.ReadLine();

            //if (baskent == "Ankara" & ulke == "Türkiye")
            //    Console.Write("Veriler doğru");
            //else
            //    Console.Write("Veriler yanlış");


            //int sayi;

            //Console.Write("Sayıyı giriniz: ");
            //sayi=int.Parse(Console.ReadLine());

            //if (sayi == 7)
            //    Console.WriteLine("Sayı Doğru");
            //else
            //    Console.WriteLine("Sayı yanlış");

            //int sinav1, sinav2, sinav3, ortalama;
            //string sonuc="";

            //Console.Write("1. Sınav Notunu Giriniz: ");
            //sinav1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sınav Notunu Giriniz: ");
            //sinav2 = int.Parse(Console.ReadLine());

            //Console.Write("3. Sınav Notunu Giriniz: ");
            //sinav3 = int.Parse(Console.ReadLine());

            //ortalama = (sinav1 + sinav2 + sinav3) / 3;
            //Console.Write(ortalama);


            //if (ortalama > 0 & ortalama <= 50)
            //    sonuc = "Başarısız";

            //if (ortalama > 50 & ortalama <= 70)
            //    sonuc = "Orta";

            //if (ortalama > 70 & ortalama <= 90)
            //    sonuc = "İyi";

            //if (ortalama > 90)
            //    sonuc = "Pekiyi";


            //Console.WriteLine(sonuc);

            //string sehir;

            //Console.Write("Lütfen Şehri Seçiniz: ");
            //sehir = Console.ReadLine();

            //if (sehir == "Adana" | sehir == "Malatya" | sehir == "İstanbul" | sehir == "Bursa")
            //    Console.WriteLine("Şehir mevcut");
            //else
            //    Console.WriteLine("Şehir mevcut değil");

            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string kullaniciadi=Console.ReadLine();

            //if (kullaniciadi != "admin")
            //{
            //    Console.WriteLine("Bu kullancı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}

            #endregion

            #region modlar

            //int sayi = 27;
            //int modu = sayi % 8;
            //Console.WriteLine(modu);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int sayi1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int sayi2=int.Parse(Console.ReadLine());

            //int sonuc=sayi1 % sayi2;
            //Console.WriteLine(sonuc);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());

            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}

            #endregion

            #region char ile karar yapısı


            //char takım;
            //Console.Write("Lütfen takımınız ilk harfini giriniz: ");
            //takım=char.Parse(Console.ReadLine());

            //if (takım == 'f' | takım == 'F')
            //    Console.WriteLine("Fenerbahçe");
            //if (takım == 'g' | takım == 'G')
            //    Console.WriteLine("Galatasaray");
            //if (takım == 'b' | takım == 'B')
            //    Console.WriteLine("Beşiktaş");

            #endregion

            #region örnek proje
            /*
            Console.WriteLine("**** Kırtasiye Ürünleri ****");
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("1-Kalemler");
            Console.WriteLine("2-Defterler");
            Console.WriteLine("3-Silgiler");
            Console.WriteLine("4-Soru Bankaları");
            Console.WriteLine("5-Romanlar");
            Console.WriteLine("------------------");

            string ozellikler;
            Console.WriteLine("Detayını görmek istedğiniz ürünün numarasını giriniz: ");
            ozellikler = Console.ReadLine();

            if (ozellikler == "1")
            {
                Console.WriteLine();
                Console.WriteLine("**** Kalemler ****");
                Console.WriteLine();
                Console.WriteLine("1-Dolma Kalem");
                Console.WriteLine("2-Tükenmez Kalem");
                Console.WriteLine("3-Versatil Kalem");
                Console.WriteLine("4-Kurşun Kalem");
                Console.WriteLine("5-Roller Kalem");
                Console.WriteLine();
                Console.WriteLine("**** Kalemler ****");
            }
            if (ozellikler == "2")
            {
                Console.WriteLine();
                Console.WriteLine("**** Defterler ****");
                Console.WriteLine();
                Console.WriteLine("1-Resim Defteri");
                Console.WriteLine("2-Müzik Defteri");
                Console.WriteLine("3-Not Defteri");
                Console.WriteLine("4-Spiralli Bölmeli Defter");
                Console.WriteLine("5-Ciltli Bölmeli Defter");
                Console.WriteLine();
                Console.WriteLine("**** Defterler ****");
            }
            if (ozellikler == "3")
            {
                Console.WriteLine();
                Console.WriteLine("**** Silgiler ****");
                Console.WriteLine();
                Console.WriteLine("1-Plastik Silgiler");
                Console.WriteLine("2-Sakız Silgiler");
                Console.WriteLine("3-Hamur Silgiler");
                Console.WriteLine("4-Fırça Silgiler");
                Console.WriteLine("5-Sıvı  Silgiler");
                Console.WriteLine();
                Console.WriteLine("**** Silgiler ****");
            }
            if (ozellikler == "4")
            {
                Console.WriteLine();
                Console.WriteLine("**** Soru Bankaları ****");
                Console.WriteLine();
                Console.WriteLine("1-Matematik Soru Bankaları");
                Console.WriteLine("2-Fizik Soru Bankaları");
                Console.WriteLine("3-Kimya Soru Bankaları");
                Console.WriteLine("4-Biyoloji Soru Bankaları");
                Console.WriteLine("5-Türk Dili ve Edebiyatı Soru Bankaları");
                Console.WriteLine();
                Console.WriteLine("**** Soru Bankaları ****");
            }
            if (ozellikler == "5")
            {
                Console.WriteLine();
                Console.WriteLine("**** Romanlar ****");
                Console.WriteLine();
                Console.WriteLine("1-Dünya Edebiyatı");
                Console.WriteLine("2-Türk Edebiyatı");
                Console.WriteLine("3-Polisye");
                Console.WriteLine("4-Bilim Kurgu");
                Console.WriteLine("5-Tarihi Roman");
                Console.WriteLine();
                Console.WriteLine("**** Romanlar ****");
            }
            */
            #endregion

            #region Switch Case

            //int aysayisi;
            //Console.Write("Lütfen ay girişi yapınız: ");
            //aysayisi=int.Parse(Console.ReadLine());

            //switch (aysayisi)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("hatalı giriş yaptınız"); break;
            //}




            #endregion

            #region Switch Case Hesap Makinesi

            int sayi1, sayi2, sonuc;
            char sembol;

            Console.Write("Lütfen birinci sayıyı giriniz: ");
            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            sayi2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen işlemi giriniz: ");
            sembol = char.Parse(Console.ReadLine());

            switch (sembol)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine(sonuc);
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine(sonuc);
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine(sonuc);
                    break;
                case '/':
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine(sonuc);
                    break;
                default: Console.WriteLine("Hatalı işlem girdiniz"); break;
            }

            #endregion

            Console.Read();
        }
    }
}
