using System;
using System.Collections;
using System.Collections.Generic;

namespace MyLinq {
   public class Program {
      static void Main(string[] args) {
         //int[] array = new int[] { 1, 1, 3, 4, 4, 4, 2, 3, 4, 5 };
         var drinkCategory = new Category
         {
            ID = 1,
            Name = "Drink"
         };

         var fastFoodCategory = new Category
         {
            ID = 2,
            Name = "Fast Food"
         };


         IEnumerable<Product> products = new List<Product>
         {
            new Product
            {
               ID = 1,
               Name = "Coca-Cola",
               Price = 3.2m,
               Category = drinkCategory
            },
            new Product
            {
               ID = 2,
               Name = "Borjomi",
               Price = 2.2m,
               Category = drinkCategory

            },
            new Product
            {
               ID = 3,
               Name = "Shawarma",
               Price = 10,
               Category = fastFoodCategory
            },
         };

         IEnumerable<Category> GetProducts(Product product) {
            if (product.Price > 5) {
               yield return product.Category;
            }
         }

         var result = products.SelectMany(GetProducts);

         //foreach (var item in result) {
         //   Console.WriteLine(item.Name);
         //}

         #region Aggregate Test
         //IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
         ////Task 1
         //int countEvens = numbers.Aggregate(0, (count, number) => number % 2 == 0 ? ++count : count);
         //Console.WriteLine(countEvens);
         ////Task 2
         //int greatestEven = numbers.Aggregate(new List<int>(), FilterEvenNumbers, GreatestNumber);
         //Console.WriteLine(greatestEven);
         ////Task 3
         //int evenNumbersSum = numbers.Aggregate(0, SumEvenNumbers);
         //Console.WriteLine(evenNumbersSum);
         #endregion
         #region GroupBy Test
         //int[] array = new int[] { 1, 1, 3, 4, 4, 4, 2, 3, 4, 5 };

         //var groups = array.GroupBy((x) => x);
         //foreach (var group in groups) {
         //   Console.WriteLine("Key: " + group.Key);
         //   foreach (int number in group) {
         //      Console.WriteLine("   " + number);
         //   }
         //}
         #endregion
         #region First, FirstOrDefault, Last, LastOrDefault Test
         //Console.WriteLine(array.First());
         //Console.WriteLine(array.FirstOrDefault());
         //Console.WriteLine(array.Last());

         #endregion

      }
      #region HelperMethods

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

   public class Product {
      public int ID { get; set; }
      public string Name { get; set; }
      public decimal Price { get; set; }
      public Category Category { get; set; }
   }

   public class Category {
      public int ID { get; set; }
      public string Name { get; set; }
   }



   public static class MyEnumerable {
      #region SelectMany
      //public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) {
      //   if (source is null) throw new ArgumentNullException("Source is null");

      //   List<TResult> results = new List<TResult>();

      //   var enumerator = source.GetEnumerator();

      //   while (enumerator.MoveNext()) {
      //      results.AddRange(selector(enumerator.Current));
      //   }

      //   return results;
      //}

      public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) {
         if (source is null) throw new ArgumentNullException("Source is null");

         var enumerator = source.GetEnumerator();

         while (enumerator.MoveNext()) {
            var selectedItems = selector(enumerator.Current);
            foreach (var item in selectedItems) {
               yield return item;
            }
         }
      }
      #endregion

      #region Select

      public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> func) {
         foreach (TSource item in source) {
            yield return func(item);
         }
      }

      public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> func) {
         var list = source.ToList<TSource>();
         for (int i = 0; i < list.Count(); i++) {
            yield return func(list[i], i);
         }
      }

      #endregion

      #region First, FirstOrDefault, Last, LastOrDefault

      public static T First<T>(this IEnumerable<T> source) {
         if (source is null) throw new ArgumentNullException("Source is null");
         var enumerator = source.GetEnumerator();
         try {
            if (enumerator.MoveNext()) return enumerator.Current;
            throw new InvalidOperationException("Source is empty");
         } finally {
            enumerator.Dispose();
         }
      }

      public static T FirstOrDefault<T>(this IEnumerable<T> source) {
         if (source is null) throw new ArgumentNullException("Source is null");

         var enumerator = source.GetEnumerator();
         if (enumerator.MoveNext()) return enumerator.Current;

         return default(T);
      }

      public static T Last<T>(this IEnumerable<T> source) {
         if (source is null) throw new ArgumentNullException("Source is null");

         var count = source.Count();
         if (count == 0) throw new InvalidOperationException("Source is empty");

         var enumerator = source.GetEnumerator();
         for (int i = 0; i < count; i++) {
            enumerator.MoveNext();
         }

         return enumerator.Current;
      }

      public static T LastOrDefault<T>(this IEnumerable<T> source) {
         if (source is null) throw new ArgumentNullException("Source is null");

         var count = source.Count();
         if (count == 0) return default(T);

         var enumerator = source.GetEnumerator();
         for (int i = 0; i < count; i++) {
            enumerator.MoveNext();
         }

         return enumerator.Current;
      }

      #endregion

      #region Single, SingleOrDefault

      public static T Single<T>(this IEnumerable<T> source, Predicate<T> predicate) {
         if (source is null || predicate is null) throw new ArgumentNullException("source or predicate is null");

         T result = default;
         bool found = false;
         foreach (var item in source) {
            if (predicate(item)) {
               if (found) throw new InvalidOperationException("More than one result for the predicate");

               result = item;
               found = true;
            }
         }

         if (result.Equals(default(T))) throw new InvalidOperationException("No such element in the source");

         return result;
      }

      public static T SingleOrDefault<T>(this IEnumerable<T> source, Predicate<T> predicate) {
         if (source is null || predicate is null) throw new ArgumentNullException("source or predicate is null");

         T result = default;
         bool found = false;
         foreach (var item in source) {
            if (predicate(item)) {
               if (found) throw new InvalidOperationException("More than one result for the predicate");

               result = item;
               found = true;
            }
         }

         return result;
      }

      #endregion

      #region Skip, Take

      public static IEnumerable<T> Skip<T>(this IEnumerable<T> source, int count) {
         if (count > source.Count()) throw new ArgumentException("Not enough elements to skip");

         var enumerator = source.GetEnumerator();
         for (int i = 0; i < count && enumerator.MoveNext(); i++) ;

         while (enumerator.MoveNext()) {
            yield return enumerator.Current;
         }

         enumerator.Dispose();
      }

      public static IEnumerable<T> Take<T>(this IEnumerable<T> source, int count) {
         if (count > source.Count()) throw new ArgumentException("Not enough elements to take");

         var enumerator = source.GetEnumerator();

         for (int i = 0; i < count && enumerator.MoveNext(); i++) {
            yield return enumerator.Current;
         }

         enumerator.Dispose();
      }

      #endregion

      #region Averrage

      public static int Averrage(this IEnumerable<int> elements) {
         var enumerator = elements.GetEnumerator();
         int sum = 0;
         int count = 0;

         while (enumerator.MoveNext()) {
            sum += (int)enumerator.Current;
            count++;
         }

         if (count > 0) {
            enumerator.Dispose();
            return sum / count;
         }

         enumerator.Dispose();
         return default;
      }

      #endregion

      #region GroupBy
      public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source,
                                                                                 Func<TSource, TKey> keySelector) {
         var groups = new List<Grouping<TKey, TSource>>();
         var enumerator = source.GetEnumerator();
         while (enumerator.MoveNext()) {
            var current = enumerator.Current;
            var key = keySelector(current);

            bool contains = false;
            foreach (IGrouping<TKey, TSource> group in groups) {
               if (group.Key.Equals(key)) {
                  group.Add(current);
                  contains = true;
                  break;
               }
            }

            if (!contains) {
               groups.Add(new Grouping<TKey, TSource>(key, current));
            }
         }

         return groups;
      }

      public class Grouping<TKey, TElement> : IGrouping<TKey, TElement> {
         public Grouping(TKey key, TElement element) {
            Key = key;
            Collection = new List<TElement> { element };
         }

         public Grouping(TKey key, IEnumerable<TElement> elements) {
            Key = key;
            Collection = Collection;
         }

         public TKey Key { get; set; }
         public IEnumerable<TElement> Collection { get; set; }

         public IEnumerator<TElement> GetEnumerator() {
            return Collection.GetEnumerator();
         }

         IEnumerator IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
         }

         public void Add(TElement element) {
            Collection = Collection.Append(element);
         }
      }

      public interface IGrouping<TKey, TElement> : IEnumerable, IEnumerable<TElement> {
         TKey Key { get; set; }
         IEnumerable<TElement> Collection { get; set; }

         void Add(TElement element);
      }
      #endregion

      #region Append
      public static IEnumerable<TElement> Append<TElement>(this IEnumerable<TElement> collection, TElement element) {
         List<TElement> list = new List<TElement>();
         list.AddRange(collection);
         list.Add(element);
         return list;
      }
      #endregion

      #region Contains

      public static bool Contains<TElement>(this IEnumerable<TElement> collection, TElement element) {
         foreach (var item in collection) {
            if (item.Equals(element)) {
               return true;
            }
         }
         return false;
      }

      #endregion

      #region Count

      public static int Count<T>(this IEnumerable<T> source) {
         int count = 0;
         var enumerator = source.GetEnumerator();
         while (enumerator.MoveNext()) {
            count++;
         }

         enumerator.Dispose();
         return count;
      }

      #endregion

      #region Aggregate
      public static TSource Aggregate<TSource>(this IEnumerable<TSource> items, Func<TSource, TSource, TSource> func) {
         var enumerator = items.GetEnumerator();
         TSource result;
         try {
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

         } finally {
            enumerator.Dispose();
         }

      }

      public static TAccumulate Aggregate<TAccumulate, TSource>(this IEnumerable<TSource> items, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func) {
         var enumerator = items.GetEnumerator();

         while (enumerator.MoveNext()) {
            seed = func(seed, enumerator.Current);
         }

         enumerator.Dispose();
         return seed;
      }

      public static TResult Aggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector) {
         return resultSelector(source.Aggregate(seed, func));
      }
      #endregion

      #region ToList
      public static List<T> ToList<T>(this IEnumerable source) {
         var list = new List<T>();
         foreach (T item in source) {
            list.Add(item);
         }

         return list;
      }
      #endregion
   }
}
