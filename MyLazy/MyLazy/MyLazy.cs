using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLazy {
   public class MyLazy<T> {

      private T _value;
      private Func<T> _lazyMethod;

      public MyLazy() {
         Value = (T)Activator.CreateInstance(typeof(T));
      }

      public MyLazy(T lazyValue) {
         Value = lazyValue;
      }

      public MyLazy(Func<T> lazyMethod) {
         _lazyMethod = lazyMethod;
      }

      public T Value {
         get {
            if (IsValueCreate) {
               return _value;
            }

            Value = _lazyMethod();
            return _value;
         }
         private set {
            _value = value;
            IsValueCreate = true;
         }
      }

      public bool IsValueCreate { get; private set; }
   }
}
