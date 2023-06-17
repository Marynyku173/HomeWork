
/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
void ShowTheNumbers(int num)
{
    Console.Write(num + " ");
    if (num > 1) ShowTheNumbers( num - 1);
    
}
ShowTheNumbers(10);
*/



/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/
/*
int SumNum(int m, int n )
{
    if(m < 0 )  m *= -1; 
    if( n < 0)  n *= -1;
    if (m < n) return SumNum(m , n - 1 ) + n;
    return 0;
}

int res = SumNum(1, 15) + 1;
Console.WriteLine(res);
*/


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
int FunAcker(int m, int n)
{
    if(m == 0)   return n + 1;
    if((m > 0) && (n == 0)) return FunAcker(m - 1, 1);
    if((m > 0) && (n > 0)) return FunAcker(m - 1, FunAcker(m, n - 1)) ;
   return 0;
}
int res = FunAcker(3, 5) ;
Console.WriteLine(res);
*/