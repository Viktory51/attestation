// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы

void MassivPh(int [] arr, int i = 0)
{
    if (i == arr.Length)
{ return; }
MassivPh(arr, i + 1);
Console.Write($"{arr[i]} ");
}


int[] arr = { 1, 2, 5, 0, 10, 34 };
MassivPh(arr);
