//Вопрос по Задаче 36: как корректно завести подсчет суммы в функцию (сейчас закомичено), 
// ругается на объявление массива в функции (что не видит array)?

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int size = 7;
int[] array = new int[size];
void Fillarray(int[] Arr, int size)
{
    //int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Arr[i] = new Random().Next(0, 100);
    }
}
Fillarray(array, size);
//System.Console.WriteLine($"Массив из 3-х значных чисел:");
System.Console.WriteLine(string.Join(", ", array));
//Функция по подсчету суммы нечетных позиций?
//int SumOddNumner(int[] array)
//{
    int Sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        Sum += array[i];
    }
    Console.WriteLine(Sum);
//}
//SumOddNumner(array);
//System.Console.WriteLine(Sum);
