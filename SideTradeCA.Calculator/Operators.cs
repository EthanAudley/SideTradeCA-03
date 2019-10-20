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

        public double Subtract(double temp, double temp2)
        {
            return temp - temp2;
        }

        public double Divide(double temp, double temp2)
        {
            
            if (temp == 0) 
                return 0; 
            if (temp2 == 0) 
                return 0; 
            
            bool negResult = false; 
            
            // Handling negative numbers 
            if (temp < 0) 
            { 
                temp = -temp ; 
                if (temp2 < 0) 
                    temp2 = - temp2 ;  
                else
                    negResult = true; 
            } 
            else if (temp2 < 0) 
            { 
                temp2 = - temp2 ; 
                negResult = true;  
            } 
            
            // if num1 is greater than equal to num2 
            // subtract num2 from num1 and increase 
            // quotient by one. 
            int quotient = 0; 
            while (temp >= temp2) 
            { 
                temp = temp - temp2 ; 
                quotient++ ; 
            } 
            
            // checking if neg equals to 1 then making 
            // quotient negative  
            if (negResult) 
            {
                    quotient = - quotient ; 
            return quotient ; 
            }
            return 0;
        }

        public double Add(double temp, double temp2)
        {
            return temp + temp2;
        }

        public double Power(double temp, double temp2)
        {
            return 1.0;
        }
    }
}
