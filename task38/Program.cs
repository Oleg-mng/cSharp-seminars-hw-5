// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
int size = 5;
int[] array = new int[size];

void Fillarray(int[] Arr, int size)
{
    for (int i = 0; i < size; i++)
    {
        Arr[i] = new Random().Next(-111, 111);
    }
}
Fillarray(array, size);
//System.Console.WriteLine($"Массив из вещественных чисел:");
System.Console.WriteLine(string.Join(", ", array));
void DeltaMaxMinOffarray(int[] Arr, int size)
{
    int max = 0;
    int min = 112;
    for (int i = 0; i < size; i++)
    {
        if (Arr[i] > max)
        {
            max = Arr[i];
        }
        if (Arr[i] < min)
        {
            min = Arr[i];
        }
    }
    int m = max- min;
    System.Console.WriteLine($"максимальное значение : {max}");
    System.Console.WriteLine($"минимальное значение : {min}");
    System.Console.WriteLine($"разница  : {m}");
}
DeltaMaxMinOffarray(array, size);

