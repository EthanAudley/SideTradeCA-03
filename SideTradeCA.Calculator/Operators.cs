using System;
using SideTradeCA;

namespace SideTradeCA.ConsoleApp
{
    public class Operators
    {
        public double Multiply(double a, double b)
        {
            double result = 0;
            double counter = b;

            for (double i = 1; i <= counter; i++)
            {
                result = result + a;
                Console.WriteLine("Value = " + result);
            }
            return result;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Divide(double a, double b)
        {
            
            if (a == 0) 
                return 0; 
            if (b == 0) 
                return 0; 
            
            bool negResult = false; 
            
            // Handling negative numbers 
            if (a < 0) 
            { 
                a = -a ; 
                if (b < 0) 
                    b = - b ;  
                else
                    negResult = true; 
            } 
            else if (b < 0) 
            { 
                b = - b ; 
                negResult = true;  
            } 
            
            // if num1 is greater than equal to num2 
            // subtract num2 from num1 and increase 
            // quotient by one. 
            int quotient = 0; 
            while (a >= b) 
            { 
                a = a - b ; 
                quotient++ ; 
            } 
            
            // checking if neg equals to 1 then making 
            // quotient negative  
            if (negResult) 
                quotient = - quotient;


            return quotient ; 
        }

        public double Add(double temp, double temp2)
        {
            return temp + temp2;
        }

        public double Power(double temp, double temp2)
        {
            return temp = Math.Pow(temp,temp2);
        }
    }
}
