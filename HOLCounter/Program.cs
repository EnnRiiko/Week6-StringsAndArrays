using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"

            Console.WriteLine("Sisesta lause:");
            string sentence = Console.ReadLine().ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'h')
                {
                    hCounter++;
                }

                if (sentence[i] == 'o')
                {
                    oCounter++;
                }

                if (sentence[i] == 'l')
                {
                    lCounter++;
                }
            }

            Console.WriteLine($"Lauses on {hCounter} 'h' täht/tähte, {oCounter} 'o' täht/tähte ja {lCounter} 'l' täht/tähte");

        }
    }
}
