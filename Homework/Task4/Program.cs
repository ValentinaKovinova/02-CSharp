// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.


Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0)
{
    Console.WriteLine($"Некорректный ввод");
    return;
}
else
{
    while (num > 0)
    {
        int remain = num / 10;
        if (remain > 0)
        { Console.Write($"{num % 10}, "); }
        else
        { Console.Write(num % 10); }
        num /= 10;
    }
}