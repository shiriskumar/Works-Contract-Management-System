using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Principles
{
    class Program
    {
        public static Double labour_esc(int year, Double labour_comp,Double present_lc)
        { 
            Double lEsc = (present_lc - labour_comp)/labour_comp;
            return lEsc;
        }
        static void Main(string[] args)
        {
            int year;
            Double total_cost = 0, avg, present_lc;
            Console.WriteLine("Enter the year to calculate Estimate Rates:");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the present Labour Component: ");
            present_lc = Convert.ToDouble(Console.ReadLine());
            //Here I take in the present year and run a loop 3 times
            for (int i = 1; i <= 3; i++)
            {
                Double rate_of_estim, ar_max, ar_min, est_rate = 0, awd_rate = 0, labour_comp, material_comp, labor_cost, material_cost;
                year--;
                Console.WriteLine("Enter the Awarded Rate of " + (year) + ":");
                try
                {
                    awd_rate = Convert.ToDouble(Console.ReadLine());
                    /* data types and range:
                     * short -32768 to 32768
                     * sbyte -128 to 128
                     */
                    Console.WriteLine("Enter the Estimated Rate of" + (year) + ":");
                    est_rate = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception occured");
                }
                ar_min = 0.9 * est_rate;
                ar_max = 1.1 * est_rate;

                //Now bring down the Estimated Rate to range to +-10%
                if (awd_rate > ar_max)
                {
                    rate_of_estim = ar_max;
                }
                else if (awd_rate < ar_min)
                {
                    rate_of_estim = ar_min;
                }
                else
                {
                    rate_of_estim = awd_rate;
                }
                Console.WriteLine("Final estimated rate : rate_of_estim is " + rate_of_estim);
                Console.WriteLine("Enter the Labour Component of "+year+" year: ");
                labour_comp = Convert.ToDouble(Console.ReadLine());
                material_comp = 100 - labour_comp;
                material_cost = material_comp * rate_of_estim;
                labor_cost = labour_comp * rate_of_estim * (1 - labour_esc(year,labour_comp,present_lc));
                total_cost = total_cost + labor_cost + material_cost;
            }
            avg = total_cost / 3;
            Console.WriteLine("Estimated rate of " + (year + 3) + " year is " + avg);
            Console.ReadKey();
        }
    }
}
