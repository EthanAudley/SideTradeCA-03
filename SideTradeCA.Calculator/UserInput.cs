using System;
using SideTradeCA;

namespace SideTradeCA.ConsoleApp
{
    public class UserInput
    {
        public double Input()
        {
            Console.WriteLine("Enter a numeric value ");

            double temp = 0;
            bool checkInput = false;
            while (checkInput == false)
            {
                string line = Console.ReadLine();
                if (double.TryParse(line, out temp))
                {
                    return temp;
                }
                else
                {
                    Console.WriteLine("Make sure you enter a numerical value.");
                    checkInput = false; 
                }
            }
            return temp;
        }
    }
}
