using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr ---DONE
            // Create a list called numbers that will hold integers ---DONE
            // Create an string variable with an empty string initializer - name it str ---DONE

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------

            char[] arr = { 'j', 'm', 'g', '1', '0', '0', '6', '8', '8' };
            List<int> numbers = new List<int>();
            string str = "";


            //TODO START HERE:
            
            // Make a foreach loop to iterate through your character array
            foreach (var item in arr)
            {// Now create a try catch -- Inside your try block
                try
                {// set your string variable to each array element in your char[] to .ToString()
                    str = item.ToString();
                 // Now, using int.Parse, parse your string variable and store in an int variable
                    int str1 = int.Parse(str);
                    // Then add each int to your list
                    numbers.Add(str1);
                }
                // catch your Exception:
                catch (Exception)
                {
                    // in the scope of your catch you can use -- Console.WriteLine($"Unable to Parse '{character}'");
                    Console.WriteLine($"Unable to Parse '{item}'");
                }
            
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
