using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    public class LineComparison
    {
        int x1, y1, x2, y2;
        public LineComparison(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        //Calculate Length of Lines
        public double Calculate()
        {

            double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Square result: " + result);
            return result;
        }
        

        //Compare the two lines
        public void CompareLines(double line1, double line2)
        {
            if (line1 == line2)
            {
                Console.WriteLine("Both Lines are equal");
            }else if (line1 < line2)
            {
                Console.WriteLine("Line 2 is greater than Line 1");
            }else
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
        }
    }
}
