using System;

namespace ConditionalOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 53;

            // TODO: The switch statement
            switch (theVal) {
                case 50:
                    Console.WriteLine("the Value is 50.");
                    break;
                case 51:
                    Console.WriteLine("theValue is 51");
                    break;
                case 52:
                case 53:
                case 54:
                    Console.WriteLine("The value is between 52 and 54");
                    break;
                default:
                    Console.WriteLine("theVal is something else.");
                    break;

            }

        }
    }
}
