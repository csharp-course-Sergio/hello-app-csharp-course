partial class Program
{
    static void ShowNumericTypes()
    {
        int integerNumber = 42;
        double doubleNumber = 3.1416d;
        float floatNumber = 2.74f;
        long longNumber = 300_200_110L;
        decimal moneyNumber = 99.99m;

        WriteLine($"Entero: {integerNumber}\nDouble: {doubleNumber}\nFlotante: {floatNumber}\nLong: {longNumber}\nDecimal: {moneyNumber}");

    }
}