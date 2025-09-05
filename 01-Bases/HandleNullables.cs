partial class Program
{
    static void HandleNullables()
    {
        string firstName = "Sergio"; //No nulificable
        string? lastName = null; //Nulificable

        WriteLine($"Nombre: {firstName}");
        WriteLine($"Apellido: {lastName ?? "No especificado"}");


    }
}