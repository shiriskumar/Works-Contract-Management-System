using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the labour Details");
            Console.WriteLine("Skilled Labour:");
            int l_s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Semi-Skilled Labour:");
            int l_ss = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Un-Skilled Labour:");
            int l_us = Convert.ToInt32(Console.ReadLine());
            int labour_total = l_s + l_ss + l_us;
            Console.WriteLine();
            Console.WriteLine("Enter the Equipement Details");
            Console.WriteLine("Enter the total number of Equipments used:");
            int e_n = Convert.ToInt32(Console.ReadLine());
            double equip_total = 0;
            for(int i=1;i<=e_n;i++)
            {
                Console.WriteLine("Enter the Equipment " + i + "rate:");
                double e_rate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Equipment " + i + "quantity:");
                double e_qty = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Equipment " + i + " work hours:");
                double e_h = Convert.ToDouble(Console.ReadLine());
                Double e_total = e_h * e_n * e_rate;
                equip_total = equip_total + e_total;
            }
            Console.WriteLine();
            Console.WriteLine("Enter the Material Details");
            Console.WriteLine("Enter the total number of Materials used:");
            int m_n = Convert.ToInt32(Console.ReadLine());
            double material_total = 0;
            for (int i = 1; i <= m_n; i++)
            {
                Console.WriteLine("Enter the Material " + i + "rate:");
                double m_rate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Material " + i + "quantity:");
                double m_qty = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Material " + i + " work hours:");
                double m_h = Convert.ToDouble(Console.ReadLine());
                Double m_total = m_h * m_n * m_rate;
                material_total = material_total + m_total;
            }
            Double tsc = labour_total + equip_total + material_total;
            Console.WriteLine("Total Stipulated Rate is "+tsc);
            Console.WriteLine("Enter the number of Job Item quantity:");
            int n = Convert.ToInt32(Console.ReadLine());
            double rate = tsc / n;
            Console.WriteLine("Rate of an item is " + rate);
        }
    }
}
