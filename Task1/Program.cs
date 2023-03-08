// Задаем двумерный массив размером m * n,
// заполненный случайными Вещественными числами.

Console.WriteLine();
int firstLength = ReadInt("First Length");
int secondLength = ReadInt("Second Length");

double[,] array = CreatTwoDimensionArray(firstLength, secondLength); 
Console.WriteLine(PrintTwoDimensionArray(array));

int ReadInt(string argument) 
{
  Console.Write($"Input {argument}: ");
  int result = 0;

  while (!int.TryParse(Console.ReadLine(), out result))
  {
    Console.WriteLine("Try again");
  }

  return result;
}

double[,] CreatTwoDimensionArray(int firstLength, int secondLength ) 
{
  double[,] result = new double[firstLength, secondLength]; 
  Random rnd = new Random();

  for (int i = 0; i < result.GetLength(0); i++) 
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      result[i,j] = Math.Round(rnd.NextDouble()* 10, 2);                                                 
    }
  }

  return result;
}

string PrintTwoDimensionArray(double[,] array)
{
  Console.WriteLine();
  Console.WriteLine($"Массив случайных вещественных чисел размером: {firstLength} X {secondLength}");
  Console.WriteLine();
  
  string result = string.Empty;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      result += $"{array[i,j]}  "; 
    }
    
    result += Environment.NewLine; 
  }

  return result;
}

