﻿// Задача 58:
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateIntMatrix(int row, int col, int min, int max)
{
	int[,] matrix = new int[row, col];
	var rnd = new Random();

	for (int i = 0; i < row; i++)
	{
		for (int j = 0; j < col; j++)
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
		Console.Write("[");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
			else Console.Write($"{matrix[i, j],3}");
		}
		Console.Write("]");
		Console.WriteLine();
	}
}

int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
{
	int[,] matrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

	for (int k = 0; k < matrix.GetLength(0); k++)
	{
		for (int i = 0; i < matrix.GetLength(1); i++)
		{
			int sum = default;
			for (int j = 0; j < matrixA.GetLength(1); j++)
			{
				sum += matrixA[k, j] * matrixB[j, i];
			}
			matrix[k, i] = sum;
		}
	}

	return matrix;
}

int[,] matrix1 = CreateIntMatrix(4, 2, 1, 9);
int[,] matrix2 = CreateIntMatrix(2, 3, 1, 9);

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
	Console.WriteLine("Первая матрица: \n");

	PrintMatrix(matrix1);

	Console.WriteLine("\nВторая матрица: \n");

	PrintMatrix(matrix2);

	Console.WriteLine("\nПроизведение двух матриц: \n");

	int[,] matr = MultiplyMatrices(matrix1, matrix2);
	PrintMatrix(matr);
}
else Console.WriteLine("Умножение матриц невозможно");