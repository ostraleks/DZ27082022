/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента или же указание,
 что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет

*/

int[,] array =
{
    {5, 8, 3, 1, 9, 0},
    {7, 4, 6, 5, 1, 1},
    {9, 0, 6, 5, 3, 3}
};
Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());
if (rows <= array.GetLength(0) && columns <= array.GetLength(1))
{
    Console.WriteLine($"Значение элемента {rows} строки и {columns} столбца - {array[rows, columns]}");
}
else Console.WriteLine("Элемент за пределами массива");