using System;
using SideTradeCA;

namespace SideTradeCA.ConsoleApp
{
    class Program
    {
        enum Calculation
        {   
            Multiply,
            Subtract,
            Divide,
            Add,
            Power
        }
        static void Main(string[] args)
        {
            Operators op = new Operators();
            UserInput UInput = new UserInput();

            double result = 0;
            double value1 = UInput.Input();
            double value2 = UInput.Input();

            if (value1 >= 0 && value2 >= 0)
            {
                result = op.Multiply(value1,value2);
                Console.WriteLine(result);
            }

            
            // //op.Multiply(a,b);
            // Console.WriteLine(result);
            // Console.WriteLine("Hello World!");


            //string[] temp =  SideTradeCA.
        }
    }
}
