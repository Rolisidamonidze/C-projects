using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Fauna
{
    public class Bird : Creature
    {
        #region Private Members

        #endregion

        #region Constructors

        #endregion

        #region Public Property

        #endregion

        #region Public Methods

        public void Fly()
        {
            WriteLine("Bird is flying");
        }

        protected override void Breath()
        {
            WriteLine("Bird is breathing with air");
        }

        #endregion

        #region Private Methods

        #endregion
    }
}