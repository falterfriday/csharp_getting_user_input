using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getting_user_input
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Type something in here"); //initial statment in console
        //    string input = Console.ReadLine(); //allows user to type in console
        //    Console.WriteLine("You entered: " + input); //prints out user input to console
        //    Console.ReadLine(); //pauses the application until user keypress
        //}
        
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Type something in here");
        //    string input = Console.ReadLine();
        //    if (input.Equals("Hello" , StringComparison.OrdinalIgnoreCase))
        //    {
        //        Console.WriteLine("You said hello");
        //    }
        //    else
        //    {
        //        Console.WriteLine("You didn't say hello");
        //    }
        //}

        static void Main(string[] args)
        {
            Console.Write("Enter an operation: + - * / ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine("You chose to add");
                    break;
                case "-":
                    Console.WriteLine("You chose to subtract");
                    break;
                case "*":
                    Console.WriteLine("You chose to multiply");
                    break;
                case "/":
                    Console.WriteLine("You chose to divide");
                    break;
                default:
                    Console.WriteLine("try harder");
                    break;
            }
        }
    }
}
