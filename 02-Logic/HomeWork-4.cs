partial class Program
{
    static void PrintMultiplicationTable(int number, int tableLimit = 10)
    {
        WriteLine($"Tabla de multiplicar del {number}:");
        for (int i = 1; i <= tableLimit; i++)
        {
            WriteLine($"{number} x {i} = {number * i}");
        }
    }

    static void PrintFactorialTable(int number)
    {
        WriteLine($"Factorial del número {number} desde 1 hasta {number}");

        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
            WriteLine($"{i}! = {factorial}");
        }

    }
}