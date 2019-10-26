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

                if (line == "R" || line == "r" )
                {
                    return 0.001;
                }
                else if (double.TryParse(line, out temp))
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

        public bool GetOperationInput()
        {
            double result = 0;
            double value1 = 0;
            double value2 = 0;
            bool tempBool = false;
            //UserInput UInput = new UserInput();
            Operators OP = new Operators();

            string str = Console.ReadLine();
            char tempChar = ' ';
            if (str[0] != ' ')
            {
                tempChar = str[0];
            }

            if (tempChar == 'R' || tempChar == 'r')
            {
                return tempBool = true;
            }
            // TODO:: Error check chars e.g "*5" will work but isn't wanted.
            foreach (var name in Enum.GetValues(typeof(Calculation)).Cast<Calculation>())
            {
                if((char)name == tempChar)
                {
                    switch ((char)name)
                    {
                        case '*':
                            value1 = GetNumericalInput();
                            value2 = GetNumericalInput();
                            if (value1 == 0.001 || (char)value1 == 'r' || (char)value2 == 'R' || (char)value2 == 'r')
                                return true;
                            result = OP.Multiply(value1,value2);
                            tempBool = false;
                            break;
                        case '/':
                            value1 = GetNumericalInput();
                            value2 = GetNumericalInput();
                            result = OP.Divide(value1,value2);
                            tempBool  = false;
                            break;
                        case '-':
                            value1 = GetNumericalInput();
                            value2 = GetNumericalInput();
                            result = OP.Subtract(value1,value2);
                            tempBool  = false;
                            break;
                        case '+':
                            value1 = GetNumericalInput();
                            value2 = GetNumericalInput();
                            result = OP.Add(value1,value2);
                            tempBool  = false;
                            break;
                        case '^':
                            value1 = GetNumericalInput();
                            value2 = GetNumericalInput();
                            result = OP.Power(value1,value2);
                            tempBool  = false;
                            break;
                        case 'r':
                            tempBool  = true;
                            break;
                        case 'R':
                            tempBool  = true;
                            break;
                    }

                };
            }
                Console.WriteLine(result);
                Console.WriteLine("Enter Operation");
                return tempBool;
        }
    }
}
