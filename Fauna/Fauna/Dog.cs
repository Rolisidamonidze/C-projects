using System;

using static System.Console;

namespace Fauna
{
    
    public class Dog : Animal
    {
        private MyCompare _compare;
        #region Private Members

        #endregion
        #region Constructors
        public Dog()
        {
            _compare = new MyCompare(Compare);
        }
        #endregion
        #region Public Property
        #endregion

        #region Public Methods

        public void Bark()
        {
            WriteLine("Dog is barking");
        }

         public MyCompare getCompare()
        {
            return _compare;
        }

        public bool Compare(object obj1, object obj2)
        {
            if (obj1 is Dog && obj2 is Dog)
            {
                Dog d1 = obj1 as Dog;
                Dog d2 = obj2 as Dog;
                if (d1.Weight > d2.Weight)
                {
                    return true;
                }
                return false;
            }
            throw new Exception("Only Dogs can be compared in this function!");
        }
    }
    //public override string ToString()
    //{
    //    return $"{Name}, {Weight}";
    //}

    #endregion

    #region Private Methods

    #endregion
}