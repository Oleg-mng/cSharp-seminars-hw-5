// C double не получается задать array через Random. Пробовал через "new Random().NextDouble"

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
double size = 5;
//double[] array = new double[size];
double[] array = {-2, 1, 5.3, 7.6, -1.23};
//void Fillarray(double[] Arr, double size)
//{
//     for (int i = 0; i < size; i++)
//     {
//         Arr[i] = new Random().Next(-111, 111);
//     }
//}
//Fillarray(array, size);
//System.Console.WriteLine($"Массив из вещественных чисел:");
System.Console.WriteLine(string.Join(", ", array));
void DeltaMaxMinOffarray(double[] Arr, double size)
{
    double max = 0;
    double min = 112;
    for (int i = 0; i < size; i++)
    {
        if (Arr[i] > max)
        {
            max = Arr[i];
            //max = (Arr[i] > max) ? Arr[i] : 0;
        }
        if (Arr[i] < min)
        {
            min = Arr[i];
        }
    }
    double m = max- min;
    System.Console.WriteLine($"максимальное значение : {max}");
    System.Console.WriteLine($"минимальное значение : {min}");
    System.Console.WriteLine($"разница  : {m}");
}
DeltaMaxMinOffarray(array, size);

