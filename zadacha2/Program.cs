// Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

int PhAccer(int m, int n)
{
if(m == 0)
{
    return (n + 1);
}
if((m > 0) && (n == 0))
{
return PhAccer(m - 1,1);
}
if(m > 0 && n > 0)
{
    return PhAccer(m - 1, PhAccer(m, n - 1));
}
return PhAccer(m,n);

}

Console.WriteLine("Введите положительное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PhAccer(m,n));
