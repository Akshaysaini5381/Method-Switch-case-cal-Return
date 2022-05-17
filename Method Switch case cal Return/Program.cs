using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Switch_case_cal_Return
{
    class Program
    {
        static double prime(double num, double num2, char choice)
        {
            double res = 0;
            switch (choice)
            {
                case '+':
                    res = num + num2;
                    break;
                case '-':
                    res = num - num2;
                    break;
                case '*':
                    res = num * num2;
                    break;
                case '/':
                    res = num / num2;
                    break;
                default:
                    Console.WriteLine("Not Found Result :");
                    break;

            }
            return res;

        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number :");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the number :");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the choice:");
            char c = Convert.ToChar(Console.ReadLine());

            double show = prime(a, b, c);
            Console.WriteLine("Result Is :" + show);
            Console.ReadLine();
        }
    }
}
