﻿// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CreateArrayRndInt(int size, int min, int max)
{
	int[] array = new int[size];
	Random rnd = new Random();
	for (int i = 0; i < size; i++)
	{
		array[i] = rnd.Next(min, max + 1);
	}
	return array;
}
void PrintArray(int[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write($"{array[i]},");
		else Console.Write(array[i]);
	}
	Console.Write("]");
	Console.WriteLine();
}

int [] ReturnArray ( int [] array)
{
	int[] arr = new int[array.Length];
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = array[i];
	}
	return arr;
}

int[] arr1 = CreateArrayRndInt(6, 1, 20);
PrintArray(arr1);
int[] arr2 = ReturnArray(arr1);
PrintArray(arr2);