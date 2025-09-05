partial class Program
{
    static double CalculateArea(double width, double height)
    {
        return width * height;
    }

    static string EvaluateNumber(int number)
    {
        return number > 0 ? "Positive" : number < 0 ? "Negative" : "Zero";
    }

    static void Functions()
    {
        var area = CalculateArea(4, 2);
        WriteLine($"Area: {area}");

        var evaluation1 = EvaluateNumber(-5);
        var evaluation2 = EvaluateNumber(0);
        var evaluation3 = EvaluateNumber(56);
        WriteLine($"Evaluation 1: {evaluation1}");
        WriteLine($"Evaluation 2: {evaluation2}");
        WriteLine($"Evaluation 3: {evaluation3}");
    }
}