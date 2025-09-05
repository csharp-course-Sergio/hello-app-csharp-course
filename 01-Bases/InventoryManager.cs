partial class Program
{
    // 🏆 Ejercicio:
    // - Mostrar el inventario actualizado después de cada compra. 
    // - Crear un menu con las opciones de 1. Comprar producto y 2. Salir.
    static void InventoryManager()
    {
        string[] options = ["Comprar producto", "Salir"];
        string[] products = ["Laptop", "Monitor", "Mouse", "Teclado", "Impresora"];
        int[] stock = [10, 25, 15, 8, 5];
        double[] prices = [750.50, 20.50, 45.00, 200.99, 150.00];

        for (int i = 0; i < options.Length; i++)
        {
            WriteLine($"{i + 1}. {options[i]}");
        }

        WriteLine("\nIngrese una opción:");
        int option = int.Parse(ReadLine()!);

        switch (option)
        {
            case 1:
                WriteLine("Invenatrio de productos");
                WriteLine("-----------------------");

                for (int i = 0; i < products.Length; i++)
                {
                    WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio {prices[i]:C}");
                }

                WriteLine("\nIngrese el producto que desea comprar:");
                string? searchProduct = ReadLine();
                WriteLine("Ingrese la cantidad a comprar:");
                int? quantity = int.Parse(ReadLine()!);

                int itemPosition = -1;

                foreach (var product in products)
                {
                    if (product.Equals(searchProduct!.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        itemPosition = Array.IndexOf(products, product);
                    }
                }

                if (itemPosition == -1) WriteLine("Producto no encontrado");
                else
                {
                    if (quantity <= stock[itemPosition])
                    {
                        double total = (double)(quantity * prices[itemPosition]);
                        WriteLine($"Compra exitosa. Total a pagar: {total:C}");
                        WriteLine($"Stock restante para el producto {products[itemPosition]} es: {stock[itemPosition] - quantity}");
                    }
                    else
                    {
                        WriteLine("No hay suficiente stock disponible");

                    }
                }

                break;
            case 2:
                WriteLine("Gracias por su visita.");
                break;
            default:
                WriteLine("La opción ingresada no es válida.");
                break;
        }
    }
}