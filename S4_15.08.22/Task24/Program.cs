﻿// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int sum = default; // равен 0

// for (int i = 1; i <= num; i++)
// {
// 	sum += i; //sum = sum +i
// }
// Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");

int SumNumbers(int number)
{
	int sum = 0;
	for (int i = 1; i <= number; i++)
	{
		sum += i;
	}
	return sum;
}
int result = SumNumbers(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {result}");