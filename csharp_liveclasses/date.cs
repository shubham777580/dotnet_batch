using System;
namespace Date {

    class Driver {
        public static void Main(string[] args) {
            Date.Date_Diff.calcDiff();
        }
    }
    public class Date_Diff {
        public static void calcDiff() {
            System.Console.WriteLine("Enter Year of date 1: ");
            int year1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Month of date 1: ");
            int month1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Date of date 1: ");
            int date1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Hour of date 1: ");
            int hr1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Minute of date 1: ");
            int min1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Second of date 1: ");
            int sec1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter Year of date 2: ");
            int year2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Month of date 2: ");
            int month2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Date of date 2: ");
            int date2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Hour of date 2: ");
            int hr2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Minute of date 2: ");
            int min2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Second of date 2: ");
            int sec2 = Convert.ToInt32(Console.ReadLine());
                    
            DateTime dates1 = new DateTime(year1, month1, date1, hr1, min1, sec1);
            DateTime dates2 = new DateTime(year2, month2, date2, hr2, min2, sec2);
            TimeSpan dates_diff = dates2 - dates1;
            System.Console.WriteLine("The TimeSpan difference is: " + dates_diff);
        }
    }


}