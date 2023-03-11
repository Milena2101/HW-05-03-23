/*Задача 60.
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int [,,] Random3dArray(int field, int rows, int columns)
{
    int[,,] newArray = new int[field,rows,columns];
    for(int n = 0; n < field; n++)
    {
        for(int m = 0; m < rows; m++)
        {
            for(int b = 0; b < columns; b++)
            {
                newArray[n,m,b] = n+m+b;
            }
        }
    }
    return newArray;
}
 void Show3dArray(int[,,] array)
 {
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int n = 0; n < array.GetLength(2); n++)
            {
                Console.Write("["+i+","+j+"]" + array[i,j,n] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
 }

 Console.Write("input number of field");
 int n = Convert.ToInt32(Console.ReadLine());
 Console.Write("input number of rows");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write("input number of columns");
 int z = Convert.ToInt32(Console.ReadLine());

 int[,,] array = Random3dArray(n,m,z);
 Show3dArray(array);