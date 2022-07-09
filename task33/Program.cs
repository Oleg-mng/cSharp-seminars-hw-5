//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует
// ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
int[] Ar = { 1, 5, 0, 7, -9 };
int b=0;
int NumberInarray(int[] Arr, int x)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i] == x)
        {
            b = 1;
            //Console.WriteLine("Да");
            //Arr[i]==x? Console.WriteLine("Да"): Console.WriteLine("Нет");
    
        }
    
    }
return (b);
}
NumberInarray(Ar, 7);
if (b > 0)
{
  Console.WriteLine("Да");  
}
else Console.WriteLine("Нет");