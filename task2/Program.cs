// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

int Sum(int a, int b, int sum)
{
    if (a <= b){
        sum = sum + a;
        a++;
        return Sum(a, b, sum);
    }
    return sum; 
} 
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
int sum = 0;
Console.WriteLine($"Число равно {Sum(a, b, sum)}");