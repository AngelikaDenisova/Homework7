// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = new double [rows, columns];

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = Math.Round(new Random().NextDouble()*100, 1);
        Console.Write(array[i,j] + "\t");
    }

Console.WriteLine();
}
