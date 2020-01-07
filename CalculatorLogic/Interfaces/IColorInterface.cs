using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLogic.Interfaces
{
   public interface IColorInterface
    {
        ConsoleColor SetColor(int colorEnum);
        //Create an enum  for color 
        // Dont set color in main function. Set color after return result from operation function 
    }
}
