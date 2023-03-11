/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
Console.Clear();
int InputInt (string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
void FillArrayRandomNumbers(int [,] array)
{
    for (int d =0; d < array.GetLength(0); d++)
    {
        for (int g = 0; g < array.GetLength(1); g++)
        {
            array[d,g] = new Random().Next(1,10);
        }
    }
}
void PrintArray(int [,] array)
{
    for (int v =0; v < array.GetLength(0); v++)
    {
        Console.Write("[");
        for (int b =0; b < array.GetLength(1); b++)
        {
            Console.Write(array[v,b] + " ");
        }
        Console.Write("]");
        Console.WriteLine(" ");
    }
}

int size = InputInt("размер матриц: ");
int [,] matrix1 = new int[size, size];
int [,] matrix2 = new int [size, size];
FillArrayRandomNumbers(matrix1);
FillArrayRandomNumbers(matrix2);
int [,] matrix3 = new int [size, size];

for (int i =0; i < size; i++)
{
    for (int j =0; j < size; j++)
    {
        for (int n =0; n < size; n++)
        {
            matrix3[i,j] = matrix3[i,j] + (matrix1[i,n] * matrix2[n,j]);
        }
    }
}
Console.WriteLine("Матрица № 1");
PrintArray(matrix1);
Console.WriteLine();

Console.WriteLine("Матрица № 2");
PrintArray(matrix2);
Console.WriteLine();

Console.WriteLine("Произведение двух матриц: ");
PrintArray(matrix3);
