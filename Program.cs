// Задача 64: Задайте значения N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalNombers(n, count);


void NaturalNombers(int n, int count)
{
    if (count < n)
    {
       NaturalNombers(n, count + 1);
       Console.Write(count + " "); 
    }
    else
    { 
        return;
    }
}



// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SummaOtMDoN(m, n);

void SummaOtMDoN(int m, int n)
{
    Console.Write(SummaMN(m - 1, n));
}

int SummaMN(int m, int n)
{
    int help = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        help = m + SummaMN(m, n);
        return help;
    }
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

FunctionAkkerman(m,n);

void FunctionAkkerman(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}