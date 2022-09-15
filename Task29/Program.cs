// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.Clear();
int[] arr = new int[8];

void FillArray(int[] array) // заполнение массива
{
    int count = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < count; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
}

void PrintArray(int[] array) // печать массива без скобок
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        if (i == count - 1) Console.Write($"{array[i]} -> ");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write("[");
    for (int a = 0; a < count; a++)
    {
        if (a == count - 1) Console.Write($"{array[a]}]");
        else Console.Write($"{array[a]}, ");
    }
}
FillArray(arr);
PrintArray(arr);