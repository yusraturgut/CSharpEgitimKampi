﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Crud-->Create-Read-Update-Delete

			Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
			Console.WriteLine();

			Console.WriteLine("--------------------");

			#region Kategori Ekleme İşlemi

			//Console.Write("Eklemek İstediğiniz Kategori Adı: ");
			//string categoryName=Console.ReadLine();

			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1QTJJBS;initial Catalog=EgitimKampiDB;integrated security=true");

			//connection.Open();
			//SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName)values (@p1)",connection);//INSERT INTO TblCategory → TblCategory tablosuna yeni bir kayıt ekler.
			//																									////(CategoryName) → CategoryName sütununa değer ekleyeceğimizi belirtir.
			//																									/////VALUES (@p1) → Eklenecek değerin @p1 adlı bir parametre olacağını belirtir.
			//command.Parameters.AddWithValue("@p1", categoryName);//p1 parametresini categoryName'e ekler.
			//command.ExecuteNonQuery();//Komutu çalıştırır.
			//connection.Close();
			//Console.WriteLine("Kategori başaryla eklendi!");
			#endregion

			#region Ürün Ekleme İşlemi

			//string productName;
			//decimal productPrice;
			////bool ProductStatus;

			//Console.Write("Ürün adı: ");
			//productName = Console.ReadLine();
			//Console.Write("Ürün Fiyatı :");
			//productPrice = decimal.Parse(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1QTJJBS;initial Catalog=EgitimKampiDB;integrated security=true");
			//connection.Open();
			//SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
			//command.Parameters.AddWithValue("@productName", productName);
			//command.Parameters.AddWithValue("@productPrice", productPrice);
			//command.Parameters.AddWithValue("@productStatus", true);
			//command.ExecuteNonQuery();
			//connection.Close();
			//Console.Write("Ürün eklemesi başarılı!");

			#endregion

			#region Ürün Listeleme İşlemi

			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1QTJJBS;initial Catalog=EgitimKampiDB;integrated security=true");
			//connection.Open();
			//SqlCommand command = new SqlCommand("SELECT * FROM TblProduct ORDER BY ProductId ASC",connection);//Veri tabanındaki verileri sıralı getiren kod.
			//SqlDataAdapter adapter = new SqlDataAdapter(command);
			//DataTable dataTable = new DataTable();
			//adapter.Fill(dataTable);
			//foreach (DataRow row in dataTable.Rows)
			//{
			//	foreach (var item in row.ItemArray)
			//	{
			//		Console.Write(item.ToString()+ " ");
			//	}
			//	Console.WriteLine();
			//}

			#endregion

			#region Ürün Silme İşlemi

			//Console.Write("Silinecek Ürün Id: ");
			//int productId = int.Parse(Console.ReadLine());
			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1QTJJBS;initial Catalog=EgitimKampiDB;integrated security=true");
			//connection.Open();

			//SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
			//command.Parameters.AddWithValue("@productId", productId);
			//command.ExecuteNonQuery();

			//connection.Close();

			//Console.WriteLine("Silme İşlemi Yapıldı!");

			#endregion

			#region Ürün Güncelleme İşlemi

			//Console.Write("Güncellenecek Ürün Id: ");
			//int productId = int.Parse(Console.ReadLine());

			//Console.Write("Güncellenecek Ürün Adı: ");
			//string productName = Console.ReadLine();

			//Console.Write("Güncellenecek Ürün Fiyatı: ");
			//decimal productPrice = decimal.Parse(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1QTJJBS;initial Catalog=EgitimKampiDB;integrated security=true");//Veritabanı bağlantısı ve getirelecek teblo adı belirtildi
			//connection.Open();
			//SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId", connection);
			//command.Parameters.AddWithValue("@productName", productName);
			//command.Parameters.AddWithValue("@productPrice", productPrice);
			//command.Parameters.AddWithValue("@productId", productId);
			//command.ExecuteNonQuery();

			//connection.Close();

			//Console.WriteLine("Güncelleme başarılı!");

			#endregion

			Console.Read();

		}
	}
}
