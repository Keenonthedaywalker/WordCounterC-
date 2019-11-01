using System;

namespace Word_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimeters = new char[] {' ', '\r', '\n' };

            string text = "This is a sentence";

            Console.WriteLine(text.Split(delimeters, StringSplitOptions.RemoveEmptyEntries).Length);


        }
    }
}
