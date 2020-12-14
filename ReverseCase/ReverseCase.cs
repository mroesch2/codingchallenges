/*Given a string, create a function to reverse the case. 
All lower-cased letters should be upper-cased, and vice versa. 

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
        

        static public string ReverseCase(string str)
        {
            //convert to a char array for letter by letter basis
            char[] charArr = str.ToCharArray();

            //loop through all items in char array
            for (int i = 0; i < charArr.Length; i++)
            {
                //Convert to lower if upper case
                if (char.IsUpper(charArr[i]) == true)
                {
                    charArr[i] = char.ToLower(charArr[i]);
                }
                //convert to upper if lower case
                else if (char.IsLower(charArr[i]) == true)
                {
                    charArr[i] = char.ToUpper(charArr[i]);
                }
                //for other characters
                else
                {
                    charArr[i] = charArr[i];
                }
            }

            string result = new string(charArr);
            return result;
        }
      
        // Main Method 
        static void Main(string[] args) 
        { 
            //string str = "Happy Birthday";
            string str = "sPoNtAnEoUs";
            
           string result = ReverseCase(str);

           Console.WriteLine(result);
        }
    }
             
            
} 
