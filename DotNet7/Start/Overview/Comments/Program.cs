using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// <summary>
        /// This is the main sample application function.
        /// </summary>
        /// <param name='args'>An array of string arguments from the command line</param>
        /// </returns>
        /// No returns value
        /// </returns>
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            //single line comments use two slashes
            /*multiple line comments start with a slash and a star and can
            continue for serveral lines until a 
            closing start and a slash are encountered. */

        }
    }
}
