namespace Module5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = 1234;
            int months = 12;
            int yearlyWage=Utilities.calculateYearlyWage(amount, months);
            Console.WriteLine($"yearlyWage:{yearlyWage}");  
            Console.ReadLine();
            
        }
    }
}