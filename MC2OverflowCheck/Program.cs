using System;

namespace MC2OverflowCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine(CheckZip.Check(args[0]));
            }
            else
            {
                Console.WriteLine("Please specify file to check as argument.");
            }

            // Pause so Visual Studio doesn't close the console window
            Console.Read();
        }
    }
}
