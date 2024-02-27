using System;
using System.Collections.Generic;
using System.IO;

namespace ClassLibraryForArray
{
	public class IntArray
	{
		// ЗАКРЫТЫЕ ПОЛЯ.
		int[] a; // Закрытый одномерный массив.
		int length; // Закрытая длина.

		// КОНСТРУКТОРЫ.
		public IntArray(int length) // Конструктор 1 для создания массива заданной длины length.
		{
			a = new int[length]; // Новый массив.
			Length = length;
		}

		public IntArray(params int[] arr) // Конструктор 2 с переменным числом параметров.
		{
			a = arr; // Массив из массива параметров.
			Length = arr.Length;
		}

		// СВОЙСТВА.
		public int Length // Свойство Длина массива.
		{
			get => length;
			set
			{
				if (value > 0)
				{
					length = value;
				}
			}
		}

		public int this[int i] // Индексатор.
		{
			get
			{
				if (i >= 0 && i < Length)
				{
					return a[i];
				}
				return -1;
			}
			set
			{
				if (i >= 0 && i < Length)
				{
					a[i] = value;
				}
			}
		}

		// МЕТОДЫ.
		public static IntArray RandomIntArray(int length, int a, int b) // Создание массива длины length и заполнение его случайными целыми числами в диапазоне от a до b.
		{
			IntArray arr = new IntArray(length);
			Random ran = new Random();
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = ran.Next(a, b + 1); // Случайное число от a до b включительно.
			}
			return arr;
		}

		public static IntArray ArrayFromTextFile(string fileName) // Ввод массива из текстового файла с именем filename.
		{
			List<int> nums = new List<int>(); // Т.к. не знаем длину массива, используем неограниченный список.
			try
			{
				using (StreamReader reader = new StreamReader(fileName)) // Поток для чтения из файла.
				{
					string line;
					while ((line = reader.ReadLine()) != null) // Пока файл не закончился, считывать строку.
					{
						nums.Add(Convert.ToInt32(line));
					}
				}
			}
			catch
			{
				return null;
			}

			IntArray arr = new IntArray(nums.ToArray()); // Конструктор 2.
			return arr;
		}

		public static void ArrayToTextFile(IntArray arr, string fileName) // Вывод массива arr в текстовый файл с именем filename.
		{
			using (StreamWriter writer = new StreamWriter(fileName)) // Поток для записи в файл.
			{
				for (int i = 0; i < arr.Length; i++)
				{
					writer.WriteLine(arr[i]);
				}
			}
		}

		public static int SumArray(IntArray arr) // Вычисление суммы элементов массива arr.
		{
			int sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
			}
			return sum;
		}

		// ОПЕРАТОРЫ.
		public static IntArray operator ++(IntArray arr) // ++: инкремент: увеличение на 1 всех элементов массива.
		{
			IntArray sum = new IntArray(arr.Length);
			for (int i = 0; i < sum.Length; i++)
			{
				sum[i] = arr[i] + 1;
			}
			return sum;
		}

		public static IntArray operator +(IntArray x, int y) // +: сложение массива x со скаляром y.
		{
			IntArray sum = new IntArray(x.Length);
			for (int i = 0; i < sum.Length; i++)
			{
				sum[i] = x[i] + y;
			}
			return sum;
		}

		public static IntArray operator +(int x, IntArray y) // +: сложение скаляра x с массивом y.
		{
			IntArray sum = new IntArray(y.Length);
			for (int i = 0; i < sum.Length; i++)
			{
				sum[i] = x + y[i];
			}
			return sum;
		}

		public static IntArray operator +(IntArray x, IntArray y) // +: сложение двух массивов x и y.
		{
			// Нужно предусмотреть разницу длин: [ 1, 2 ] + [ 1, 2, 3 ] = [ 2, 4, 3 ]

			int minLength = Math.Min(x.Length, y.Length); // Наименьшая длина.
			IntArray max = x.Length > y.Length ? x : y; // Наибольший массив.
			IntArray sum = new IntArray(max.Length); // Используем наибольшую длину, чтобы не выйти за границы массива.

			for (int i = 0; i < minLength; i++) // Пока не закончился наименьший массив, складываем.
			{
				sum[i] = x[i] + y[i];
			}
			for (int i = minLength; i < max.Length; i++) // Когда наименьший массив закончился, просто используем оставшиеся элементы.
			{
				sum[i] = max[i];
			}
			return sum;
		}

		public static IntArray operator --(IntArray arr) // --: декремент: уменьшение на 1 всех элементов массива.
		{
			IntArray diff = new IntArray(arr.Length);
			for (int i = 0; i < diff.Length; i++)
			{
				diff[i] = arr[i] - 1;
			}
			return diff;
		}

		public static IntArray operator -(IntArray x, int y) // -: вычитание из массива x скаляра y (x - y).
		{
			IntArray diff = new IntArray(x.Length);
			for (int i = 0; i < diff.Length; i++)
			{
				diff[i] = x[i] - y;
			}
			return diff;
		}

		public static IntArray operator -(int x, IntArray y) // -: вычитание из скаляра x массива y (x - y).
		{
			IntArray diff = new IntArray(y.Length);
			for (int i = 0; i < diff.Length; i++)
			{
				diff[i] = x - y[i];
			}
			return diff;
		}

		public static IntArray operator -(IntArray x, IntArray y) // -: вычитание из массива x массива y (x - y).
		{
			// Нужно предусмотреть разницу длин: [ 1, 2 ] - [ 1, 2, 3 ] = [ 0, 0, -3 ]

			int minLength = Math.Min(x.Length, y.Length); // Наименьшая длина.
			IntArray max = x.Length > y.Length ? x : y; // Наибольший массив.
			IntArray diff = new IntArray(max.Length); // Используем наибольшую длину, чтобы не выйти за границы массива.

			for (int i = 0; i < minLength; i++) // Пока не закончился наименьший массив, вычитаем.
			{
				diff[i] = x[i] - y[i];
			}
			for (int i = minLength; i < max.Length; i++) // Когда наименьший массив закончился, просто используем оставшиеся элементы.
			{
				diff[i] = 0 - max[i]; // Элемент будет отрицательным.
			}
			return diff;
		}
	}
}