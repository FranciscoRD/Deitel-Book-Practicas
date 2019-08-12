using System;
using Cap10.TimeClass;//    10.2 - 10.4
using Cap10.ClassDate;//    10.7

namespace Cap10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 10.7 Composition
            EmployeeTest.Principal();
            #endregion

            #region 10.5 Time Class Case Study: Overloaded Constructors
            // Time2Test.Principal();
            #endregion

            #region 10.4 Referring to the Current Object's Members with the this Reference
            // ThisTest.Principal();
            #endregion

            #region 10.2 Time Class Case Study; Throwing Exceptions
            // Time1Test.Principal();
            #endregion
        }
    }
}
