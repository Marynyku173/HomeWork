//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Console.WriteLine("Enter the dimension m of the array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the dimension n of the array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] RanArray = new int[m,n];

void Array1(int m, int n)
{
    int i,j;
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            RanArray[i,j] = new Random().Next(1, 9);
        }
    }
}

void printArray(int[,] array)
{
    int i,j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }

}

Array1(m,n);
Console.WriteLine("Source array: ");
printArray(RanArray);


void ArrangeArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

ArrangeArr(RanArray);
Console.WriteLine("Sorted array: ");
printArray(RanArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int height = EnterInt("Enter the number of rows: ");
int width = EnterInt("Enter the number of colums: ");
 
int[,] numbers = new int[height, width];
Fill2DArray(numbers);
Print2DArray(numbers);
SumInLines(numbers);
 
int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}
 
void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(-20, 21);
        }
    }
}
 
void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)      
    {
        for (int j = 0; j < numbers.GetLength(1); j++)   
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }    
}
 

 void SumInLines(int[,] numbers)
{
    int[] sumInLines = new int[numbers.GetLength(0)];
    Console.Write("Sums of elements in each row: ");
    for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                sumInLines[i] += numbers[i, j];
            }
            Console.Write($"{sumInLines[i]} ");
        }
    int minI = 0;
        for (int i = 0; i < sumInLines.Length; i++)
        {
            if (sumInLines[minI] > sumInLines[i]) minI = i;
        }
           
    Console.Write($"Smallest sum of elements: {sumInLines[minI]}, line number with it: {minI + 1}");

}

*/

//Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
/*
Random rnd = new Random();
 int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
 void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1}|");
            else Console.Write($"{matrix[i, j],1}");
        }
        Console.WriteLine("|");
    }
}
 int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}
 void Main(string[] args)
{
    int[,] array2D = CreateMatrix(rnd.Next(2,4), rnd.Next(2, 4), 0, 9);
    int[,] matrix = CreateMatrix(rnd.Next(2, 4), rnd.Next(2, 4), 0, 9);
    PrintMatrix(array2D);
    Console.WriteLine();
    PrintMatrix(matrix);
    Console.WriteLine();
    PrintMatrix(DivMatrix(array2D, matrix));
    Console.ReadLine();
}

Main(args);
*/
//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
Console.WriteLine($"Enter the size of the array X x Y x Z: ");
int x = InputNumbers("Enter X: ");
int y = InputNumbers("Enter Y: ");
int z = InputNumbers("Enter Z: ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
*/


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Spiral Array 4 on 4: ");
int[,] matrix = new int[4, 4];
Console.WriteLine(); 

int temp = 1;
int i = 0;
int j = 0;

while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
{
    matrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= matrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > matrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

PrintMatrix(matrix);
*/