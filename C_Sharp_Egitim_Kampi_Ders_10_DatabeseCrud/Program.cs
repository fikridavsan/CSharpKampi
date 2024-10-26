using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Egitim_Kampi_Ders_10_DatabeseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Veritabanına Kategori Ekleme İşlemi

            //Console.WriteLine("***************** C# Kırtasiye *****************");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");

            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string kategori = Console.ReadLine();


            //SqlConnection conn = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;initial Catalog=Kirtasiye; integrated security=true");
            //conn.Open();

            //SqlCommand cmd = new SqlCommand("insert into TblKategori (KategoriAdi) values (@p1)", conn);
            //cmd.Parameters.AddWithValue("@p1", kategori);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //Console.WriteLine("Başarıyla eklendi");

            #endregion

            #region Veritabanına Ürün Ekleme İşlemi

            //Console.WriteLine("***************** C# Kırtasiye *****************");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");

            //Console.Write("Eklemek istediğiniz ürünün adı: ");
            //string urun = Console.ReadLine();

            //Console.Write("Eklemek istediğiniz ürünün fiyatı: ");
            //decimal fiyat = decimal.Parse(Console.ReadLine());

            //// Console.Write("Eklemek istediğiniz ürünün durumu: ");





            //SqlConnection conn = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;initial Catalog=Kirtasiye; integrated security=true");
            //conn.Open();

            //SqlCommand cmd = new SqlCommand("insert into TblUrunler (Urunİsmi, UrunFiyati, UrunDurumu) values (@urunAdi, @urunFiyati, @Stok)", conn);
            //cmd.Parameters.AddWithValue("@urunAdi", urun);
            //cmd.Parameters.AddWithValue("@urunFiyati", fiyat);
            //cmd.Parameters.AddWithValue("@Stok",true);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //Console.WriteLine("Başarıyla eklendi");

            #endregion

            #region Veritabanına Ürün Listeleme İşlemi

            //Console.WriteLine("***************** C# Kırtasiye *****************");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");

           
            //SqlConnection conn = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;initial Catalog=Kirtasiye; integrated security=true");
            //conn.Open();

            //SqlCommand cmd = new SqlCommand("Select * from TblUrunler ", conn);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //foreach (DataRow dr in dt.Rows)
            //{
            //    foreach (var item in dr.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " - ");
            //    }
            //    Console.WriteLine();
            //}
            //conn.Close();
            #endregion

            #region Veritabanına Ürün Silme İşlemi

            //void listeleme()
            //{
            //    SqlConnection conn = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;initial Catalog=Kirtasiye; integrated security=true");
            //    conn.Open();

            //    SqlCommand cmd = new SqlCommand("Select * from TblUrunler ", conn);
            //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    adapter.Fill(dt);

            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        foreach (var item in dr.ItemArray)
            //        {
            //            Console.Write(item.ToString() + " - ");
            //        }
            //        Console.WriteLine();
            //    }
            //    conn.Close();
            //}

            //Console.WriteLine("***************** C# Kırtasiye *****************");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //listeleme();
            //Console.WriteLine();
            //Console.Write("Silmek İstediğniz Ürün Numarasını Giriniz: ");
            //int urunNo=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;initial Catalog=Kirtasiye; integrated security=true");
            //connection.Open();

            //SqlCommand command= new SqlCommand("Delete From TblUrunler Where UrunId=@urunNo", connection);
            //command.Parameters.AddWithValue("urunNo", urunNo);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün Başarıyla Silindi");
            //listeleme();

            #endregion

            #region Veritabanına Ürün Güncellem İşlemi

            void listeleme()
            {
                SqlConnection conn = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;initial Catalog=Kirtasiye; integrated security=true");
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from TblUrunler ", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    foreach (var item in dr.ItemArray)
                    {
                        Console.Write(item.ToString() + " - ");
                    }
                    Console.WriteLine();
                }
                conn.Close();
            }

            Console.WriteLine("***************** C# Kırtasiye *****************");
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            listeleme();
            Console.WriteLine();
            Console.Write("Güncellemek İstediğniz Ürün Numarasını Giriniz: ");
            int urunNo = int.Parse(Console.ReadLine());

            
            Console.WriteLine();

            Console.Write("Güncellemek İstediğniz Ürün Adını Giriniz: ");
            string urunAdi=Console.ReadLine();
            Console.Write("Güncellemek İstediğniz Ürün Fiyatını Giriniz: ");
            decimal UrunFiyatı=decimal.Parse(Console.ReadLine());


            SqlConnection connection = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;initial Catalog=Kirtasiye; integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Update TblUrunler Set Urunİsmi=@urunIsmi, UrunFiyati=@UrunFiyatı where UrunId=@urunId", connection);

            command.Parameters.AddWithValue("@urunId", urunNo);
            command.Parameters.AddWithValue("@urunIsmi", urunAdi);
            command.Parameters.AddWithValue("@UrunFiyatı", UrunFiyatı);

            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Ürün Başarıyla Güncellendi");
            listeleme();

            #endregion

            Console.Read();
        }
    }
}
