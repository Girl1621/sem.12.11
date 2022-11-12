//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
int[] array = new int[5];
PrintArray(array);

void PrintArray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
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

int[] Multiply(int[] array)
{
    int[] result = new int[array.Length / 2];

    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    return result;
}

