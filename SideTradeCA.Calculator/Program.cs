using System;
using SideTradeCA;

namespace SideTradeCA.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");

            Operators op = new Operators();

            double value1 = 0;
            double value2 = 0;
            double result = 0;

            UserInput UInput = new UserInput();
            
            value1 = UInput.Input();
            value2 = UInput.Input();

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
