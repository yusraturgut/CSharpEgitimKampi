using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
	public class Program
	{
		static void Main(string[] args)

			
		{
			#region YazdırmaKomutları

			//Console.Write("Merhaba Dünnya");
			//Console.WriteLine("Selam");

			//Console.WriteLine("******* Yemek Kategorileri********");
			//Console.WriteLine();
			//Console.WriteLine("1-Çorbalar");
			//Console.WriteLine("2-Ana Yemekler");
			//Console.WriteLine("3-Soğuk Başlangıçlar");
			//Console.WriteLine("4-Salatalar");
			//Console.WriteLine("5-Tatlılar");
			//Console.WriteLine("6-İçecekler");
			//Console.WriteLine();
			//Console.WriteLine("******* Yemek Kategorileri********");

			#endregion

			#region Degiskenler //Verilerin bellekte geçici olark tutulduğu kısımdır String

			//string alfabetik türde verileri tutabildiğimiz veri türü
			//Degisken_türü değişken_adı;

			//string name;
			//name = "Yüsra";
			//Console.WriteLine(name);

			//İlk kelimenin ilk harfinin küçük ikinci kelimenin ilk harfinin büyük olarak yazılmasına CamelCasing adı verilir.
			//string customerName;
			//string customerSurname;
			//string customerPhone;
			//string customerEmail, district, city;//tanımlama yapılırken birden fazla aynı türdeki veri yan yana şekilde yazılabilir.

			//customerName = "Ali";
			//customerSurname = "Çınar";
			//customerPhone = "+90 500 451 56 23";
			//customerEmail = "deneme@gmail.com";
			//district = "Kadıköy";
			//city = "İstanbul";

			//Console.WriteLine("*** Rezervasyon Kartı ***");
			//Console.WriteLine("------------------------------");
			//Console.WriteLine("Müşteri: "+customerName+" "+ customerSurname);
			//Console.WriteLine("İletişim: " + customerPhone );
			//Console.WriteLine("Email Adresi: " + customerEmail);
			//Console.WriteLine("Adres Bilgileri: " + district+"/"+city);
			//Console.WriteLine("------------------------------");
			//Console.WriteLine();

			//customerName = "Ayşegül";
			//customerSurname = "Kaya";
			//customerPhone = "+90 500 347 54 63";
			//customerEmail = "deneme2@gmail.com";
			//district = "Üsküdar";
			//city = "İstanbul";

			//Console.WriteLine("*** Rezervasyon Kartı ***");
			//Console.WriteLine("------------------------------");
			//Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
			//Console.WriteLine("İletişim: " + customerPhone);
			//Console.WriteLine("Email Adresi: " + customerEmail);
			//Console.WriteLine("Adres Bilgileri: " + district + "/" + city);
			//Console.WriteLine("------------------------------");
			//Console.WriteLine();

			//int değişken türü sayısal türündeki değişkenlerdir.

			//int number = 24;
			//Console.WriteLine(number);

			int hamburgerPrice = 300;
			int colaPrice = 35;
			int waterPrice = 10;
			int friesPrice = 50;
			int pizzaPrice = 250;
			int lemonadePrice = 30;
			int totalPrice = 0;

			Console.WriteLine("****RestroranMeü Fiyatı****");
			Console.WriteLine();
			Console.WriteLine("-----Hamburger: " + hamburgerPrice + "TL");
			Console.WriteLine("-----Kola: " + colaPrice + "TL");
			Console.WriteLine("-----Su: " + waterPrice + "TL");
			Console.WriteLine("-----Patates Kızartması: " + friesPrice + "TL");
			Console.WriteLine("-----Pizza: " + pizzaPrice + "TL");
			Console.WriteLine("-----Limonata: " + lemonadePrice + "TL");
			Console.WriteLine();
			Console.WriteLine("****RestroranMeü Fiyatı****");
			Console.WriteLine();

			int hamburgerCount;
			int colaCount;
			int waterCount;
			int friesCount;
			int pizzaCount;
			int lemonadeCount;

			int totalHamburgerPrice = 0;
			int totalColaPrice = 0;
			int totalWaterPrice= 0;
			int totalFriesPrice = 0;
			int totalPizzaPrice = 0;
			int totalLemonadePrice = 0;

			hamburgerCount = 3;
			colaCount = 3;
			waterCount = 3;
			friesCount = 1;
			pizzaCount = 0;
			lemonadeCount = 0;

			totalHamburgerPrice = hamburgerCount * hamburgerPrice;
			totalColaPrice = colaCount * colaPrice;
			totalWaterPrice = waterCount * waterPrice;
			totalFriesPrice = friesCount * friesPrice;
			totalPizzaPrice = pizzaCount * pizzaPrice;
			totalLemonadePrice = lemonadeCount * lemonadePrice;
			totalPrice = totalHamburgerPrice + totalColaPrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

			Console.WriteLine("------------------------");
			Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
			Console.WriteLine("Kola Tutarı: " + totalColaPrice + "TL");
			Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
			Console.WriteLine("Patates Tutarı: " + totalFriesPrice + "TL");
			Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
			Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");
			Console.WriteLine("Toplam tutar: " + totalPrice + "TL");
			#endregion


			Console.Read();
		}
	}
}
