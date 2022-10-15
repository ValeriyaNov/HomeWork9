// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();
WriteLine("Введите число ");
int M=Convert.ToInt16(ReadLine());
WriteLine("Введите число ");
int N=Convert.ToInt16(ReadLine());
if (M>N) 
{
    int temp=M;
    M=N;
    N=temp;
}
int sum=0;
int s=GetSum(M, N);
WriteLine($"Сумма чисел, находящихся между {M} и {N} равна {s}");


int GetSum (int a, int b)
{
    if (a==b) return sum=sum+b;
    return sum=a+GetSum(a+1, b);
    
} 