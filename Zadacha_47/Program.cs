/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/


double ReadInt(string text) //задали тип числа 
{
 Console.WriteLine(text);
 return ToDouble(Console.ReadLine());
}

double[,]GenerateMatrix(int m,int n)  // функция генерации матрицы
{
 double[,]matrix=new double[m,n];
 for (int i = 0; i < m; i++)
 {
   for (int j = 0; j < n; j++)
   {
      matrix[i,j]=Convert.ToDouble(-7,10);
   }
 }
 return matrix;
}

void PrintMatrix(double[,]matr)   // функция вывода матрицы
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
   for (int j = 0; j < matr.GetLength(1); j++)
   {
     Console.WriteLine(matr[i,j]+ " "); 
   }
   Console.WriteLine();     // пустой отступ,чтобы строки разделялись
  }

}

double m=ReadInt("Введите количество строк матрицы: ");
double n=ReadInt("Введите количество столбцов матрицы: ");
var myMatrix=GenerateMatrix(m,n);
PrintMatrix(myMatrix);




