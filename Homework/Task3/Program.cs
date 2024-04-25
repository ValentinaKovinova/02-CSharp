// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

Console.Write("Введите, целое число из отрезка [10, 99]): ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 || num < 10)
{
    Console.WriteLine($"Некорректный ввод");
    return;
}
else
{
    int firstDigit = num/10;
    int secondDigit = num%10;
    if (firstDigit > secondDigit)
    {
        Console.WriteLine($"Наибольшая цифра числа {num} = {firstDigit}");
    }
if (firstDigit < secondDigit)
    {
        Console.WriteLine($"Наибольшая цифра числа {num} = {secondDigit}");
    }if (firstDigit == secondDigit)
    {
        Console.WriteLine($"Цифры числа {num} равны");
    }
}