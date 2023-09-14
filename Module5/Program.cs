namespace Module5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = 1234;
            int months = 12;
            int yearlyWage=calculateYearlyWage(amount, months);
            Console.WriteLine($"yearlyWage:{yearlyWage}");  
            Console.ReadLine();
            static int calculateYearlyWage(int monthlyWage,int numberOfMonthsWorked)
            {
                //Console.WriteLine($"Yearly wage:{monthlyWage * numberOfMonthsWorked}");
                //return monthlyWage + numberOfMonthsWorked;
                if(numberOfMonthsWorked == 12) 
                {
                    return monthlyWage * (numberOfMonthsWorked + 1);
                }
                return monthlyWage * numberOfMonthsWorked;
            }
        }
    }
}