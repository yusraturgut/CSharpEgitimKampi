﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
	public class Program
	{
		static void Main(string[] args)
		{
			#region For Döngüsü:for döngüsü, bir kod bloğunu belirli bir sayıda tekrarlamak için kullanılır.

			//for(x;y;z)
			//x:başlangıç
			//y:bitiş
			//z:artıi-azalış

			//int i;

			//        for (i = 1; i <= 5; i++)
			//        {
			//Console.WriteLine("C# Eğitim Kampı");
			//        }

			//for (i = 1; i <= 20; i++)
			//         {
			//	Console.WriteLine(i);
			//         }

			//for (i = 3; i <= 50; i += 3)
			//{
			//	Console.WriteLine(i);
			//}

			//Console.Write("Lütfen ekrana yazılmasını istediğinizi adedi giriniz: ");
			//int finishValue=int.Parse(Console.ReadLine());

			//         for (int i = 1; i <= finishValue; i++)
			//         {
			//             Console.WriteLine("Yaşasın Cumhuriyet!");
			//         }




			#endregion

			#region For Döngüsü ile Karar Yapıları

			//for (int i = 1; i <= 100; i++)
			//{
			//	if (i % 5 == 0)
			//	{
			//		Console.WriteLine(i);
			//	}
			//}

			//int totalValue = 0;
			//for (int i = 1; i <= 10; i++)
			//{
			//	totalValue += i;
			//}
			//Console.WriteLine(totalValue);

			//int totalValue = 0;
			//         for (int i = 1; i <20; i++)
			//         {
			//             if (i%2==0)
			//             {
			//		totalValue += i;
			//		Console.WriteLine(i);
			//             }
			//         }

			//Console.WriteLine("--------");
			//Console.WriteLine(totalValue);

			//int count = 0;
			//for (int i = 1; i <= 50; i++)
			//{
			//	if (i % 7 == 0)
			//	{
			//		count++;
			//	}
			//}
			//Console.WriteLine(count);

			//int bacterium = 1;

			//         for (int i = 1; i <=24; i++)
			//         {
			//	bacterium *= 2;
			//	Console.WriteLine(i + ".Saat Sonunda: "+bacterium);
			//         }




			#endregion

			#region While Döngüsü:while döngüsü, belirtilen bir koşul doğru olduğu sürece bir kod bloğunu tekrar tekrar çalıştırmak için kullanılır.

			//int i = 1;
			//while (i <= 10)
			//{
			//	Console.WriteLine("Merhaba Döngüler");
			//	i++;
			//}

			//int i = 1;
			//while (i <= 10)
			//{
			//	if (i % 3 == 0)
			//	{
			//		Console.WriteLine(i);
			//	}
			//	i++;
			//}

			//int i = 1;
			//int sum = 0;

			//         while (i<=10)
			//         {
			//	sum += i;
			//	i++;

			//         }
			//Console.WriteLine(sum);




			#endregion

			#region Örnek Sınav Sorusu

			//Klavyeden girilen 5 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

			//456
			//Console.Write("Sayıyı Giriniz: ");
			//int number=int.Parse(Console.ReadLine());
			//int ones, tens, hundreds;
			//int sum;

			//ones = number % 10;s
			//tens = number % 100 / 10;
			//hundreds = number / 100;

			//Console.WriteLine(ones+"-"+tens+"-"+hundreds);

			//sum =ones+tens+hundreds;
			//Console.WriteLine(sum);




			#endregion

			Console.Read();
		}
	}
}
