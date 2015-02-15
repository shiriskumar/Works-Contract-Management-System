using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double min_rate , est_rate;
            Console.WriteLine("Enter the total number of OEM / OES Quotations:");
            int n = Convert.ToInt32(Console.ReadLine());
            String[] quot = new String[n];
            Double[] rate = new Double[n];
            for(int i = 0; i<n; i++)
            {
                
                Console.WriteLine(". Enter the quotation "+(i+1)+":");
                quot[i] = Console.ReadLine();
                Console.WriteLine(". Enter the rate " + (i + 1) + ":");
                rate[i] = Convert.ToDouble(Console.ReadLine());
            }
            min_rate = rate[0];
            for(int i = 1; i<n; i++)
            {
                if (rate[i] < min_rate)
                {
                    min_rate = rate[i];
                }
            }
            est_rate = 0.9 * min_rate;
            Console.WriteLine("Estimated rate of precision tool is " + est_rate);
            Console.ReadLine();
        }
    }
}
