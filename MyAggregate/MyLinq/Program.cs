using System;
using System.Collections.Generic;

namespace MyLinq {
   class Program {
      static void Main(string[] args) {
         #region Aggregate Test
         IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9};
         //Task 1
         int countEvens = numbers.Aggregate(0, (count, number) => number % 2 == 0 ? ++count : count);
         Console.WriteLine(countEvens);
         //Task 2
         int greatestEven = numbers.Aggregate(new List<int>(), FilterEvenNumbers, GreatestNumber);
         Console.WriteLine(greatestEven);
         //Task 3
         int evenNumbersSum = numbers.Aggregate(0, SumEvenNumbers);
         Console.WriteLine(evenNumbersSum);

      }

      public static int SumEvenNumbers(int seed, int number) {
         if (number % 2 == 0) {
            seed += number;
         }
         return seed;
      }

      public static List<int> FilterEvenNumbers(List<int> accumulate, int number) {
         if (number % 2 == 0) {
            accumulate.Add(number);
         }
         return accumulate;
      }

      public static int GreatestNumber(IEnumerable<int> numbers) {
         var enumerator = numbers.GetEnumerator();
         enumerator.MoveNext();
         int greatest = enumerator.Current;

         while (enumerator.MoveNext()) {
            if (enumerator.Current > greatest) {
               greatest = enumerator.Current;
            }
         }

         return greatest;
      }

      #endregion
   }

   public static class MyLinq {
      public static void GroupBy() {

      }

      #region Aggregates
      public static TSource Aggregate<TSource>(this IEnumerable<TSource> items, Func<TSource, TSource, TSource> func) {
         var enumerator = items.GetEnumerator();
         TSource result;

         if (enumerator.MoveNext()) {
            result = enumerator.Current;
         } else {
            throw new ArgumentException("Collection must contain at least two items");
         }

         if (!enumerator.MoveNext()) throw new ArgumentException("Collection must contain at least two items");

         do {
            result = func(result, enumerator.Current);
         } while (enumerator.MoveNext());

         return result;
      }

      public static TAccumulate Aggregate<TAccumulate, TSource>(this IEnumerable<TSource> items, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func) {
         var enumerator = items.GetEnumerator();

         while (enumerator.MoveNext()) {
            seed = func(seed, enumerator.Current);
         }

         return seed;
      }

      public static TResult Aggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector) {
         return resultSelector(source.Aggregate(seed, func));
      }
      #endregion
   }
}
