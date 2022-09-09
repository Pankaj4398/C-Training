namespace BasicConcepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            WeekDays firstDay = WeekDays.Monday;
            int monCount = (int)firstDay;
            Console.WriteLine(firstDay + " " + monCount);
            Console.ReadKey();
        }
    }
}