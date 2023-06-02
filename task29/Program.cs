/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


int size = 8;
int [] Array = new int [size];
for(int i = 0; i < size; i++)
{
    Array [i] = new Random().Next(100);
}
Console.WriteLine($"Массив: [{String.Join(";", Array)}]");