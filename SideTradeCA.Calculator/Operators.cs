using System;
using SideTradeCA;

namespace SideTradeCA.ConsoleApp
{
    public class Operators
    {
        public double Multiply(double temp, double temp2)
        {
            double result = 0;
            double counter = temp2;

            for (double i = 1; i <= counter; i++)
            {
                result = result + temp;
                Console.WriteLine("Value = " + result);
            }
            return result;
        }

        public double Add(double temp, double temp2)
        {
            return 1.0;
        }

        public double Subtract(double temp, double temp2)
        {
            return 1.0;
        }

        public float Divide(float temp, float temp2)
        {
            return 1.0f;
        }

    }
}
