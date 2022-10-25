// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
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
//позиция считаем от нуля, то есть в массиве 4*4,
//если мы будем искать элемент с номером позиции [4,4] мы выйдем за пределы массива
void Search(int [,] matrix, int pos1, int pos2)
{
    if(matrix.GetLength(0) > pos1 && matrix.GetLength(1) > pos2)
    {
        System.Console.WriteLine(matrix[pos1, pos2]);
    }
    else
    {
        System.Console.WriteLine("Вышли за пределы массива");
    }
}
int[,] matrix = RandomMatrixFill(Prompt(), Prompt());
PrintMatrix(matrix);
Search( matrix, Prompt(), Prompt());