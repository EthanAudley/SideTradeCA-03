using System;
using SideTradeCA;
using System.Linq;

namespace SideTradeCA.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            P.StartMessage();

            UserInput UInput = new UserInput();

            bool reset = false;
            //TODO:: R/r to reset the program? Error handle input, when spacebar is pressed and entered the program will break.
            while (reset == false)
            {
                if (UInput.GetOperationInput())
                {
                    P.StartMessage();
                }
            }

        }

        public void StartMessage()
        {
            Console.WriteLine();
            Console.WriteLine("           Which operation do you want to perform?");
            Console.WriteLine("The list of commands are below, type one of the following symbols");
            Console.WriteLine("*   =   Multiply");
            Console.WriteLine("-   =   Subtract");
            Console.WriteLine("/   =   Divide");
            Console.WriteLine("+   =   Addition");
            Console.WriteLine("^   =   Power");
            Console.WriteLine(" To restart the program enter R/r");
        }
    }
}
