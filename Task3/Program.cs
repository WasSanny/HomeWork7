// Задаем двуменый массив из целых чисел. Наидите среднее арифметическое элементов
// каждого столбца (ср. арифметическое каждого столбца: ___, ___, и т.д.)

  int[,] array = CreatTwoDimensionArray(3, 3); 
  Console.WriteLine(PrintTwoDimensionArray(array));

  GetSumElement(array);

int[,] CreatTwoDimensionArray(int firstLength, int secondLength ) 
{
  Console.WriteLine();

  int[,] result = new int[firstLength, secondLength]; 
  Random rnd = new Random(); 

  for (int i = 0; i < result.GetLength(0); i++) 
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      result[i, j] = rnd.Next(1, 99);
    }
  }

  return result;
}

void GetSumElement(int [,] array) // считаем среднее арифметическое в столбцах
{ 
  int sum = 0;
  int sum1 = 0;
  int sum2 = 0;
  int averege;
  int averege1;
  int averege2;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j ++)
    {
      if (j == 0)
      {
        sum = sum + array[i, j];
      }

      if (j == 1)
      {
        sum1 = sum1 + array[i, j];
      }

      if (j == 2)
      {
        sum2 = sum2 + array[i, j];
      }

    }
    
  }

  averege = sum / array.GetLength(1);
  averege1 = sum1 / array.GetLength(1);
  averege2 = sum2 / array.GetLength(1);
    
  Console.Write($"Среднее арифметичесвое столбцов: {averege}; {averege1}; {averege2}");
}


string PrintTwoDimensionArray(int[,] array) 
{
  string result = string.Empty; 

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      result += $"{array[i,j]} "; 
    }
    
    result += Environment.NewLine; 
  }

  return result;
}
