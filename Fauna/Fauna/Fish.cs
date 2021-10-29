using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Fauna
{
    public class Fish : Creature
    {
        #region Private Members

        #endregion

        #region Constructors

        public Fish()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Fish was created!");
            ResetColor();
        }

        #endregion

        #region Public Property

        #endregion

        #region Public Methods

        public void Swim()
        {
            WriteLine("Fish is swimming");
        }

        protected override void Breath()
        {
            WriteLine("Fish is breathing in water");
        }

        public override void Move()
        {
            Swim();
        }

        #endregion

        #region Private Methods

        #endregion
    }
}