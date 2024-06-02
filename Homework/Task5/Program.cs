// Задайте массив. Напишите программу, которая определяет, присутсвует ли заданное число в массиве. 
//Программа должна выдавать: Да/Нет
//Примеры:
//[1 3 4 19 3], 8 => Нет
//[-4 3 4 1], 3 => Да

using System.Diagnostics;


int[] array = { 1, 3, 4, 8, 8 };
int num = 2;
//string isExistNum = "Нет";
bool isExistNum = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num)
    {
        //isExistNum = "Да";
        isExistNum = true;
        break;
    }
}
string result = isExistNum == true ? "Да" : "Нет";
Console.WriteLine(result);



//int[] array = { 1, 3, 4, 8, 8 };
//int num = 0;
//bool index = false;
//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] == num)
//     {
//         index = true;
//     }
// }
// if (index == true)
// { Console.WriteLine("Да"); }
// else { Console.WriteLine("Нет"); }




