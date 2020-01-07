using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CalculatorLogic.Interfaces
{
    public interface ILanguageInterface
    {
        CultureInfo SetLanguage(int languageEnum);
        // create resource file for every language 
        // configure resource files to correct language 
        //print string messages from localization according to every language from resouce file
    }
}
