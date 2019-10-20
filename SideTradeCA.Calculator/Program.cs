using System;
using SideTradeCA;
using System.Linq;

namespace SideTradeCA.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {

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

            UserInput UInput = new UserInput();

            bool reset = true;
            //TODO:: R/r to reset the program?
            while (reset)
            {
                UInput.GetOperationInput(); 
            }
           


        }
    }
}
