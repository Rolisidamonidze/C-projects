using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Fauna
{
    public class Vehicle
    {
        #region Private Members

        #endregion

        #region Constructors

        public Vehicle()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Vehicle was created!");
            ResetColor();
        }

        #endregion

        #region Public Property

        public string Name { get; set; }

        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion
    }
}