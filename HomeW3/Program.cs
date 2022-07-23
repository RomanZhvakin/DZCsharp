//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
void RandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10); 
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
int size = InputInt("размерность матриц: ");
System.Console.WriteLine();
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
RandomNumbers(matrixA);
RandomNumbers(matrixB);
int[,] matrixC = new int[size, size];
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int z = 0; z < size; z++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, z] * matrixB[z, j]);
        }
    }
}
Console.WriteLine("Матрица А");
string s = new string('-', 15);
System.Console.WriteLine("" + s);
PrintArray(matrixA);
System.Console.WriteLine("" + s);
System.Console.WriteLine();
System.Console.WriteLine();
Console.WriteLine("Матрица В");
System.Console.WriteLine("" + s);
PrintArray(matrixB);
System.Console.WriteLine("" + s);
System.Console.WriteLine();
System.Console.WriteLine();
Console.WriteLine("Произведение матриц А и В");
System.Console.WriteLine("" + s);
PrintArray(matrixC);
System.Console.WriteLine("" + s);