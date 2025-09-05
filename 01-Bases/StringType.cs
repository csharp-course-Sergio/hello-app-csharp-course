partial class Program
{
    static void ShowStringType()
    {

        string name = "Sergio";
        string message = "Hola " + name;

        string interpolatedMessage = $"Hola {name}";

        WriteLine(message);
        WriteLine(interpolatedMessage);

        WriteLine($"Tu nombre tiene {name.Length} letras");
        WriteLine($"Tu nombre en mayúsculas {name.ToUpper()}");
        WriteLine($"Tu nombre en minusculas {name.ToLower()}");

        int number = 13;
        WriteLine(number.ToString());
        bool isString = true;
        WriteLine(isString);
    }
}