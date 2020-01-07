using System;

namespace CalculatorLogic
{
    public class Calculator
    {
        public ConsoleColor color = ConsoleColor.White;
        //CODE_REVIEW
        //use every function to do just one functionality 
        //for example Sum(double a, double b) make it just calculate summation of the two numbers and call another function to change color and another function to print the result
        //Use Constractor to create an instance of ConsoleColor and make color as an option for user 
        //Use Constractor to use Print function from another class "PrintClass"
        //Use Switch Case 
        //For example
        //switch (operationEnum)
        //{
        //    case operationEnum.Sum:
        //        {
        //            // your code 
        //            // call sum  function  
        //            break;
        //        }
        //    case operationEnum.Subtract:
        //        {
        //            // your code 
        //            // call Subtract  function
        //            break;
        //        }
        //    case operationEnum.Divide:
        //        {
        //            
        //            // call Divide  function
        //            break;
        //        }
        //    case operationEnum.Multiply:
        //        {
        //            
        //            // call Multiply  function
        //            break;
        //        }
        //    default: break; call Print function to print warning message 'write a message that user should enter valid option'
        //}

        //Create Interfaces and classes which is implements it 
        //CODE_REVIEW
        //dfg

        public double Sum(double a, double b)
        {
            var x = a + b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }

        public double Subtract(double a, double b)
        {
            var x = a - b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }

        public double Multiply(double a, double b)
        {
            var x = a * b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }

        public double Divide(double a, double b)
        {
                var x = a / b;
                Console.ForegroundColor = color;
                Console.WriteLine($"The result is: {x}");
                if (double.IsInfinity(x))
                {
                    return -999;
                }
                return x;
           
            
        }
    }
}
