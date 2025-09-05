using System.Globalization;

partial class Program
{
    static void DaysOfLife()
    {
        DateTime bithDate = new(1999, 9, 20);
        TimeSpan difference = DateTime.Now - bithDate;

        WriteLine($"Has vivido {difference.Days} días.");
    }

    // 🏆 Ejercicio:
    // Pedir al usuario su fecha de nacimiento y calcular cuántos días faltan para su próximo cumpleaños.
    // Consideraciones:
    // - La fecha de nacimiento ingresada debe ser interpretada correctamente, 
    //   asegurando que las comparaciones de fechas no sean afectadas por las horas.
    // - Investigar acerca de `CultureInfo.InvariantCulture` para que no afecte la configuración regional del sistema.
    // - Se debe manejar el caso en que el cumpleaños ya haya pasado en el año actual, 
    //   sumando un año para calcular la fecha del próximo (opcional).

    static void DaysUntilNextBirthday()
    {
        // Escribe tu código
        WriteLine("Introduce tu fecha de nacimiento (dd/MM/yyyy): ");
        string stringDate = ReadLine()!;

        try
        {
            DateTime birthDate = DateTime.ParseExact(stringDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime today = DateTime.Today;
            DateTime nextBirthday = new(today.Year, birthDate.Month, birthDate.Day);

            if (nextBirthday < today) nextBirthday = nextBirthday.AddYears(1);

            int days = (nextBirthday - today).Days;

            WriteLine($"Faltan {days} días para tu próximo cumpleaños.");
        }
        catch (Exception)
        {
            WriteLine("La fecha ingresada no es válida. Usa el formato dd/MM/yyyy");
        }
    }
}