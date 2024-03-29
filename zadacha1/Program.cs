// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

string NatNum(int N, int M)
{
    if (M == N)
    {
        return Convert.ToString(N);
    }
return M + "" + NatNum(N, M + 1);
}



Console.WriteLine("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NatNum(N, M));
