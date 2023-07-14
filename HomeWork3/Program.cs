/*
Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*
bool IsNumberAPalindrome(int number)
    {
        string numberString = number.ToString();
        int length = numberString.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (numberString[i] != numberString[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
    if (IsNumberAPalindrome(number))
        {
            Console.WriteLine("Число является палиндромом.");
        }
    else
        {
            Console.WriteLine("Число не является палиндромом.");
        }
        */
        


// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double R3D (int x1, int y1, int z1, int x2, int y2, int z2)
{
    int A = x1 - x2;
    int B = y1 - y2;
    int C = z1 - z2;
    double lenght = Math.Sqrt(A * A + B * B + C * C);
    return lenght;
}

int ReadLine(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ReadLine("Введите координату первой точки x: ");
int y1 = ReadLine("Введите координату первой точки y: ");
int z1 = ReadLine("Введите координату первой точки z: ");
int x2 = ReadLine("Введите координату второй точки x: ");
int y2 = ReadLine("Введите координату второй точки y: ");
int z2 = ReadLine("Введите координату второй точки z: ");

Console.WriteLine(R3D(x1, y1, z1, x2, y2, z2));
*/

/* Задача 3.Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.
4
1 - 1
2 - 8
3 - 27
4 - 64
*/

/*
 Console.WriteLine ("Введите число: ");
 int num = Convert.ToInt32 (Console.ReadLine());
 
 for (int i = 1; i <= num; i++)
 {
    Console.WriteLine($"{Math.Pow(i, 3)} ");
 }
 */