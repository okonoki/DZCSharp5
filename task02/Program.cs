// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{array[i]} ");
    }
    return array;
}

void OddArgument(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    Console.Write($"\nСумма элементов, стоящих на нечётных позициях равна {sum}");
}
int number = GetNumber("Введите длину массива: ");
int min = GetNumber("Введите минимальное значение диапазона для элементов массива: ");
int max = GetNumber("Введите максимальное значение диапазона для элементов массива: ");

int[] array = GetArray(number, min, max);
OddArgument(array);