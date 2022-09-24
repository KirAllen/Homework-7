//   Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int rows = new Random().Next(2, 10);
int lines = new Random().Next(2, 10);
int[,] array = new int[rows, lines]; 
Console.WriteLine("Enter Row number");
int numRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Column number");
int numColumn = Convert.ToInt32(Console.ReadLine());
CreateArray(array);
CheckElements(array); 
PrintArray(array); 

void CreateArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10); 
        }
    }
}

void CheckElements(int[,] array)
{
    int result = 0; 
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {   
            
            if(numRow == i && numColumn == j)
            {
               result = array[i,j];  
            } 
            
        }
    } 
    if(result == 0)
    {
        Console.WriteLine("No Element");
    }
    else
    {
        Console.WriteLine(result);
    }
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} "); 
        }
        Console.WriteLine(); 
    }
    
}