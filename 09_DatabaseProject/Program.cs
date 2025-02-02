using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Ado.net:C#'ta SQL sorgularını kullanmamıza yarayan kütüphane

			Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sisstemi*******");
			Console.WriteLine();
			Console.WriteLine();

			string tableNumber;
			Console.WriteLine("----------------------------");
			Console.WriteLine("1-Kategoriler");
			Console.WriteLine("2-Ürünler");
			Console.WriteLine("3-Siparişler");
			Console.WriteLine("4-Çıkış Yap");
			Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
			tableNumber = Console.ReadLine();
			Console.WriteLine("----------------------------");

			SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1QTJJBS;initial Catalog=EgitimKampiDB;integrated security=true");//Veritabanı bağlantısı ve getirelecek teblo adı belirtildi
			connection.Open();
			SqlCommand command = new SqlCommand("Select * From TblCategory", connection);//Sql Sorgusu çalıştırma
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			connection.Close();

			foreach (DataRow row in dataTable.Rows)
			{
				foreach (var item in row.ItemArray)
				{
					Console.WriteLine(item.ToString());
				}
				Console.WriteLine();
			}


			Console.Read();

			//✅ Kullanıcıdan bir tablo seçmesini ister.
			//✅ TblCategory(Kategori) tablosundaki tüm verileri alır.
			//✅ Verileri DataTable içine çeker.
			//✅ Tüm satırları konsola yazdırır.
			//✅ Programın kapanmasını engeller.

		}
	}
}
