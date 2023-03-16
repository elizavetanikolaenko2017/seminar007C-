/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

int ReadInt(string text) // функция типа числа( генерация числа)
{
 Console.Write(text);
 return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int m, int n) // задали общий шаблон матрицы
{
 int[,]matrix=new int [m,n];
 Random rand=new Random();
 for (int i = 0; i < matrix.GetLength(0); i++)
 {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i,j]=rand.Next(1,10);  
    }
 }
 return matrix;
}

void ElementMatrix(int[,]matrix) //основной код решения задачи
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
   for (int j = 0; j < matrix.GetLength(1); j++)
   {
    if (i<matrix.GetLength(0) && j<matrix.GetLength(1))
    {
      matrix[i,j]=rand.Next(1,10);
    }
    else
    {
      Console.WriteLine("Такого числа в данной матрице нет");
    }
   }
  }
  
 

}

void PrintMatrix(int[,]matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      if (i<matr.GetLength(0) && j<matr.GetLength(1))
      {
        Console.Write(matr[i,j]+ "t");
      }
      else
      {
        Console.WriteLine("Такого элемента в матрице нет.");
      }
    }
  }
}



System.Console.WriteLine("Введите число: ");
int[,]matrix=GenerateMatrix(m,n);
PrintMatrix(matrix);

