//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] NumUser = Console.ReadLine().Split().Select(int.Parse).ToArray();

void NumGreatZero()
{
    int score = 0;
    for(int i = 0; i < NumUser.Length; i++)
        if(NumUser [i] > 0)
        score++;
   Console.WriteLine($"Here's how many {score} numbers greater than zero you entered.");     
}

NumGreatZero();

*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Set the first coordinate: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Set the second coordinate: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Set the third coordinate: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Set the fourth coordinate: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1*x + b1;

if(k1==k2 || b1 == b2) Console.Write("The given lines do not intersect!");
else Console.WriteLine($"The coordinates of the intersection point of two straight lines are equal [{x}; {y}]. ");
