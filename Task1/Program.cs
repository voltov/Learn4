using System;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter line of text or type 'exit' to quit:");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                try
                {
                    if (string.IsNullOrEmpty(input))
                    {
                        throw new Exception("Input can not be empty.\n");
                    }

                    Console.WriteLine($"First character of that line is: {input[0]}\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}