using System;
using Cap18.Sobrecarga; //18.2
using Cap18.Genericos;  //18.3

namespace Cap18
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 18.3 Generic-Method Implementation
            GenericMethod.Principal();
            #endregion

            #region 18.2 Motivation for Generic Methods
            // OverloadedMethods.Principal();
            #endregion
        }
    }
}
