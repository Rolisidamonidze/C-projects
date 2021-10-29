using System;

namespace RomanNumbersConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            Console.WriteLine("Enter a number: ");
            try
            {
                text = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            var mainResult = ConvertRomanToArabic(text);
            if(mainResult != null)
            {
                Console.WriteLine($"Result: {mainResult}");
            }
            else
            {
                Console.Write("Invaild input");
            }

            Console.ReadKey();
            
        }

        public static int? ConvertRomanToArabic(string text)
        {
            int? result = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (CorrespondingNumber(text[i]) < CorrespondingNumber(text[i + 1]))
                {
                    result -= CorrespondingNumber(text[i]);
                }
                else
                {
                    result += CorrespondingNumber(text[i]);
                }
            }

            result += CorrespondingNumber(text[text.Length - 1]);

            return result;

            static int? CorrespondingNumber(char c)
            {
                switch (c)
                {
                    case 'I':
                        return 1;
                    case 'V':
                        return 5;
                    case 'X':
                        return 10;
                    case 'L':
                        return 50;
                    case 'C':
                        return 100;
                    case 'D':
                        return 500;
                    case 'M':
                        return 1000;
                    default:
                        return null;
                }
            }
        }
    }
}
