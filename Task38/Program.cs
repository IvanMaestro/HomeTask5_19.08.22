// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 100, 1);

    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

double SubstractionMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min < array[i]) min = min;
        else min = array[i];
        if (max > array[i]) max = max;
        else max = array[i];
    }
    return max - min;
}

double[] arr = CreateArrayRndInt(4, 0, 999);
PrintArray(arr);
double result = Math.Round(SubstractionMaxMin(arr), 1);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {result}");

