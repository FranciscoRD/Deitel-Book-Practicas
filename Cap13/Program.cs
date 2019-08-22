using System;
using Cap13.ZeroNoException;    //13.2
using Cap13.ZeroException;      //13.3
using Cap13.FinallyBlock;       //13.5
namespace Cap13
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 13.5 Fianlly Block
            UsingExceptions.Principal();
            #endregion

            #region 13.3 Example: Handling DivideByZeroExceptions and FormatExceptions
            // DivideByZeroExceptionHandling.Principal();
            #endregion

            #region 13.2 Example: divide by Zero without Exception
            // DivideByZeroNoExceptionHandling.Principal();
            #endregion
        }
    }
}
