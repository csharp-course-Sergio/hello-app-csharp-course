partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5];

        numbers[0] = 1;
        numbers[1] = 3;

        int[] numbersArray = [5, 10, 15, 20, 25, 30];
        WriteLine($"Primer elemento: {numbersArray[0]}");
        WriteLine($"Tercer elemento: {numbersArray[2]}");
        WriteLine($"El número de elemento es: {numbersArray.Length}");

        WriteLine($"Último elemento: {numbersArray[^1]}");

        int[] firstThree = numbersArray[..3];
        int[] fromIndexTwo = numbersArray[2..];

        WriteLine($"Primeros tres: ");
        foreach (var number in firstThree)
        {
            WriteLine(number);
        }

        WriteLine($"Desde el segundo elemento: ");
        foreach (var number in fromIndexTwo)
        {
            WriteLine(number);
        }
    }
}