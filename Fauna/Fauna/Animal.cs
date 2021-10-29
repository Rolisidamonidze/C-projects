using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Fauna
{
    public class Animal : Creature
    {
        #region Private Members

        #endregion

        #region Constructors


        #endregion

        #region Public Property

        #endregion

        #region Public Methods

        public void Run()
        {
            WriteLine("Animal is Running");
        }

        protected override void Breath()
        {
            WriteLine("Animal is breathing with air");
        }

        #endregion

        #region Private Methods

        #endregion
    }
}