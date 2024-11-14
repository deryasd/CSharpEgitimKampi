using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud --> Create - Read - Update - Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("------------------------");


            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-FDKFGC2;initial Catalog=EgitimKampiDb;integrated security=true");

            //sqlConnection.Open();

            //SqlCommand cmd = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", sqlConnection);

            //cmd.Parameters.AddWithValue("@p1", categoryName);
            //cmd.ExecuteNonQuery();
            //sqlConnection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi.");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-FDKFGC2;initial Catalog=EgitimKampiDb;integrated security=true");
            //sqlConnection.Open();

            //SqlCommand cmd = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)",sqlConnection);

            //cmd.Parameters.AddWithValue("productName", productName);
            //cmd.Parameters.AddWithValue("productPrice", productPrice);
            //cmd.Parameters.AddWithValue("productStatus", true);
            //cmd.ExecuteNonQuery();
            //sqlConnection.Close();

            //Console.WriteLine("Ürün eklemesi başarılı");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-FDKFGC2;initial Catalog=EgitimKampiDb;integrated security=true");

            //sqlConnection.Open();
            //SqlCommand cmd = new SqlCommand("Select * From TblProduct", sqlConnection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //sqlConnection.Close();

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var col in row.ItemArray)
            //    {
            //        Console.Write(col.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-FDKFGC2;initial Catalog=EgitimKampiDb;integrated security=true");
            //sqlConnection.Open();
            //SqlCommand cmd = new SqlCommand("Delete From TblProduct Where ProductId=@productId",sqlConnection);

            //cmd.Parameters.AddWithValue("@productId",productId);
            //cmd.ExecuteNonQuery();
            //sqlConnection.Close();

            //Console.WriteLine("Ürün başarıyla silindi.");
            #endregion


            #region Ürün Güncelleme İşlemi

            Console.Write("Güncellenecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());


            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-FDKFGC2;initial Catalog=EgitimKampiDb;integrated security=true");
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId ", sqlConnection);
            cmd.Parameters.AddWithValue("@productName", productName);
            cmd.Parameters.AddWithValue("@productPrice", productPrice);
            cmd.Parameters.AddWithValue("@productId", productId);
            cmd.ExecuteNonQuery();

            sqlConnection.Close();

            Console.WriteLine("Ürün başarıyla güncellendi.");

            #endregion


            Console.Read();
        }
    }
}
