/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine();
Console.WriteLine("Задача 66");
int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))

            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}
int Sum(int m, int n)
{
    if(m==n)
    { 
    return m;
    }
    else
    {
    return m+Sum(m+1,n);
    }
}

Console.WriteLine("введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите число N");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"{Sum(m,n)}");