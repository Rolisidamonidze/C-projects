using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Fauna
{
    public class Human : Creature
    {
        #region Private Members

        #endregion

        #region Constructors

        public Human()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Human was created!");
            ResetColor();
        }

        #endregion

        #region Public Property



        #endregion

        #region Public Methods

        protected override void Breath()
        {
            WriteLine("Human is breathing with air");
        }

        #endregion

        #region Private Methods

        #endregion
    }
}