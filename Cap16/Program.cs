﻿using System;
using Cap16.Constructor;    //16.3
using Cap16.Metodos;        //16.4
using Cap16.Comparacion;    //16.5
using Cap16.Locating;       //16.6
using Cap16.Subcadenas;     //16.7
using Cap16.Concatenacion;  //16.8
using Cap16.Miscelaneos;    //16.9
using Cap16.Builder;        //16.10
namespace Cap16
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 16.10 Class StringBuilder
            StringBuilderConstructor.Principal();
            #endregion

            #region 16.9 Miscellaneous string Methods
            // StringMethods2.Principal();
            #endregion

            #region 16.8 Concatening Strings
            // StringConcatenation.Principal();
            #endregion

            #region 16.7 Extracting Substrings from strings
            // Substring.Principal();
            #endregion
            
            #region 16.6 Locating Characters and Substrings in strings
            // StringIndexMethods.Principal();
            #endregion

            #region 16.5 Comparing Strings
            // StringStartEnd.Principal();
            // StringCompare.Principal();
            #endregion

            #region 16.4 String Indexer, Length Property and CopyTo Method
            // StringMethods.Principal();
            #endregion
            
            #region 16.3 String Constructors
            // StringConstructor.Principal();
            #endregion
        }
    }
}
