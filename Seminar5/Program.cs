/* Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */


/*
int CountNumbers(int[] array)

{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count;
}

int[] array = new int[4];
Random numbers = new Random();
for (int i = 0; i < array.Length; i++)
    array[i] = numbers.Next(100, 1000);

Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
int numCount = CountNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве: {numCount}");
*/


/* Задача 2. Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. 
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
int SumNumbers(int[] array)

{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
} 
int[] GenerateRandomNum(int size)
{
    int[] array = new int[size];
    Random numbers = new Random();

    for (int i = 0; i < size; i++)
        array[i] = numbers.Next(-100, 100);
    return array;
}

int[] array = GenerateRandomNum(4);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
int sumElements = SumNumbers(array);
Console.WriteLine($"Сумма элементов на нечетных позициях: {sumElements}");
*/

/* Задача 3. Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

/*
double [] array = new double[10];
int length = array.Length;
double result = 0;
double min = 0;
double max = 0;

void fullMass(double[] a)
{
    for (int i = 0; i < length; i++)
    {
        a[i] = Math.Round((new Random().NextDouble() * (10 - 1) + 1), 2); 
        Console.Write($"{a[i]}; ");
    }
    Console.WriteLine();
}

fullMass(array);

max = array[0];
min = array[length-1];

for (int j = 0; j < length; j++)
{
    if (max < array[j]) max = array[j];
    else if (min > array[j]) min = array[j];
}

result = Math.Round((max - min), 2);

Console.WriteLine($"Максимальное число {max}; минимально число {min}; Разность чисел = {result}");
*/