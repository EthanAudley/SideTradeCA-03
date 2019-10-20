using System;
using SideTradeCA;
using System.Linq;

namespace SideTradeCA.ConsoleApp
{
    class Program
    {
        enum Calculation
        {   
            Multiply = '*',
            Subtract = '-',
            Divide = '/',
            Add = '+',
            Power = '^'
        }
        static void Main(string[] args)
        {
            Operators OP = new Operators();
            UserInput UInput = new UserInput();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("       Which operation do you want to perform?");
            Console.WriteLine("The list of commands are below, type one of the following symbols");
            Console.WriteLine("*   =   Multiply");
            Console.WriteLine("-   =   Subtract");
            Console.WriteLine("/   =   Divide");
            Console.WriteLine("+   =   Addition");
            Console.WriteLine("^   =   Power");

            // TODO:: Error check chars above.
            string str = Console.ReadLine();

            double result = 0;
            double value1 = 0;
            double value2 = 0;


            foreach (var name in Enum.GetValues(typeof(Calculation)).Cast<Calculation>())
            {
                char tempChar = str[0];
                if((char)name == tempChar)
                {
                    switch ((char)name)
                    {
                        case '*':
                            value1 = UInput.Input();
                            value2 = UInput.Input();
                            result = OP.Multiply(value1,value2);
                            break;
                        case '/':
                            value1 = UInput.Input();
                            value2 = UInput.Input();
                            result = OP.Divide(value1,value2);
                            break;
                        case '-':
                            value1 = UInput.Input();
                            value2 = UInput.Input();
                            result = OP.Subtract(value1,value2);
                            break;
                        case '+':
                            value1 = UInput.Input();
                            value2 = UInput.Input();
                            result = OP.Add(value1,value2);
                            break;
                        case '^':
                            value1 = UInput.Input();
                            value2 = UInput.Input();
                            result = OP.Power(value1,value2);
                            break;

                    }
                    // Set up a case statement 
                };
            }

                Console.WriteLine(result);
                Console.WriteLine("END");

        }
    }
}
