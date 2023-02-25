/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int [,] InitMatrix()
{
    int[,] matrix = new int[4,4];
    matrix[0, 0] = 11;
    
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        matrix[0, j] = matrix[0, j-1] +1;
    }

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        matrix[i, matrix.GetLength(1)-1] = matrix[i -1, matrix.GetLength(1)-1] + 1;
    }

    for (int k = matrix.GetLength(1)-2; k >=0; k--)
    {
        matrix[matrix.GetLength(0)-1, k] = matrix[matrix.GetLength(0)-1, k+1] +1;
    }

    for (int l = matrix.GetLength(0)-2; l >= 1; l--)
    {
        matrix[l, 0] = matrix[l+1, 0] +1;
    }

    for (int m = 1; m < matrix.GetLength(1)-1; m++)
    {
        matrix[1, m] = matrix[1, m-1] +1;
    }

    for (int n = 2; n < matrix.GetLength(0)-1; n++)
    {
        matrix[n, matrix.GetLength(0)-2] = matrix[n -1, matrix.GetLength(0)-2] + 1;
    }

    for (int p = matrix.GetLength(1)-3; p >=1; p--)
    {
        matrix[matrix.GetLength(0)-2, p] = matrix[matrix.GetLength(0)-2, p+1] +1;
    }
 

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }

        Console.WriteLine();
    }
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);