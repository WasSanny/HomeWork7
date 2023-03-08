// Программа, которая на вход принимает позиции элемента в двумерном массиве и
// возвращает значение этого элемента или указание токо, что такого
// элемента не существует!

Task1();

void Task1()
{
  Console.WriteLine();
  int firstLength = ReadInt("First Length");
  int secondLength = ReadInt("Second Length");

  int[,] array = CreatTwoDimensionArray(firstLength, secondLength); 
  Console.WriteLine(PrintTwoDimensionArray(array));

  
  int firstIndex = ReadInt("First index");
  int secondIndex = ReadInt("Second index");
  Console.WriteLine();
  int element = GetElementForIndex(array, firstIndex, secondIndex);
  Console.WriteLine($"Значение элемента по заданным индексам [{firstIndex}, {secondIndex}] = {element}");
}

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

int[,] CreatTwoDimensionArray(int firstLength, int secondLength ) 
{
  Console.WriteLine();

  int[,] result = new int[firstLength, secondLength]; 
  Random rnd = new Random(); 

  for (int i = 0; i < result.GetLength(0); i++) 
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      result[i, j] = rnd.Next(1, 15);
    }
  }

  return result;
}

int GetElementForIndex(int [,] array, int firstIndex,  int secondIndex)
{
  int[,] newResult = new int[array.GetLength(0), array.GetLength(1)];

  int posicionElement = 0;

  for (int i = 0; i < newResult.GetLength(0); i++)
  {
    for (int j = 0; j < newResult.GetLength(1); j++)
    {
      if (i == firstIndex && j == secondIndex)
      {
        posicionElement = array[i, j];
      }
    }
    
  }

 return posicionElement; 
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