partial class Program
{
    static void LoopControlExamples()
    {
        WriteLine("Loop Control Examples:");
        WriteLine("Break");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5) break;
            WriteLine(i);
        }

        WriteLine("Continue");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5 || i == 7) continue;
            WriteLine(i);
        }

        WriteLine("Return");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 3) return;
            WriteLine(i);
        }
    }
}