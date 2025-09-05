partial class Program
{

    static void ListDictionary()
    {
        List<string> names =
        [
            "Ana", "Carlos", "Juan", "Sergio"
        ];

        names.Add("Lucia");
        WriteLine($"Total de nombres: {names.Count}");
        foreach (var name in names)
        {
            WriteLine(name);
        }

        names.Remove("Ana");
        bool isPresent = names.Contains("Ana");

        WriteLine($"¿Ana está en la lista? {(isPresent ? "Si" : "No")}");

        // Dictionary
        Dictionary<int, string> students = new()
        {
            {1, "Valeria" },
            {2, "Raúl" },
            {3, "Susana" },
            {4, "Alberto" }
        };

        foreach (var student in students)
        {
            WriteLine($"ID: {student.Key}, Nombre: {student.Value}");
        }


    }
}