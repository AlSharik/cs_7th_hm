//Задача 3. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
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
void Average( int[,] matrix)
{
    double average = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            average += matrix[j, i];
        }
        System.Console.Write($"{average / matrix.GetLength(0)}; ");
        average = 0;
    }
}
int[,] matrix = RandomMatrixFill(Prompt(), Prompt());
PrintMatrix(matrix);
Average (matrix);