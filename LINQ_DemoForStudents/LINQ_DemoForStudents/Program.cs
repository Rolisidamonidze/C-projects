using System;

namespace LINQ_DemoForStudents
{
	class Program
	{
		static void Main(string[] args)
		{
         new Groupings()
             .GroupByCategory();
         //.GroupByProperty();
         //.GroupingSyntax();
         //.GroupByCustomComparer();

         Console.ReadKey();
		}
	}
}
