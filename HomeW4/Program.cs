//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2

Console.Clear();
int[,,] GetMatrix(int str, int stolb, int volume, int min = 0, int max = 10)
{
    int[,,] matrix = new int[str, stolb, volume];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[i, j, z] = rnd.Next(min, max);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write($"({i}, {j}, {z})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int num = 0;
Console.Write("Введите размер трёхмерного массива (куб): ");
while (!int.TryParse(Console.ReadLine(), out num))
{
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.Write("Введите размер трёхмерного массива (куб): ");
}
Console.WriteLine();
Console.WriteLine($"Ваш трехмерный массив: [{num}, {num}, {num}]");
Console.WriteLine();
Console.WriteLine();
string s = new string('-', 50);
System.Console.WriteLine("" + s);
int[,,] result = GetMatrix(num, num, num);
PrintMatrix(result);
System.Console.WriteLine("" + s);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();