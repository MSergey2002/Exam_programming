// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());

Recursive(n);
Console.Read();

void Recursive(int num)
{
    if (num > 0)
    {
        Console.Write(num + " ");
        Recursive(num - 1);
    }
    else return;
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

//  int GetSum(int m, int n)
// {
//     if (n > m)
//         return n + GetSum(m, n - 1);
//     return m;
// }

// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// void PrintData(string msg, int res)
// {
//     Console.WriteLine(msg + res);
// }

// int m = ReadData("Input M: ");
// int n = ReadData("Input N: ");

// int sum = GetSum(m,n);

// PrintData("Summ elements from М to N -> ",sum);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Ackkermann(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return Ackkermann(m - 1, 1);
//     }
//     else
//     {
//         return Ackkermann(m - 1, Ackkermann(m, n - 1));
//     }
// }
// System.Console.WriteLine(Ackkermann(2, 3));
// System.Console.WriteLine(Ackkermann(3, 2));