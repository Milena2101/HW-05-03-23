/*
 Задайте двумерный массив. 
 Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
 */

Console.WriteLine("Количество строк: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int v = Convert.ToInt32(Console.ReadLine());
int [,] randomArray = new int [c,v];
void massiv(int c, int v)
{
    Random random = new Random();
    for(int i = 0; i < c; i++)
    {
        for(int j = 0; j < v; j++)
        {
            randomArray[c,v] = random.Next(1,9);
        }
    }
}
void printm(int[,] arra)
{
    for(int i = 0; i < arra.GetLength(0); i++)
    {
        Console.WriteLine();
        for(int j = 0; j < arra.GetLength(1); j++)
        {
            Console.Write($"{arra[i,j]}");
        }
        Console.WriteLine();
    }
}
massiv(c,v);
Console.WriteLine("\nИсходный массив: ");
printm(randomArray);

void poryadok(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int y = 0; y < array.GetLength(1) - 1; y++)
            {
                if(array[i,y] < array[i, y +1])
                {
                    int temp = array[i, y +1];
                    array[i, y + 1] = array[i, y];
                    array[i, y] = temp;
                }
            }
        }
    }
}
poryadok(randomArray);
Console.WriteLine("\nОтсортированны массив: ");
printm(randomArray);