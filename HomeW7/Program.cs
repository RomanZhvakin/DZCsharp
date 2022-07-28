//Задача 66: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

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
int AckerFunction(int numberM, int numberN)
{
    if (numberM == 0)
        return numberN + 1;
    if (numberM != 0 && numberN == 0)
        return AckerFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0)
        return AckerFunction(numberM - 1, AckerFunction(numberM, numberN - 1));
    return AckerFunction(numberM, numberN);
}
Console.WriteLine(
    $"Функция Аккермана для чисел A({numberM},{numberN}) = {AckerFunction(numberM, numberN)}");
Console.WriteLine();
