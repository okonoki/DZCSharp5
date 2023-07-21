// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double[] GetArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble();
        Console.Write($"{array[i]:F2} ");
    }
    return array;
}

int number = GetNumber("Введите длину массива: ");

double[] array = GetArray(number);

double MinNumber(double[] array)
{
    int j = 0;
    double minNumber = array[j];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNumber) minNumber = array[i];
    }
    Console.WriteLine($"\nМинимальное число в массиве: {minNumber:F2}");
    return minNumber;
}

double MaxNumber(double[] array)
{
    int j = 0;
    double maxNumber = array[j];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
    }
    Console.WriteLine($"Максимальное число в массиве: {maxNumber:F2}");
    return maxNumber;
}

double minNumber = MinNumber(array);
double maxNumber = MaxNumber(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {(maxNumber - minNumber):F2}");