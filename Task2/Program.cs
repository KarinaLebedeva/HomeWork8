/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


int [,] InitMatrix ()
 {
    int [,] result = new int [4,4];
    Random rnd = new Random();

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = rnd.Next(1,10);
        }
    }
    return result;
 }
 void PrintMatrix (int [,] matr)
 {
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int J = 0; J < matr.GetLength(1); J++)
        {
           Console.Write($"{matr[i,J]} ") ;
        }
        Console.WriteLine();
    }

 }

int [,] Matrix = InitMatrix();
 PrintMatrix(Matrix);

 int minSumLine = 0;
int sumLine = SumLineElements(Matrix, 0);
for (int i = 1; i < Matrix.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(Matrix, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"Cтрокa с наименьшей суммой элементов: {minSumLine+1} ");
//с наименьшей суммой элементов: 1 строка
//\n{minSumLine+1} - с

int SumLineElements(int[,] Matrix, int i)
{
  int sumLine = Matrix[i,0];
  for (int j = 1; j < Matrix.GetLength(1); j++)
  {
    sumLine += Matrix[i,j];
  }
  return sumLine;
}
