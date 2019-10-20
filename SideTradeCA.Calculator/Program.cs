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
            Operators op = new Operators();
            UserInput UInput = new UserInput();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("       Which operation do you want to perform?");
            Console.WriteLine("The list of commands are below, type ne of the following...");
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
                            result = op.Multiply(value1,value2);
                            break;
                        case '/':
                        
                            break;
                        case '-':
                        
                            break;
                        case '+':
                        
                            break;
                        case '^':
                        
                            break;

                    }
                    // Set up a case statement 
                };
            }


            

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
