//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
/*

int [] CreatRandomArray (int size, int minVal, int maxVal)
{
    int [] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray [i] = new Random().Next(minVal, maxVal + 1 );
    return newArray;
}

void ShowArray( int[] array1)
{
    for(int i = 0; i < array1.Length; i++ )
        Console.Write(array1[i]+ " ");
        Console.WriteLine();
}
int sizeStart = new Random().Next(1, 100);
Console.WriteLine($"The length of your array is {sizeStart}");
Console.WriteLine();
int minPossibVal = 100;
int maxPossibVal = 999;

void ParityCheck(int [] array3DigNum)
{   int count = 0;
    for(int i = 0; i < array3DigNum.Length; i++)
        if(array3DigNum[i] % 2 == 0)
        {
            count++;
        }
    Console.WriteLine($"The number of even numbers in the array is {count}");
    Console.WriteLine();

}

int [] arrayStart = CreatRandomArray( sizeStart, minPossibVal,maxPossibVal );
ShowArray(arrayStart);
Console.WriteLine();

ParityCheck (arrayStart);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] CreatRandomArray (int size, int minVal, int maxVal)
{
    int [] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray [i] = new Random().Next(minVal, maxVal + 1 );
    return newArray;
}

void ShowArray( int[] array1)
{
    for(int i = 0; i < array1.Length; i++ )
        Console.Write(array1[i]+ " ");
        Console.WriteLine();
}
int sizeStart = new Random().Next(1, 100);
Console.WriteLine($"The length of your array is {sizeStart}");
Console.WriteLine();
int minPossibVal = -100;
int maxPossibVal = 100;

void ParityCheck(int [] array3DigNum)
{   int count = 0;
    for(int i = 0; i < array3DigNum.Length; i++)
        if(i % 2 !=0)
        {
            count += array3DigNum[i];
        }
       Console.WriteLine($"The sum of the elements standing in odd positions is equal to{count}"); 
}

int [] arrayStart = CreatRandomArray( sizeStart, minPossibVal,maxPossibVal );
ShowArray(arrayStart);
Console.WriteLine();

ParityCheck (arrayStart);

*/
//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

/*
double [] CreatRandomArray (int size, int minVal, int maxVal)
{
    double [] newArray = new double[size];
    for(int i = 0; i < size; i++)
        newArray[i]  = Math.Round( new Random().Next(minVal, maxVal + 1) + new Random().NextDouble(), 2);
        
    return newArray;
}

void ShowArray( double[] array1)
{
    for(int i = 0; i < array1.Length; i++ )
        Console.Write(array1[i]+ " ");
        Console.WriteLine();
        
}
int sizeStart = new Random().Next(1, 100);
Console.WriteLine($"The length of your array is {sizeStart}");
Console.WriteLine();
int minPossibVal = 1;
int maxPossibVal = 100;




double[] arrayStart = CreatRandomArray( sizeStart, minPossibVal,maxPossibVal );// создали массив рандомный
ShowArray(arrayStart);// продемонстрировали массив исходный
Console.WriteLine();



double FindMin( )
{   double min = arrayStart[0];
    
    int i;
    for( i = 0; i < arrayStart.Length; i++)
    { 
        if(arrayStart[i] < min )
        {
           min = arrayStart[i];
        }    
    }
    return min;
}

double FindMax( )
{   
    double max = 0;
    int i;
    for( i = 0; i < arrayStart.Length; i++)
    { 
        if(arrayStart[i]> max  )
        {
            max = arrayStart[i];
        }
    }
    return max;
}    
    void Result()
    {  double minNum = FindMin();
       double maxNum = FindMax();
    double res =Math.Round( maxNum - minNum, 2);
    Console.WriteLine($"The minimum number is {minNum}");
    Console.WriteLine();
    Console.WriteLine($"The maximum number is {maxNum}");
    Console.WriteLine();
    Console.WriteLine($"The difference between the maximum and minimum elements of the array is {res}");

    }

Result();
*/