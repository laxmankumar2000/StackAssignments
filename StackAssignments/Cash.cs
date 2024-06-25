using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAssignments
{
    public class Cash
    {
        public double getTotalCost()
        {
            double totalCost = 0;

            foreach(var item in Program.st)
            {
                totalCost += item;
            }    
            return totalCost;
        }

        public double getMaxVal()
        {
            double maxVal = -1.0;
            foreach(var item in Program.st)
            {
                if (maxVal <item)
                    maxVal = item;
            }
            return maxVal;

        }

        public double getMinVal()
        {
            double minVal = 100000;
            foreach(var item in Program.st)
            {
                if(minVal>item)
                    minVal = item;
            }
            return minVal;
        }
    }
}
