
//Задача 32: Напишите программу замена элементов массива: положительные элементы
// замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 
//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует
// ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да
Console.Clear();

int[] Ar = { 1, 15, 8, 123, 13, 3, 9 };

int Count2InArray(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
       int count = 0;
        if (Arr[i]/100 %10 == 0)
        {
            count +=1;
        }
        return count;
    }
}
Count2InArray (Ar);
//void Printarray(int[] Arr)
//{
    //for (int i = 0; i < Arr.Length; i++)
    //{
      //  Console.Write($"{Arr[i]} ");
    //}
//}

//ChangeElementsInArrayM (Ar);
//Printarray(Ar);

//Console.Clear();

int[] Ar = { 1, -5, 8, -9, 11, 3, 3, 9 };

//void ChangeElementsInArrayM(int[] Arr)
//{
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i]<0)
        {
            Arr[i]*= -1;
        }

    }
}
