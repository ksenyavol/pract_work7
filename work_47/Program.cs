// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double[m,n];
FillArrayWithRandom(matrix, m, n);

void FillArrayWithRandom(double[,] matrix, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < m; j++)
        {
            matrix[i,j] = new Random().Next(0,11) + Math.Round(new Random().NextDouble(),1);

        Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}