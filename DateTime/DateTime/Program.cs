using System;

namespace G18
{
    class Program
    {
        public static DateTime Date { get; set; }
        static void Main()
        {
            //DateTime date = new DateTime(1997, 4, 24);
            //DateTime now = DateTime.Today;
            //TimeSpan x = now - date;
            //Console.WriteLine(x.TotalDays);
            //Console.WriteLine(date.DayOfWeek);
            //string s = date.ToString("dd.MMMM.yyyy");
            //Console.WriteLine(s);
            //DateTime d = DateTime.Parse(s);
            //Console.WriteLine(d);
            //long x = DateTime.Now.ToBinary();
            //Console.WriteLine(x);
            //DateTime d = DateTime.FromBinary(x);
            //Console.WriteLine($"{d:dd.MM.yy HH:mm}");
            //DateTime? y = DateTime.Now;
            //Console.WriteLine(Date.AddDays(10));
            DateTime date = new DateTime(1996, 1, 21);
            var age = GetAge(date);
            Console.WriteLine(age);

        }
        static int GetAge(DateTime birthDate)
        {
            int years = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.Month > birthDate.Month || DateTime.Now.Month == birthDate.Month && DateTime.Now.Day >= birthDate.Day)
            {
                return years;
            }
            return years - 1;
        }
    }
    //damiweret funqcia romelsac gadavcemt tarigs da dagviwers ramdeni wlis aris adamiani
}