// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int size = 9;
int[] array = new int[size];
void Fillarray(int[] Arr, int size)
{   int count=0;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Arr[i] = new Random().Next(100, 1000);
     
         if (Arr[i] % 2 == 0)
        {
            count++;
        }
    }
Console.WriteLine($"Количество четных чисел: {count}");
}
Fillarray(array, size);
System.Console.WriteLine($"Массив из 3-х значных чисел:");
System.Console.WriteLine(string.Join(", ", array));

