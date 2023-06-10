
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,] Create2DArray(int row, int column, int minV, int maxV)
{
    double [,] created2Darray = new double[row, column];


     for( int i = 0; i < row; i++)
        for( int j = 0; j < column; j++)
            created2Darray[i,j] = Math.Round((new Random().Next(minV, maxV)) + new Random().NextDouble(), 2);

     return created2Darray;
}

void ShowDouble2Darray(double [,] array)
{
    for( int i = 0; i< array.GetLength(0); i++)
    {

    
        for( int j = 0; j< array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
         Console.WriteLine();
    } 
    Console.WriteLine();
}

 Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of colums: ");
    int userColums = Convert.ToInt32(Console.ReadLine());
    
    int userMin = -100;
    int userMax = 100;

    double [,] createdArray = Create2DArray(userRows, userColums, userMin, userMax);
ShowDouble2Darray(createdArray);

*/



//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int [,] Create2DArray(int row, int column, int minV, int maxV)
{
    int [,] created2Darray = new int[row, column];


     for( int i = 0; i < row; i++)
        for( int j = 0; j < column; j++)
            created2Darray[i,j] = new Random().Next(minV, maxV);

     return created2Darray;
}

void ShowDouble2Darray(int [,] array)
{
    for( int i = 0; i< array.GetLength(0); i++)
    {

    
        for( int j = 0; j< array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
         Console.WriteLine();
    } 
    Console.WriteLine();
}

    
    int userRows = 5;
    int userColums = 7;
    
    int userMin = 0;
    int userMax = 10;

    int [,] createdArray = Create2DArray(userRows, userColums, userMin, userMax);
    Console.WriteLine();
    ShowDouble2Darray(createdArray);
    Console.WriteLine();



void  PositionNumber( )
{ 

    Console.Write("Enter the row: ");
int posRow = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Enter a column: ");
int posColumn = Convert.ToInt32(Console.ReadLine()) - 1;
    
if (posRow<1 || posColumn<1)
{
    Console.WriteLine("Row positions cannot be negative!");
}      
    else if (posRow < 0 | posRow > createdArray.GetLength(0) - 1 | posColumn < 0 | posColumn > createdArray.GetLength(1) - 1)
{
Console.WriteLine("There is no such element!");
}
    else
{
    Console.WriteLine("The value of the array element is = {0}", createdArray[posRow, posColumn]);
}
Console.ReadLine();
}
PositionNumber();
*/


//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
/*
int [,] Create2DArray(int row, int column, int minV, int maxV)
{
    int [,] created2Darray = new int[row, column];


     for( int i = 0; i < row; i++)
        for( int j = 0; j < column; j++)
            created2Darray[i,j] = new Random().Next(minV, maxV);

     return created2Darray;
}

void ShowDouble2Darray(int [,] array)
{
    for( int i = 0; i< array.GetLength(0); i++)
    {

    
        for( int j = 0; j< array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
         Console.WriteLine();
    } 
    Console.WriteLine();
}

    Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of colums: ");
    int userColums = Convert.ToInt32(Console.ReadLine());
    
    int userMin = 0;
    int userMax = 10;

    int [,] createdArray = Create2DArray(userRows, userColums, userMin, userMax);
    Console.WriteLine();
    ShowDouble2Darray(createdArray);

    for( int j = 0; j< createdArray.GetLength(1); j++)
    {
        double sum = 0;
        for( int i = 0; i< createdArray.GetLength(0); i++)
        {
            sum += createdArray[i,j];
            
        }
        Console.Write($"{ sum / createdArray.GetLength(0)} ");
        
    }
   
*/



