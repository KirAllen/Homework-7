// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Enter Rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Columns");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns]; 
CreateArray(array); 
PrintArray(array); 
GetArithmeticMean(array);

void CreateArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,9); 
        }
    }
}

void PrintArray(int[,] array)
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

void GetArithmeticMean(int[,] array)
{   
    
    for(int j = 0; j < array.GetLength(1); j++)
    {   
        float sum = 0;
        float mean = 0; 

        for(int i = 0; i < array.GetLength(0); i++)
        {   
             sum = sum + array[i,j];
             mean = sum / array.GetLength(1); 
        }  
        Console.WriteLine($"Arithmetic Mean {j} = {mean}");
    } 
}

