using System;

namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation program");

            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value of x1:- " + x1);
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value of x2:- " + x2);
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value of y1:- " + y1);
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value of y2:- " + y2);

            LineComparison lineComparison = new LineComparison(x1,x2,y1,y2);
            double line1 = lineComparison.Calculate();
            
            LineComparison lineComparison1 = new LineComparison(1, 2, 3, 4);
            double line2 = lineComparison1.Calculate();

            lineComparison.CompareLines(line1, line2);
        }
    }
}
