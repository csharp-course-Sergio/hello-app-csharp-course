partial class Program
{
    static void LoopGame()
    {
        int counter = 0;
        WriteLine("🎮 Pulse cualqueir tecla par aumentar el contador");
        WriteLine("🔴 Pulse 'ESC' para salir\n");

        while (true)
        {
            var key = ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                WriteLine($"Contador: {counter}");
                WriteLine("🟢 Fin del juego!");
                break;
            }
            counter++;
        }


    }
}