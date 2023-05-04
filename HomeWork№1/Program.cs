//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
/*
Console.Write("Input 1st number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input 2nd number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
{
    int max = number_1;
     Console.WriteLine($"Your first number {number_1} is the maximum");
    int min = number_2;
    Console.WriteLine($"Your second number {number_2} is the minimum");
}
else
{
    int max = number_2;
     Console.WriteLine($"Your second number {number_2} is the maximum");
    int min = number_1;
    Console.WriteLine($"Your first number {number_1} is the minimum");
}
*/

//Задача 4: Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.


/*
Console.Write("Input 1st number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input 2nd number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input 3rd number: ");
int number_3 = Convert.ToInt32(Console.ReadLine());

int number_max = number_1;

if (number_1 > number_2)
{
     number_max = number_1;
     Console.WriteLine($"Your first number {number_1} is the maximum");
}
if(number_2 > number_max)
{
     number_max = number_2;
     Console.WriteLine($"Your second number {number_2} is the maximum");
}
if (number_3 > number_max)
{
     number_max = number_3;
     Console.WriteLine($"Your third number {number_3} is the maximum");
}
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number % 2) == 0)
{
    Console.WriteLine($"Your number {number} is the even number");
}

else
{
    Console.WriteLine($"Your number {number} is the odd number");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current_i = 1;

while (current_i <= number)
{
    if (current_i % 2 == 0)
    {
        Console.Write(current_i + " ");
        current_i ++;
        }

    else
    {
        current_i ++;
    }
}
*/
