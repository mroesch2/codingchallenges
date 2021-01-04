/* Create a function that finds the word "bomb" in the given string. 
If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".

Difficulty: Medium 
*/

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
  
// namespace declaration 
namespace CodingChallenge { 
      
    // Class declaration 
    class Challenge 
    { 
        

        static public string FindBomb(string s)
        {

            bool result = s.Contains("bomb");

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
            string s = "There is a bomb.";
            //string s = "This goes boom!!!";

            string result = FindBomb(s);

            Console.WriteLine(result);
        }
    }
             
            
} 
