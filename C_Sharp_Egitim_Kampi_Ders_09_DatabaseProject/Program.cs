using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Egitim_Kampi_Ders_09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************** C# Kırtasiye *****************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1 - Kategoriler");
            Console.WriteLine("2 - Ürünler");
            Console.WriteLine("3 - Siparişler");
            Console.WriteLine("4 - Çıkış");
            Console.Write("Lütfen getirme istediğiniz tabloyu giriniz: ");
            string tablono=Console.ReadLine();
            Console.WriteLine("---------------------------------");


            SqlConnection conn = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;initial Catalog=Kirtasiye; integrated security=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From TblUrunler",conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
