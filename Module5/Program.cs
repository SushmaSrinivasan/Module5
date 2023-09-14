namespace Module5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int amount = 1234;
            int months = 12;
            int bonus = 1000; */

            double amountDouble = 1500.0;
            double monthsDouble = 12;
            double bonusDouble = 1000.0;

            //int yearlyWage=Utilities.calculateYearlyWage(amount, months, bonus);
            //Console.WriteLine($"yearlyWage:{yearlyWage}");  

            double yearlyWageDouble = Utilities.calculateYearlyWage(amountDouble, monthsDouble, bonusDouble);
            Console.WriteLine($"yearlyWageDouble:{yearlyWageDouble}");

            Console.ReadLine();
            
        }
    }
}