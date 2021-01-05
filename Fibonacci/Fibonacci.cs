/* Create a function to return the Nth number in the Fibonacci sequence as a string.
Your function is expected to calculate numbers greater than UInt64.MaxValue 
where n can be as large as but not greater than 200.

Difficulty: Hard
*/

using System;
using System.Linq;
using System.Collections.Generic;

  
// namespace declaration 
namespace CodingChallenge { 
      
    // Class declaration 
    class Challenge 
    { 
        
        static public int Fibonacci(int n)
        {
           //check n value to see if its greater than 200
           if (n > 200)
           {
               return 0;
           }

        }
      
        // Main Method 
        static void Main(string[] args) 
        { 
           int n = 50;

           int result = Fibonacci(n);

           //If n is greater than 200, print an error message 
           if (result == 0)
           {
               Console.WriteLine("Number cannot be larger than 200. Try again");
           }
           else
           {
               Console.WriteLine(result);
           }
        }
    }
             
            
} 