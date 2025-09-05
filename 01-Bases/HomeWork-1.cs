partial class Program
{
    static void SalesReport()
    {
        string product = "Laptop";
        int quantity = 3;
        double unitPrice = 750.99;
        double totalAmount = quantity * unitPrice;

        WriteLine($"Producto: {product}");
        WriteLine($"Cantidad vendida: {quantity}");
        WriteLine($"Total generado: {totalAmount:C}");
    }

    // 🏆 Ejercicio:
    // Crear un programa que calcule el salario mensual de un trabajador
    // - Pedir al usuario su nombre, horas trabajadas y tarifa por hora
    // - Calcular el sueldo y mostrarlo en pantalla

    static void SalaryCalculator()
    {
        WriteLine("Calculadora de salario\n");

        Write("Ingrese su nombre: ");
        string? name = ReadLine();

        Write("Ingrese el número de horas trabajadas: ");
        double workedHours = double.Parse(ReadLine()!);

        Write("Ingrese el salario por hora: ");
        double salaryPerHour = double.Parse(ReadLine()!);

        double calculatedSalary = workedHours * salaryPerHour;

        WriteLine($"El salario para {name} es de {calculatedSalary:C}");
    }


}