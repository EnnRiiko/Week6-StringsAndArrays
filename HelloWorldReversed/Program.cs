using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi

            Console.WriteLine("sisesta lause:");
            string sentence = Console.ReadLine();

            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                Console.Write(sentence[i]);
            }
        }
    }
}
