//Задача 32: Напишите программу замена элементов массива: положительные элементы
// замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();

int[] Ar = { 1, -5, 8, -9, 11, 3, 3, 9 };

void ChangeElementsInArrayM(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
            Arr[i]*=(-1);
    }
}
ChangeElementsInArrayM(Ar);
//System.Console.WriteLine(string.Join(",", array));

void Printarray(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
       Console.Write($"{Arr[i]} ");
    }
}
Printarray(Ar);