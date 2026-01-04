namespace TaskMaster
{
    public class Utils
    {
        public static string GanerateId()
        {
            return Guid.NewGuid().ToString("N")[..7];
        }
    }
}