﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
	int[,] matrix = new int[row, col];
	Random rnd = new Random();

	for (int i = 0; i < matrix.GetLength(0); i++) // строки
	{
		for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
		{
			matrix[i, j] = rnd.Next(min, max + 1);
		}
	}
	return matrix;
}
void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write( $"{matrix[i, j]} ");
		}
		Console.WriteLine();
	}
}

void MatrixRowsElemDescending(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			for (int k = 0; k < matrix.GetLength(1) - 1; k++)
			{
				if (matrix[i, k] < matrix[i, k + 1])
				{
					int min = matrix[i, k + 1];
					matrix[i, k + 1] = matrix[i, k];
					matrix[i, k] = min;
				}
			}
		}
	}
}

int[,] matr = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matr);
Console.WriteLine();
MatrixRowsElemDescending(matr);
PrintMatrix(matr);
