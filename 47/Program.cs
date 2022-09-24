// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Enter Rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Columns");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[rows, columns]; 
CreateArray(array); 
PrintArray(array); 

void CreateArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble() * 100; 
        }
    }
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");  
        }
     Console.WriteLine();
    }
    
}

