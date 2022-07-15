// В случае нечетного кол-ва элементов массива не получается избавиться от срединного элемента

// Задача 37: 
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10

//Console.Clear();
int[] Ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//           0  1  2  3  4  5  6
int[] NewAr = new int[Ar.Length / 2+1 ];
void Newarraywithdualcomposition(int[] Arr)
{
    for (int i = 0; i < Ar.Length / 2; i++)
    {
        NewAr[i] = Ar[i] * Ar[Ar.Length - i - 1];
    }
if (Ar.Length/2 % 2 != 0)
{
   NewAr[Ar.Length / 2] = Ar[Ar.Length / 2]; 
}
// else
// {

// }
}
 //Newarraywithdualcomposition(Ar);
//Console.WriteLine(string.Join(", ", NewAr));
//Console.Write("\b");

    Newarraywithdualcomposition (Ar);
    Console.WriteLine(string.Join(", ", NewAr));

