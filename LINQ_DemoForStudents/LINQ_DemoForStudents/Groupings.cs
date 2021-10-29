using LINQ_DemoForStudents.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_DemoForStudents {
   public class Groupings {
      public List<Product> GetProductList() => Products.ProductList;

      public void GroupByCategory() {
         List<Product> products = GetProductList();

         var orderGroups = from p in products
                           group p by p.Category into g
                           select
                           (
                               Category: g.Key,
                               Products: g,
                               Count: g.Count()
                           );

         foreach (var orderGroup in orderGroups) {
            Console.WriteLine($"Products in {orderGroup.Category} category {orderGroup.Count}:");
            foreach (var product in orderGroup.Products) {
               Console.WriteLine($"\t{product}");
            }
         }
      }

      public void GroupByProperty() {
         string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

         var wordGroups = from w in words
                          group w by w[0] into g
                          select (FirstLetter: g.Key, Words: g);

         foreach (var g in wordGroups) {
            Console.WriteLine("Words that start with the letter '{0}':", g.FirstLetter);
            foreach (var w in g.Words) {
               Console.WriteLine(w);
            }
         }
      }

      public void GroupingSyntax() {
         int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

         var numberGroups = from n in numbers
                            group n by n % 5 into g
                            orderby g.Key
                            select (Remainder: g.Key, Numbers: g);

         foreach (var g in numberGroups) {
            Console.WriteLine($"Numbers with a remainder of {g.Remainder} when divided by 5:");
            foreach (var n in g.Numbers) {
               Console.WriteLine(n);
            }
         }
      }

      public void GroupByCustomComparer() {
         string[] anagrams = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };

         var orderGroups = anagrams.GroupBy(w => w.Trim(), new AnagramEqualityComparer());

         foreach (var set in orderGroups) {
            foreach (var word in set) {
               Console.WriteLine(word);
            }
            Console.WriteLine("...");
         }
      }
   }

   public class AnagramEqualityComparer : IEqualityComparer<string> {
      public bool Equals(string x, string y) => GetCanonicalString(x) == GetCanonicalString(y);

      public int GetHashCode(string obj) => GetCanonicalString(obj).GetHashCode();

      private string GetCanonicalString(string word) {
         char[] wordChars = word.ToCharArray();
         Array.Sort<char>(wordChars);
         return new string(wordChars);
      }
   }
}
