<font color = lightblue>

## Задача 1: 

___
<font color = white>

Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

```sh
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int remainDiv7 = num % 7;
int remainDiv23 = num % 23;

if (remainDiv7 == 0 && remainDiv23 == 0)
{
    Console.WriteLine($"Число {num} кратно одновременно числам 7 и 23");
}
else
{
    Console.WriteLine($"Число {num} не кратно одновременно числам 7 и 23");
}
```

<font color = lightblue>

## Задача 2: 

___
<font color = white>

Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

```sh
Console.Write("Введите, отличную от 0, координату точки по оси X (дробное число пишется со знаком «,»): ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите, отличную от 0, координату точки по оси Y (дробное число пишется со знаком «,»): ");
double y = Convert.ToDouble(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine($"Точка с координатами ({x};{y}) находится в четверти номер I");
}
if (x < 0 && y > 0)
{
    Console.WriteLine($"Точка с координатами ({x};{y}) находится в четверти номер II");
}
if (x < 0 && y < 0)
{
    Console.WriteLine($"Точка с координатами ({x};{y}) находится в четверти номер III");
}
if (x > 0 && y < 0)
{
    Console.WriteLine($"Точка с координатами ({x};{y}) находится в четверти номер IV");
}
if (x == 0 || y == 0)
{
    Console.WriteLine($"Некорректный ввод");
}
```