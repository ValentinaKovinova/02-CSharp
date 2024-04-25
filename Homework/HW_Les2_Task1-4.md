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