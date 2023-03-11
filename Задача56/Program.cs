/*Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine("Размер массива: ");
int mass = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [mass, mass];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int min = Int32.MaxValue;
int indexLine = 0;

for (int j = 0; j < numbers.GetLength(0); j++)
{
    int sum = 0;
    for (int f = 0; f < numbers.GetLength(1); f++)
    {
        sum = sum + numbers[j,f];
    }
    if(sum<min)
    {
        min = sum;
        indexLine++;
    }
}

Console.WriteLine("Строка с наименьшей суммой: " + (indexLine) + " сумма элементов: " + min);
void FillArrayRandomNumbers(int [,] array)
{
    for (int r = 0; r <array.GetLength(0); r++)
    {
        for (int h = 0; h < array.GetLength(1); h++)
        {
            array[r,h] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int [,] array)
{
    for (int k = 0; k <array.GetLength(0); k++)
    {
        Console.Write("[");
        for (int d = 0; d <array.GetLength(1); d++)
        {
            Console.Write(array[k,d] + " ");
        }
        Console.Write("]");
        Console.WriteLine(" ");
    }
}