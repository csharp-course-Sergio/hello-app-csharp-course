partial class Program
{
    static void ShowTime()
    {
        DateTime now = DateTime.Now;
        DateTime today = DateTime.Today;
        DateTime oneWeekAgo = now.AddDays(-7);
        DateTime customDate = new(2025, 3, 2);

        DayOfWeek weekDay = now.DayOfWeek;

        WriteLine(now);
        WriteLine(today);
        WriteLine(oneWeekAgo);
        WriteLine(customDate);
        WriteLine(weekDay);
    }
}