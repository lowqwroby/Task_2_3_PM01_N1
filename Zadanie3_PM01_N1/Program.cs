using System;

namespace Variant10
{
	class Program
	{
		static void Main()
		{
			try
			{
				Console.Write("Введите начало диапазона A: ");
				int A = Convert.ToInt32(Console.ReadLine());
				Console.Write("Введите конец диапазона B: ");
				int B = Convert.ToInt32(Console.ReadLine());

				Console.Write("Введите цифру X: ");
				int X = Convert.ToInt32(Console.ReadLine());
				Console.Write("Введите цифру Y: ");
				int Y = Convert.ToInt32(Console.ReadLine());

				int i = A;

				Console.WriteLine("Цикл For: ");
				for(int j = A; j < B; j++)
				{
					if (Math.Abs(j) % 10 == X || Math.Abs(j) % 10 == Y)
					{
						Console.Write(j + " ");
					}
				}

				Console.WriteLine("\nЦикл while: ");
				while(i < B)
				{
					if (Math.Abs(i) % 10 == X || Math.Abs(i) % 10 == Y)
					{
						Console.Write(i + " ");
					}
					i++;
				}

				Console.WriteLine("\nЦикл do while: ");
				i = A;
				do
				{
					if (Math.Abs(i) % 10 == X || Math.Abs(i) % 10 == Y)
					{
						Console.Write(i + " ");
					}
					i++;
				} while (i < B);
			}
			catch
			{
				Console.WriteLine("Введены некорректные данные");
			}
		}
	}
}