using System;

namespace MC2OverflowCheck
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //if (args.Length > 0)
            //{
            //    Console.WriteLine(CheckZip.Check(args[0]));
            //}
            //else
            //{
            //    Console.WriteLine("Please specify file to check as argument.");
            //}
            var UserF = new UserForm();
            UserF.ShowDialog();
            // Pause so Visual Studio doesn't close the console window
            //Console.Read();
        }
    }
}
