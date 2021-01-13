/* Someone has attempted to censor my strings by replacing every vowel with a *, l*k* th*s. 
Luckily, I've been able to find the vowels that were removed.
Given a censored string and a string of the censored vowels, return the original uncensored string.

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
        
        static public string Uncensor(string censored, string vowels)
        {
           //Convert strings to char arrays to replace each * with matching vowel
           char[] cen = censored.ToCharArray();
           char[] vow = vowels.ToCharArray();
           bool result;
           int n = 0;
           
          //loop to get inside the cen array
           for (int i = 0; i < censored.Length; i++)
           {
             result = cen[i].Equals('*');

             if(result == true)
             {
               cen[i] = vow[n];
               n++;
             }
             else
             {
                 cen[i] = cen[i];
             }
           }
          
          censored = new string(cen);
          return censored;

        }
      
        // Main Method 
        static void Main(string[] args) 
        { 
          string result = Uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo");

          Console.WriteLine(result);
        }
    }
             
            
} 
