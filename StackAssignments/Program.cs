using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAssignments
{
    public class Program
    {
        public static Stack<double> st = new Stack<double>();
        public static void  Main()
        {

            Console.WriteLine("1. Find the total amount");
            Console.WriteLine("2. Find the max cash");
            Console.WriteLine("3. Find the min Cahs");
            Cash c = new Cash();
            st.Push(12.22);
            st.Push(23.33);
            st.Push(223.23);

            int choice = 0;
            do
            {
                Console.WriteLine("Enter the choice");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {

                            Console.WriteLine(c.getTotalCost());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Max value" + c.getMaxVal());
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Min Value" + c.getMinVal());
                            break;
                        }
                }
            } while (choice != 4);
                 
           
        }
    }
}
