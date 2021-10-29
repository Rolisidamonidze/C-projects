using System;

using static System.Console;

namespace Fauna
{
    abstract public class Alien : Creature
    {
        #region Private Members

        #endregion

        #region Constructors

        public Alien()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Alien was created!");
            ResetColor();
        }

        #endregion

        #region Public Property

        public string Planet { get; set; }

        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion
    }
}