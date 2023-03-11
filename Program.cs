/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*


    

*/
/*void DescendingArrayNumbers(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(1) - 1; k++)
      {
        if (arr[i, k] < arr[i, k + 1])
        {
          int temp = arr[i, k + 1];
          arr[i, k + 1] = arr[i, k];
          arr[i, k] = temp;
        }
      }
    }
  }
}
void PrintArr(int[,] arr)
{
    int rows = arr.GetLength(0);
    int rowsLenght = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        Console.Write($" ");
        for (int j = 0; j < rowsLenght; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine($"");
    }
}
int[,] arr = new int[,] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
PrintArr(arr);
Console.WriteLine($"");
DescendingArrayNumbers(arr);
PrintArr(arr);*/

/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*int GetNumRowMinSumItem(int[,] arr)
{
    int result = 0;
    int rows = arr.GetLength(0);
    int rowsLenght = arr.GetLength(1);
    int[] spamSumArr = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rowsLenght; j++)
        {
            spamSumArr[i] += arr[i, j];
        }
    }
    
    result = Array.IndexOf(spamSumArr, spamSumArr.Min());
    int translateIndexToNum = 1;
    return result + translateIndexToNum;
}
void PrintArr(int[,] arr)
{
    int rows = arr.GetLength(0);
    int rowsLenght = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        Console.Write($" ");
        for (int j = 0; j < rowsLenght; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine($"");
    }
}
int[,] arr = new int[,] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};
PrintArr(arr);
Console.WriteLine($"");
Console.WriteLine($"Номер строки с минимальной суммной элементов {GetNumRowMinSumItem(arr)}.");*/

/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] MatrixMult(int[,] matrix1, int[,] matrix2)
{
    int rows = matrix1.GetLength(0);
    int rowsLenght = matrix1.GetLength(1);
    int[,] resultMatrix = new int[rows, rowsLenght];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rowsLenght; j++)
        {
            int sum = 0;
            for (int k = 0; k < rows; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}
void PrintArr(int[,] arr)
{
    int rows = arr.GetLength(0);
    int rowsLenght = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        Console.Write($" ");
        for (int j = 0; j < rowsLenght; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine($"");
    }
}
int[,] matrix1 = new int[,] { { 2, 4 }, { 3, 2 } };
int[,] matrix2 = new int[,] { { 3, 4 }, { 3, 3 } };
PrintArr(matrix1);
Console.WriteLine($"    x ");
PrintArr(matrix2);
Console.WriteLine($"    = ");
PrintArr(MatrixMult(matrix1, matrix2));
