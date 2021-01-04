/* Create a function that finds the word "bomb" in the given string. 
If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".

Difficulty: Medium 
*/

using System;
using System.Linq;
using System.Collections.Generic;

  
// namespace declaration 
namespace CodingChallenge { 
      
    // Class declaration 
    class Challenge 
    { 
        

        static public string FindBomb(string s)
        {
            //String.Contains checks for substring, returns boolean value
            bool result = s.Contains("bomb");

            //returns string depending on if the bool is true
            if (result == true)
            {
                return "Duck!!!";
            }
            else
            {
                return "There is no bomb, relax.";
            }
        }
      
        // Main Method 
        static void Main(string[] args) 
        { 
            //Passed
            string s = "There is a bomb.";

            //Passed
            //string s = "This goes boom!!!";

            string result = FindBomb(s);

            Console.WriteLine(result);
        }
    }
             
            
} 
