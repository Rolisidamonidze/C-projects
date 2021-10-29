using System;
using System.Collections.Generic;
using System.IO;

namespace davaleba_streams
{
    class Program
    {
        static void Main()
        {
            string path = @"D:\Data\Desktop\test.txt";
            string address = @"D:\Data\Desktop\numbered.txt";
            //1 task
            CopyAndNumber(path, address);
            //2 task
            Console.Write($"{CountLettersAndNumbers(path)} letters and ");
            //3 task
            Console.WriteLine($"{CountWords(path)} words in document");
            //4 task
            foreach (var item in CountEachCharacter(path))
            {
                Console.WriteLine(string.Format("{0}: {1}", item.Key, item.Value));
            }

            Console.ReadKey();
        }

        public static void CopyAndNumber(string path, string address)
        {
            using (FileStream openStream = new FileStream(path, FileMode.Open))
            using (FileStream createStream = new FileStream(address, FileMode.Create))
            using (StreamReader reader = new StreamReader(openStream))
            using (StreamWriter writer = new StreamWriter(createStream))
            {
                int number = 1;
                while (!reader.EndOfStream)
                {
                    string line = $"{number}.{reader.ReadLine()}";
                    writer.WriteLine(line);
                    number++;
                }
            }
        }

        public static int CountWords(string path)
        {
            using (FileStream openStream = new FileStream(path, FileMode.Open))
            using (StreamReader reader = new StreamReader(openStream))
            {
                int count = 0;
                char character;
                char previous = ' ';

                while (!reader.EndOfStream)
                {
                    character = (char)reader.Read();
                    if (char.IsWhiteSpace(character) && !char.IsWhiteSpace(previous))
                    {
                        count++;
                    }
                    previous = character;
                }
                //checks the last character in the text, If it is not whitespace count increases by 1.
                if (reader.BaseStream.Length != 0)
                {
                    reader.BaseStream.Position = reader.BaseStream.Position - 1;
                    if (!char.IsWhiteSpace((char)reader.Read()))
                    {
                        count++;
                    }
                }

                return count;
            }
        }

        public static int CountLettersAndNumbers(string path)
        {
            int count = 0;
            using (FileStream openStream = new FileStream(path, FileMode.Open))
            using (StreamReader reader = new StreamReader(openStream))
            {
                char character;
                while (!reader.EndOfStream)
                {
                    character = (char)reader.Read();
                    if (char.IsLetterOrDigit(character))
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static Dictionary<char, int> CountEachCharacter(string path)
        {
            char key;
            int value;
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            using (FileStream openStream = new FileStream(path, FileMode.Open))
            using (StreamReader reader = new StreamReader(openStream))
            {
                while (!reader.EndOfStream)
                {
                    key = (char)reader.Read();
                    if (char.IsLetterOrDigit(key))
                    {
                        if (dictionary.ContainsKey(key))
                        {
                            value = dictionary[key];
                            value++;
                            dictionary[key] = value;
                        }
                        else
                        {
                            dictionary.Add(key, 1);
                        }
                    }
                }
            }

            return dictionary;
        }
    }
}
