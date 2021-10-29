using static System.Console;

namespace Fauna
{
    abstract public class Creature
    {
        #region Private Members

        #endregion

        #region Constructors

        #endregion

        #region Public Property

        public string Name { get; set; }
        public double Weight { get; set; }

        #endregion

        #region Public Methods
        protected virtual void Breath()
        {
            WriteLine("Bird is breathing with air");
        }

        //public virtual bool Compare(object obj)
        //{
        //    if (obj is Creature)
        //    {
        //        if (Weight > (obj as Creature).Weight)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public virtual void Move()
        {
            WriteLine($"Creature with name {Name ?? GetType().Name} is moving");
            //WriteLine($"Creature with name {(Name != null ? Name:GetType().Name)} is moving");
        }

        public override string ToString()
        {
            return Name ?? base.ToString();
        }
        #endregion

        #region Private Methods

        #endregion
    }
}