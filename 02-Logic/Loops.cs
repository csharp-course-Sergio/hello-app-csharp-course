partial class Program
{
    static void Loops()
    {
        // while
        int counter = 1;
        while (counter <= 5)
        {
            WriteLine($"Iteración {counter}");
            counter++;
        }

        // do while
        int number = 0;

        do
        {
            WriteLine($"Número {number}");
            number++;
        } while (number < 3);

        // for
        for (int i = 0; i < 5; i++)
        {
            WriteLine($"i = {i}");
        }

        // foreach
        // Array
        string[] fruits = ["Apple", "Banana", "Cherry"];
        foreach (string fruit in fruits)
        {
            WriteLine(fruit);
        }

        // List
        List<string> vegetables = ["Carrot", "Potato", "Tomato"];
        foreach (string vegetable in vegetables)
        {
            WriteLine(vegetable);
        }

    }
}