using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Fauna
{
    public class Insect : Creature
    {
        #region Private Members

        #endregion

        #region Constructors

        public Insect()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Insect was created!");
            ResetColor();
        }

        #endregion

        #region Public Property



        #endregion

        #region Public Methods

        protected override void Breath()
        {
            WriteLine("Insect is breathing with air");
        }

        #endregion

        #region Private Methods

        #endregion
    }
}