partial class Program
{
    static void Tuples()
    {
        (int, string) myTuple = (42, "Hola");
        WriteLine($"Numero: {myTuple.Item1}, Texto: {myTuple.Item2}");

        (int Number, string Text) = (100, "Adios");
        WriteLine($"Numero: {Number}, Texto: {Text}");

        var (Sum, Substraction) = Operations(20, 10);
        WriteLine($"Suma: {Sum}, Resta: {Substraction}");
    }

    static (int Sum, int Substraction) Operations(int a, int b)
    {
        return (a + b, a - b);
    }
}