using System;
using System.Linq;
using CalculatorLogic;

namespace ConsoleCalculator
{
    class Program
    {        
        static void Main()
        {
            //// <CODE_REVIEW>   
            //Use Try and catch to handle errors 
            //Check input result if its null or user type any random string to avoid string handling exeptions try the following steps
            //Create enum for the four operations for example 
            // internal enum operationEnum
            //{
            //  None = 0,
            //  Sum = 1,
            //  Subtract = 2,
            //  Multiply = 3,
            //  Divide = 4
            //}
            //Create a validation function for checking if user enter one of the four options or not .And if user insert any another 
            //for example
            //int result;
            //while (!int.TryParse(Console.ReadLine(), out result)
            //{
            //    Console.Clear();
            //    Console.WriteLine("You entered an invalid number");
            //    Console.Write("enter number of conversations ");
            //}
            //CODE_REVIEW
            //// <CODE_REVIEW>        

            Console.Write("Type the operation you want to execute (sum, subtract, multiply, divide): ... ");
            var result = Console.ReadLine();
            //CODE_REVIEW
            //Use meaningful naming like firstNumber 
            //Use Double data type 
            //Check if user entered a correct double value
            //CODE_REVIEW
            Console.Write("Please type the first operand: ");
            var n1 = Console.ReadLine();

            Console.Write("Now, Please type the second operand: ");
            var n2 = Console.ReadLine();

            var calculator = new Calculator();


            //CODE_REVIEW         
            //Call a function from a class has 4 parameters (double firstNumber,double secondNumber,int operation) 
            //this class is created in CalculatorLogic project and should be impelement an Interface
            //should not write any logic code here just call a function and give it parameters and write all logic code in business logic layer "CalculatorLogic" Project
            //CODE_REVIEW
            if (result == "sum")
            {
                calculator.color = ConsoleColor.Red;
                calculator.Sum(Convert.ToDouble(n1), Convert.ToDouble(n2));
            }
            else
            {
                if (result == "subtract")
                {
                    calculator.color = ConsoleColor.Red;
                    calculator.Subtract(Convert.ToDouble(n1), Convert.ToDouble(n2));
                }
                else
                {
                    if (result == "multiply")
                    {
                        calculator.color = ConsoleColor.Red;
                        calculator.Multiply(Convert.ToDouble(n1), Convert.ToDouble(n2));
                    }
                    else
                    {
                        if (result == "divide")
                        {
                            calculator.color = ConsoleColor.Red;
                            calculator.Divide(Convert.ToDouble(n1), Convert.ToDouble(n2));
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }   
}
