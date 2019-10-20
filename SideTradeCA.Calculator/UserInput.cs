using System;
using SideTradeCA;
using System.Linq;

namespace SideTradeCA.ConsoleApp
{
            public enum Calculation
        {   
            Multiply = '*',
            Subtract = '-',
            Divide = '/',
            Add = '+',
            Power = '^'
        }
    public class UserInput
    {

        public double GetNumericalInput()
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

        public void GetOperationInput()
        {
            double result = 0;
            double value1 = 0;
            double value2 = 0;

            //UserInput UInput = new UserInput();
            Operators OP = new Operators();

            string str = Console.ReadLine();

            foreach (var name in Enum.GetValues(typeof(Calculation)).Cast<Calculation>())
            {
                char tempChar = str[0];
                if((char)name == tempChar)
                {
                    switch ((char)name)
                    {
                        case '*':
                            value1 = GetNumericalInput();
                            value2 = GetNumericalInput();
                            result = OP.Multiply(value1,value2);
                            break;
                        case '/':
                            value1 = GetNumericalInput();
                            value2 = GetNumericalInput();
                            result = OP.Divide(value1,value2);
                            break;
                        case '-':
                            value1 = GetNumericalInput();
                            value2 = GetNumericalInput();
                            result = OP.Subtract(value1,value2);
                            break;
                        case '+':
                            value1 = GetNumericalInput();
                            value2 = GetNumericalInput();
                            result = OP.Add(value1,value2);
                            break;
                        case '^':
                            value1 = GetNumericalInput();
                            value2 = GetNumericalInput();
                            result = OP.Power(value1,value2);
                            break;

                    }
                };
            }
                Console.WriteLine(result);
                Console.WriteLine("Enter Operation");
        }
    }
}
