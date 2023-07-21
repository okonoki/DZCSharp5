// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1000);
        Console.Write($"{array[i]} ");
    }
    return array;
}

void EvenNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) sum++;
    }
    Console.Write($"\nКоличество чётных чисел в массиве: {sum}");
}

int size = GetNumber("Введите длину массива: ");

int[] array = GetArray(size);
EvenNumber(array);