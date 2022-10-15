// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;
Clear();
WriteLine("Введите число ");
int N=Convert.ToInt16(ReadLine());
string num=Number(N);
WriteLine(num);

string Number (int n)
{   
    if(n==1) return n.ToString();
    return n+", "+Number(n-1);
    
}