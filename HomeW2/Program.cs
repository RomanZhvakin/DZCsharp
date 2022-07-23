//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
Console.WriteLine("введите размер прямоугольного массива");
int massiv = Convert.ToInt32(Console.ReadLine());
string s = new string('-', 15);
System.Console.WriteLine("" + s);
int[,] numbers = new int[massiv, massiv];
RandomNumbers(numbers);
PrintArray(numbers);
int minsum = Int32.MaxValue;
int indexLine = 0;
System.Console.WriteLine("" + s);
for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}
Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine));
void RandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("|");
        Console.WriteLine("");
    }
}
System.Console.WriteLine();
System.Console.WriteLine();