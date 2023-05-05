//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа


/*
void Numb( int user_number)
{
    if (user_number > 99 && user_number < 1000 ||user_number > -1000 && user_number < -99  )
    {
        int digit1 = user_number % 10;// 456 % 10 -> 6
        int digit2 = user_number / 10;  // 456 / 10 -> 45
        int digit3 = digit2 % 10; //45 % 10 -> 5
        Console.WriteLine($"Your number is {digit3}");
    }

    else
    {
        Console.WriteLine($"Your number is not 3-digit");
    }

}

Console.WriteLine("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

Numb(user_number);

*/
//Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.
/*
void Numb(int user_number)
{
    if (user_number > 99  ||  user_number < -99)
    {   
        while(user_number > 999 || user_number < -999 )
        {
            user_number /=  10;
        }
            if (user_number > 99)
            {
                int digit1 = user_number % 10;// 456 % 10 -> 6
                Console.WriteLine($"The third digit of this number is {digit1}.");
            }

            else 
            {
                int positive_number = user_number * -1;
                int digit2 = positive_number % 10;// 456 % 10 -> 6
                Console.WriteLine($"The third digit of this number is {digit2}.");
            }
        
    }

    else
    {
        Console.WriteLine($"The given number does not have a third digit.");
    }
    
}
Console.WriteLine("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

 Numb(user_number);

*/

//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void Week(int day_week)
{
if (day_week > 0 && day_week < 8)
{
    if (day_week < 6)
    {
        Console.WriteLine($"It's a working day, we still need to work.");
    }
    else
    {
        Console.WriteLine($"Congratulations! Today is a day off, have a rest!");
    }
}
else 
{
    Console.WriteLine($"Sorry. But this number does not correspond to the number of the week. Try again..");
}
}
Console.WriteLine("Input number: ");
int day_week = Convert.ToInt32(Console.ReadLine());

Week(day_week);

*/