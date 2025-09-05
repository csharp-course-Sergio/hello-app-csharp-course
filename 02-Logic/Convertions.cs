partial class Program
{
    static void Convertion()
    {
        int number = 42;
        double decimalNumber = number;

        WriteLine(decimalNumber);

        double anotherDecimal = 47.5;
        int integerNumber = (int)anotherDecimal;
        WriteLine(integerNumber);

        // Convert o Parse
        string text = "123";
        int parsedNumber = int.Parse(text);
        WriteLine(parsedNumber);

        double anotherDecimal2 = 50.8;
        int convertedNumber = Convert.ToInt32(anotherDecimal2);
        WriteLine(convertedNumber); // Redondea
        int castedNumber = (int)anotherDecimal2;
        WriteLine(castedNumber); // Trunca


    }
}