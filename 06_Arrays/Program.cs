﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
	public class Program
	{
		static void Main(string[] args)
		{

			#region Temel Dizi Örnekleri
			////DeğişkenTürü[] DiziAdı=new DeğişkenTürü[ElemanSayısı]
			//string[] colors = new string[4];
			//colors[0] = "Kırmızı";
			//colors[1] = "Sarı";
			//colors[2] = "Beyaz";
			//colors[3] = "Mavi";

			//Console.WriteLine(colors[2]);

			//string[] cities = new string[5];

			//cities[0] = "Milano";
			//cities[1] = "Budapeşte";
			//cities[2] = "Lion";
			//cities[3] = "Kahire";
			//cities[4] = "Üsküp";

			//Console.WriteLine(cities[4]);

			//int[] numbers = new int[10];
			//numbers[0] = 50;
			//numbers[1] = 48;
			//numbers[2] = 698;
			//numbers[3] = 24;
			//numbers[7] = 748;

			//Console.WriteLine(numbers[5]);//indeks tanımlanmazsa o indeksin default değeri 0 olaraak tanımlanır.

			//string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

			//Console.WriteLine(cities[2]);




			#endregion

			#region Dizideki Tüm Elemanları Listeleme
			//string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };
			//for (int i = 0; i < colors.Length; i++)
			//{
			//	Console.WriteLine(colors[i]);
			//}

			//int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520, 7456, 2365, 1120 };
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	if (numbers[i] % 3 == 0)
			//	{
			//		Console.WriteLine(numbers[i]);
			//	}
			//}

			//char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
			//for (int i = 0; i < symbols.Length; i++)
			//{
			//	Console.WriteLine(symbols[i]);
			//}

			//int[] myArray = { 47, 85, 95, 41, 25, 789, 86, 100 };
			//int maxNumber=myArray[0];
			//for (int i = 0; i < myArray.Length; i++)//Sırasaıyla tüm elemanlar bizim tanımladığımız maxNumber değişkeni ile karşılaştırılıp kontrol edildikten sonra true değeri dönerse yeni maxNumber değeri o oluyor.
			//{
			//	if (myArray[i] > maxNumber)
			//	{
			//		maxNumber = myArray[i];
			//	}
			//}
			//Console.WriteLine(maxNumber);

			//string[] persons = { "Ali", "Ahmet", "Ayşe", "Buse", "Cem", "Deniz" };
			//Console.WriteLine(persons.Length);//Dizinin uzunluğunu verir.

			//int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
			//Array.Sort(numbers);//Diziyi sıralar.
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.WriteLine(numbers[i]);
			//}

			//int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
			//Array.Reverse(numbers);//Diziyi ters çevirir.
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.WriteLine(numbers[i]);
			//}




			#endregion

			#region Dizi Metotları

			//string[] customer = { "Ali","Buse","Ayşegül","Merve","Çınar","Kaya"};
			//int index = Array.IndexOf(customer, "Merve");//Aranan dizi elemanının kaçıncı index'te olduğunu bulmaaya yarar.
			//Console.WriteLine(index);

			//int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
			//Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük Elemanı: " + numbers.Min());//Dizinin en küçük ve en büyük elemanını bulma.

			#endregion

			#region Kullanıcıdan Değer Alma

			//string[] cities = new string[5];

			//for (int i = 0; i < cities.Length; i++)
			//{
			//	Console.Write($"Lütfen {i + 1}.Şehri Giriniz: ");
			//	cities[i] = Console.ReadLine();
			//}
			//Console.WriteLine();
			//Console.WriteLine("-------------");

			//for (int i = 0; i < cities.Length; i++)
			//{
			//	Console.WriteLine(cities[i]);
			//}

			//int[] numbers = { 10, 20, 30, 40, 50 };
			//int sum = 0;
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	sum += numbers[i];
			//}
			//Console.WriteLine(sum);

			//int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

			//Console.WriteLine("Çift Sayılar");

			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	if (numbers[i] % 2 == 0)
			//	{
			//		Console.WriteLine(numbers[i]);
			//	}
			//}

			//Console.WriteLine("Tek Sayılar");

			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	if (numbers[i] % 2 == 1)
			//	{
			//		Console.WriteLine(numbers[i]);
			//	}
			//}



			#endregion


			Console.Read();
		}
	}
}
