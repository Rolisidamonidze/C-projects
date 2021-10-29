using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Fauna
{
    public class Shark : Fish
    {
        #region Private Members

        #endregion

        #region Constructors

        public Shark()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Shark was created!");
            ResetColor();
        }

        #endregion

        #region Public Property

        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion
    }
}