/*int fillSize = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[fillSize];

FillArray(numbers);
Console.WriteLine("введите числo: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Conteins(numbers, number);

Console.WriteLine(result);

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

bool Conteins(int[] array, int number)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        {
            return true;
        }

    }
    return false;
}*/

/*Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].*/
int [] arr = new int [123];
FillArray (arr);

//PrintArray (arr);

int result = Range(arr);

Console.WriteLine($"Количество элементов массива: {result} ");

void PrintArray(int[] array)
{
    for(int i = 1; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (var i = 0; i < array.Length; i++)
    {
    array[i] = rnd.Next(0, 300);
    }
}

int Range(int [] array)
{
    int count = default;

    for(int i = 0; i < array.Length; i++)
    {
        if (array [i] >= 10 & array [i] < 100) count++;
        
    }
    return count;
} 
