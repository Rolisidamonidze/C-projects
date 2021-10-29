using System;
using System.IO;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = @"D:\Data\Desktop\Crypte";
            string encrypteInput = @$"{root}\Encrypte\Input.txt";
            string encrypteOutput = @$"{root}\Encrypte\Output.txt";
            string decrypteOutput = @$"{root}\Decrypte\Output.txt";

            Console.WriteLine(File.ReadAllText(encrypteInput));
            string password;
            do
            {
                Console.WriteLine("Enter 3 Symbol Encryption Password: ");
                password = Console.ReadLine();
            } while (password.Length != 3);

            Crypte crypte = new Crypte();
            crypte.Encrypte(encrypteInput, encrypteOutput, password);
            Console.WriteLine(File.ReadAllText(encrypteOutput));
            Console.WriteLine("Enter Password To Decrypte text: ");
            var decrypted = crypte.Decrypte(encrypteOutput, decrypteOutput, Console.ReadLine());
            Console.WriteLine(File.ReadAllText(decrypted.FullName));
        }
    }

    class Crypte
    {
        public void Encrypte(String inputPath, String outputPath, string password)
        {
            int[] key = GenerateKey(password);
            using (StreamReader reader = new StreamReader(inputPath))
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                while (!reader.EndOfStream)
                {
                    int symbol = reader.Read();
                    if (reader.BaseStream.Position % 3 == 0)
                    {
                        symbol += key[0];
                    }
                    else if (reader.BaseStream.Position % 2 == 0)
                    {
                        symbol += key[1];
                    }
                    else
                    {
                        symbol += key[2];
                    }
                    writer.Write((char)symbol);
                }
            }
        }

        public FileInfo Decrypte(String inputPath, String outputPath, string password)
        {
            int[] key = GenerateKey(password);
            using StreamReader reader = new StreamReader(inputPath);
            using StreamWriter writer = new StreamWriter(outputPath);
            {
                while (!reader.EndOfStream)
                {
                    int symbol = reader.Read();
                    if (reader.BaseStream.Position % 3 == 0)
                    {
                        symbol -= key[0];
                    }
                    else if (reader.BaseStream.Position % 2 == 0)
                    {
                        symbol -= key[1];
                    }
                    else
                    {
                        symbol -= key[2];
                    }
                    writer.Write((char)symbol);
                }
            }
            return new FileInfo(outputPath);
        }

        private int[] GenerateKey(string password)
        {
            int[] changedPassword = { password[0] / password.Length, password[1] - password[2], password.Length };
            return changedPassword;
        }
    }
}
