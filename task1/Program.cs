//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int Prompt()
{
    System.Console.WriteLine("Write number");
    int a = Convert.ToInt32(Console.ReadLine());
    return a; 
}

int[,] RandomMatrixFill(int line, int column)
{
    int[,] matrix = new int [line, column];
    Random rnd = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = rnd.Next(-10, 11);
        }
    }
    return matrix;
    
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[ i, j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("Это наша матрица");
}

int[,] matrix = RandomMatrixFill(Prompt(), Prompt());
PrintMatrix(matrix);