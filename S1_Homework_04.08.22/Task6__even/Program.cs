﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//
//4->да
//- 3->нет
//7->нет

Console.WriteLine("Проверка числа на четность");
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число " + number + " четное?");
if(number % 2 == 0){
	Console.Write("Ответ: Да");
}
else {
	Console.Write("Ответ: Нет");
}