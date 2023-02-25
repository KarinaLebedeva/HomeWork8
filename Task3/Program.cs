/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,10);
        }
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

int[,] GetProd(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixProd = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrixProd.GetLength(0); i++)
    {
        for (int j = 0; j < matrixProd.GetLength(1); j++)
        {
            int prodSum = 0;
            for (int k = 0; k < matrixProd.GetLength(1); k++)
            {
                prodSum += matrix1[i, k] * matrix2[k, j];
            }

            matrixProd[i, j] = prodSum;
        }
    }


    return matrixProd;
}

int[,] matrix1 = InitMatrix(2, 2);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = InitMatrix(2, 2);
PrintMatrix(matrix2);
Console.WriteLine();
int[,] matrixProd = GetProd(matrix1, matrix2);
PrintMatrix(matrixProd);