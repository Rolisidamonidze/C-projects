using System;

using System.Collections;

namespace G09_20200219
{
    class Program
    {
        static void Main()
        {
            Hashtable market = new Hashtable();
            Product p1 = new Product("P001", "Apple", 5);
            market.Add("P001", p1);
            Product p2 = new Product("P002", "Banana", 20);
            market.Add(p2.Code, p2);
            market.Add("P003", new Product("P003", "Orange", 3.5));
            market.Add("P004", new Product("P004", "Strawberry", 1));
            market.Add("P005", new Product("P005", "Pear", 7));

            //tu eseti key aris mashin tavze gadaawers values, tu arada daamatebs.
            market["P006"] = new Product("P006", "Pineapple", 21);

            // klaviaturidan sadziebo kodis sheyvana
            Console.Write("enter code: ");
            string key = Console.ReadLine().ToUpper();

            //elementis dzebna da downcasti product - ze
            if (market.ContainsKey(key))
            {
                Product p = market[key] as Product;
                Console.WriteLine(p);
            }
            else
            {
                Console.WriteLine("not found");
            }

            foreach (var k in market.Keys)
            {
                Console.WriteLine($"key = {k}, value = {market[k]}");
            }

            foreach (DictionaryEntry item in market)
            {
                Console.WriteLine($"key = {item.Key} | value = {item.Value}");
            }

            Console.ReadKey();
        }
    }

    class Product
    {
        public string Code { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string code)
        {
            Code = code;
        }

        public Product(string code, string name, double price) : this(code)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Code: {Code}, Name: {Name}, Price: {Price:0.00}";
        }
    }
}

