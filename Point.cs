using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    public class Point
    {
        public int x1 { get; }
        public int y1 { get; }
        public int x2 { get; }
        public int y2 { get; }
        public Point()
        {
            
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
    }
    public class Line : Point
    {
        public static double CalculateLength()
        {

            Console.Write("Value of x1:- ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Value of y1:- ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Value of x2:- ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Value of y2:- ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Square result: " + result);
            return result;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Line otherLine =(Line)obj;
            return otherLine.Equals(this);
        }

        public static void CompareTo()
        {
            
            Console.WriteLine("Enter a value for 1st Line");
            double result1 = CalculateLength();

            Console.WriteLine("Enter a value for 2nd Line");
            double result2 = CalculateLength();

            if (result1 == result2)
            {
                Console.WriteLine("Both Lines are equal");
            }
            else if (result1 < result2)
            {
                Console.WriteLine("Line 2 is greater than Line 1");
            }
            else
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
        }
    }
}
