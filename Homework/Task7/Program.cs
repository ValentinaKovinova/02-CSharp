// Задайте одномерный массив, заполненный случайными 
//числами. Определите количество простых чисел в этом массиве.

//Примеры:
//[1, 3, 4, 19, 3] => 2
//[4, 3, 4, 1, 9, 5, 21 ,13] => 3

int[] CreateArrayIntRnd(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}


void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        { Console.Write($"{array[i]}, "); }
        else
        {
            Console.Write(array[i]);
        }
    }
    Console.Write($"]");
}

static bool isPrime(int num)
{

    for (int j = 2; j <= Math.Sqrt(num); j++)
    {
        if (num % j == 0)
        {
            return false;
        }
    }

    return true;
}

int CountPrimeNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (isPrime(array[i])) count++;
    }
    return count;
}

int[] arr = CreateArrayIntRnd(10, 1, 100);
PrintArray(arr);

int countPrimeNums = CountPrimeNums(arr);
Console.WriteLine($" => {countPrimeNums}");

