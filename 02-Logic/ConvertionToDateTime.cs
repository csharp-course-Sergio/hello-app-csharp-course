using System.Globalization;

partial class Program
{
    static void ConvertionToDateTime()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-ES");

        int friends = int.Parse("101");
        DateTime birthday = DateTime.Parse("20 Septiembre 2025");

        WriteLine($"Tengo {friends} amigos y mi cumpleaños es el {birthday}");
        WriteLine($"Tengo {friends} amigos y mi cumpleaños es el {birthday:D}");
    }
}