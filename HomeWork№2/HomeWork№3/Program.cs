//Задача 19 Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
/*
void Numb( int user_number)
{
    if (user_number > 9999 && user_number < 100000 ||user_number > -100000 && user_number < -9999  )
    {
        int digit1 = user_number / 10000;
        int digit2 = user_number % 10;
        int digit3 = user_number / 1000;
        int digit4 = digit3 % 10; 
        int digit5 = user_number % 100; 
        int digit6 = digit5 / 10;
        if(digit1 == digit2 && digit4 == digit6)
        {
            Console.WriteLine($"Cool! Your number is a palindrome!");
        }
        else
        {
            Console.WriteLine($"It's sad, but your number is not a palindrome.");
        }
    }
    else
    {
        Console.WriteLine($"Oops, your number is not 5-digit...");
    }
}

Console.WriteLine("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

Numb(user_number);
 */





//Задача 21 Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
/*
double LongLine(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double lengthAB = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2) );
    //double lengthAB1 = Math.Round (lengthAB, 2);// метод округления
    return lengthAB;
}

Console.WriteLine("Input X coordinate of A : ");
int xCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y coordinate of A : ");
int yCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Z coordinate of A : ");
int zCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input X coordinate of B : ");
int xCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y coordinate of B : ");
int yCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Z coordinate of B : ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine (xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB );

Console.WriteLine($"Distance AB is {dist:f2} ");


*/
//Задача 23 Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void CubeFinder()
{
    Console.WriteLine("Input number: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

        if(numberN > 0)
    {
        int current = 1;
        while (current <= numberN)
        {
            double res = Math.Pow(current, 3);
            Console.Write($"{res:f0}, ");
            current ++;
        }
        Console.WriteLine("\b\b.");
    }
    else 
   {
    int current = 1;
     while (current >= numberN)
        {
            double res = Math.Pow(current, 3);
            Console.Write($"{res}, ");
            current --;
        }
        Console.WriteLine("\b\b.");
   }
}

CubeFinder();
*/
