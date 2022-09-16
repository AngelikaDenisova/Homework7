// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int rows = new Random().Next(0,10); 
int columns = new Random().Next(0,10); 

int[,] matrix =  new int [rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i,j] = new Random().Next(0,10);  
      Console.Write(matrix[i,j] + ", ");
    }
Console.WriteLine();
}

Console.WriteLine("Введите строку: ");
int testRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите столбец: ");
int testColumn = Convert.ToInt32(Console.ReadLine());


    if(testRow > rows || testColumn > columns)
    {
        Console.WriteLine("Такого элемента нет");
    }
    else 
    {
        Console.WriteLine("Под заданными номерами находится элемент : " + matrix[testRow-1,testColumn-1]);
    }