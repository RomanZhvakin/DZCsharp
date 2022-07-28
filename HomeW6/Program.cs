//Задача 64: Задайте значения M и N.
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.WriteLine("Введите начальное число M:");
string s = new string('-', 5);
System.Console.WriteLine("" + s);
int numberM = int.Parse(Console.ReadLine());
System.Console.WriteLine("" + s);
Console.WriteLine("Введите начальное число N:");
System.Console.WriteLine("" + s);
int numberN = int.Parse(Console.ReadLine());
System.Console.WriteLine("" + s);
void NumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    NumberSum(numberM, numberN, sum);
}
NumberSum(numberM, numberN, 0);
Console.WriteLine();