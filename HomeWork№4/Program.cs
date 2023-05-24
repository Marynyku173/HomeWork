//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
void Exponentiation (int num, int degree)

{
        int result = 1;
        for(int step = 0; step < degree; step++)
        {
            
            result *= num ;
            
        }
        
    Console.WriteLine($"The number {num} raised to a power {degree} is equal to {result}.");
}

Console.WriteLine("Input number: ");
    int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input degree: ");
    int degree = Convert.ToInt32(Console.ReadLine());

Exponentiation(num, degree);
*/


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int CountOfDigits (int number)
{
    int res = 0;
    while(number > 0)
    {
        res += number % 10;
        number = number / 10;
    }
    return res;
    
}

Console.WriteLine("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
int count;

if(user_num >= 0)
{
    count = CountOfDigits(user_num);
}
else
{
    count = CountOfDigits(user_num * (-1));
}
Console.WriteLine(count);






//Задача 29: Напишите программу, которая задаёт массив из произвольного количества элементов и выводит их на экран.
/*
int [] CreatNewArray(int size, int min, int max)
{
    int[] array = new int [size]; 
    for(int i = 0; i < size;  i++)
        array[i] = new Random().Next(min, max + 1) ;
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.WriteLine("Enter count of elements: ");
int countOfelem =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the minimum number: ");
int minVal =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the maximum number: ");
int maxVal =  Convert.ToInt32(Console.ReadLine());


if(minVal < maxVal)
{
int [] array1 = CreatNewArray(countOfelem, minVal, maxVal);

ShowArray(array1);

}
else
{
    Console.WriteLine("Attention when entering data, an error occurred: min cannot be greater than max!!");
}
*/