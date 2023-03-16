/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int ReadInt(string text)
{
 Console.Write(text);
 return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int m, int n)
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

int SumMatrix(int[,]matrix)
{
  int sum=0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sum+=matrix[i,j];
    }
    
  }
return matrix;
}
Console.ReadLine();

void PrintMatrix(int[,]matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
  {
   for (int j = 0; j < matr.GetLength(1); j++)
   {
     Console.WriteLine($"{sum/matr.GetLength(0)} "); 
   }
   Console.WriteLine();     // пустой отступ,чтобы строки разделялись
  }

}

System.Console.Write($"{sum/matrix.GetLength(0)}");
  

int m= ReadInt("Введите количество строк: ");
int n= ReadInt("Введите количество столбцов: ");
var myMatrix=GenerateMatrix(m,n);
SumMatrix(myMatrix);
Console.WriteLine();