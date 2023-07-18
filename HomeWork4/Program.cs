/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
﻿int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void IsNum(int number, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result = number * result;
    }
    Console.WriteLine($"Oтвет {result}");
}

int number = Input("Введите число ");
int degree = Input("Введите степень ");
IsNum(number, degree);
*/

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Input("Введите число: ");

int sum = 0;
while (number > 0)
{
    sum = sum + number % 10;
    number = number / 10;
}
Console.WriteLine(sum);
*/

/*
Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
Разработать метод CreateArray(int size), 
генерирующий массив на основе данных, вводимых пользователем.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/*
int InPut (string message) 
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size)
{
    int[]array = new int [size];
    for(int i=0; i < size; i++)
    array[i] = InPut($"Введите число массива под индексом {i}");
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int length = InPut ("Введите количество элементов в массиве");

int[] myArray = CreateArray(length);
ShowArray(myArray);
*/