﻿// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintI(int[,,] massive3D)
{
    for (int i = 0; i < massive3D.GetLength(0); i++)
    {
        for (int j = 0; j < massive3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < massive3D.GetLength(2); k++)
            {
                Console.Write($"{massive3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void PrintArray(int[,,] massive3D)
{
    int count = 10;
    for (int i = 0; i < massive3D.GetLength(0); i++)
    {
        for (int j = 0; j < massive3D.GetLength(1); j++)
        {
            for (int k = 0; k < massive3D.GetLength(2); k++)
            {
                massive3D[i, j, k] += count;
                count += 3;
            }
        }
    }
}

int[,,] massive3D = new int[2, 2, 2];
PrintArray(massive3D);
PrintI(massive3D);