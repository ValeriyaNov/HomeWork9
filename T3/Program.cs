// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
using static System.Console;
Clear();
WriteLine("Введите число ");
int M=Convert.ToInt16(ReadLine());
WriteLine("Введите число ");
int N=Convert.ToInt16(ReadLine());
int akk=0;
if(M<0 || N<0)  {Write("Error"); return;}

int s=Akkerman(M, N);
WriteLine($"A({M}; {N}) равна {s}");


int Akkerman (int a, int b)
{
    if (a<0 || b<0) return akk;
    if (a==0) akk=b+1;
    if (a>0 && b==0) akk=Akkerman(a-1,1);
    if (a>0 && b>0) akk=Akkerman(a-1, Akkerman(a, b-1));
    
    return akk;
    
} 