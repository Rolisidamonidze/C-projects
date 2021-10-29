using System;
using static System.Console;

namespace Fauna
{
    public class SuperDog : Dog
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
            WriteLine("Superdog is flying");
        }

        protected override void Breath()
        {
            WriteLine("Superdog is breathing without air");
        }

        public override void Move()
        {
            //Fly();
            base.Move();
        }

        #endregion

        #region Private Methods

        #endregion
    }
}