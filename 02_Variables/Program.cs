using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
	public class Program
	{
		static void Main(string[] args)
		{
			#region Double Değişkenler 
			////double number; //Double değişkeni ondalıklı sayılar tanımlanacağı zaman kullanılır.
			////number = 4.85;
			////Console.WriteLine(number);

			//Console.WriteLine("*****Fiyat Listesi*****");
			//Console.WriteLine();

			//double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
			//applePrice = 14.85;
			//orangePrice = 20.95;
			//strawberryPrice = 45;
			//potatoPrice = 9.74;
			//tomatoPrice = 6.88;

			//Console.WriteLine("----Elma Birim Fiyatı: " + applePrice + "TL");
			//Console.WriteLine("----Portakal Birim Fiyatı: " + orangePrice + "TL");
			//Console.WriteLine("----Çilek Birim Fiyatı: " + strawberryPrice + "TL");
			//Console.WriteLine("----Patates Birim Fiyatı: " + potatoPrice + "TL");
			//Console.WriteLine("----Domates Birim Fiyatı: " + tomatoPrice + "TL");
			//Console.WriteLine();

			//double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

			//appleGram = 1.245;
			//orangeGram = 2.650;
			//strawberryGram = 0.750;
			//potatoGram = 4.859;
			//tomatoGram = 3.745;

			//double appleTotalPrice = applePrice * appleGram;
			//double orangeTotalPrice = orangePrice * orangeGram;
			//double strawberryTotalPrice=strawberryPrice * strawberryGram;
			//double potatoTotalPrice=potatoPrice * potatoGram;
			//double tomatoTotalPrice=tomatoPrice * tomatoGram;
			//double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

			//Console.WriteLine("Toplam Elma Fiyatı: " + appleTotalPrice + "TL");
			//Console.WriteLine("Toplam Portakal Fiyatı: " + orangeGram + "Tl");
			//Console.WriteLine("Toplam Çilek Fiyatı: " + strawberryTotalPrice + "Tl");
			//Console.WriteLine("Toplam Patates Fiyatı: " + potatoTotalPrice + "Tl");
			//Console.WriteLine("Toplam Domates Fiyatı: " + tomatoTotalPrice + "Tl");
			//Console.WriteLine("Toplam Tutar: "+totalPrice);

			#endregion

			#region Char Değişkenler
			//char symbol; //Char değişken türü tek bir karakter saklamak için kullanılan veri türüdür.
			//symbol = 'a';
			//Console.WriteLine(symbol);

			#endregion

			#region Klavyeden Veri Girişleri String Değişkenler

			//Console.WriteLine("****CSharp Hava Yolları Yolcu Bilgisi");
			//Console.WriteLine();

			//string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

			//Console.Write("Yolcu Adı: ");
			//passengerName =Console.ReadLine();

			//Console.Write("Yolcu Soyadı: ");
			//passengerSurname = Console.ReadLine();

			//Console.Write("İlçe Bilgisi: ");
			//passengerDistrict = Console.ReadLine();

			//Console.Write("Şehir Bilgisi: ");
			//passengerCity = Console.ReadLine();

			//Console.Write("Yolcu Yaşı: ");
			//passengerAge = Console.ReadLine();

			//Console.Write("Yolcu Numarası: ");
			//passengerIdentityNumber = Console.ReadLine();

			//Console.WriteLine();

			//Console.WriteLine("------------------");
			//Console.WriteLine(
			//		"Yolcu \n" +
			//		"Yolcu Adı: " + passengerName + "\n" +
			//		"Yolcu Soyadı: " + passengerSurname + "\n" +
			//		"İlçe Bilgisi: " + passengerDistrict + "\n" +
			//		"Şehir Bilgisi: " + passengerCity + "\n" +
			//		"Yolcu Yaşı: " + passengerAge + "\n" +
			//		"Yolcu Numarası: " + passengerIdentityNumber
			//                             );



			#endregion

			#region Klavyeden Tam Sayı Girişleri ve Dönüşümler 

			//int shoesPrice, computerPrice, chairPrice, tvPrice;
			//shoesPrice = 1000;
			//computerPrice = 20000;
			//chairPrice = 5000;
			//tvPrice = 12000;

			//int shoesCount, computerCount, chairCount, tvCount;
			//Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz:");
			//shoesCount=int.Parse(Console.ReadLine());

			//Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz:");
			//computerCount=int.Parse(Console.ReadLine());

			//Console.Write("Lütfen aldığınız koltuk sayısını giriniz:");
			//chairCount=int.Parse(Console.ReadLine());

			//Console.Write("Lütfen aldığınız televizyon sayısını giriniz:");
			//tvCount=int.Parse(Console.ReadLine());

			//int totalPrice=shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
			//Console.WriteLine();
			//Console.WriteLine("Toplam Ödemeniz Gereken Tutar: "+totalPrice);

			#endregion

			#region Klavyeden Ondalıklı sayı İşlemleri

			//double exam1, exam2, exam3,result ;

			//Console.WriteLine("Lütfen 1.Sınav notunu giriniz: ");
			//exam1 =double.Parse(Console.ReadLine());

			//Console.WriteLine("Lütfen 2.Sınav notunu giriniz: ");
			//exam2 = double.Parse(Console.ReadLine());

			//Console.WriteLine("Lütfen 3.Sınav notunu giriniz: ");
			//exam3 = double.Parse(Console.ReadLine());

			//result=(exam1+exam2+exam3)/3;

			//Console.WriteLine();
			//Console.WriteLine("Sınav Ortalamanız:"+result);

			#endregion

			#region Klavyeden Karakter Girişleri

			//char gender;
			//Console.WriteLine("Lütfen Cinsiyet seçiniz:");
			//gender =char.Parse(Console.ReadLine());

			//Console.WriteLine("Seçtiğiniz Cinsiyet: "+gender);

			#endregion


			Console.Read();


			
		}
	}
}
