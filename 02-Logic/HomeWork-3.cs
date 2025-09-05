// 🏆 Ejercicio:
// Implementar un programa que recorra los números del 1 al 100.
// Consideraciones:
// Aplicar la lógica de FizzBuzz:
// - Si un número es divisible por 3, imprimir "Fizz".
// - Si un número es divisible por 5, imprimir "Buzz".
// - Si un número es divisible por 3 y 5, imprimir "FizzBuzz".
// - En cualquier otro caso, imprimir el número.
// 💡 Pista:
// - El orden de las condiciones es clave.
// Piensa en cómo asegurarte de que "FizzBuzz" se imprima antes que "Fizz" o "Buzz".

partial class Program
{
    static void FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            bool isMultipleOf3 = i % 3 == 0;
            bool isMultipleOf5 = i % 5 == 0;

            string output = "";

            if (isMultipleOf3) output = "Fizz";
            if (isMultipleOf5) output += "Buzz";

            WriteLine(string.IsNullOrEmpty(output) ? i.ToString() : output);

        }
    }
}