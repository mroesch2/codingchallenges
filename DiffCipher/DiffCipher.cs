/* It's time to send and receive secret messages.
Create two functions that take a string and an array and returns a coded or decoded message.
The first letter of the string, or the first element of the array represents the
 Character Code of that letter. The next elements are the differences between the characters: 
 e.g. A +3 --> C or z -1 --> y.

Difficulty: Hard
*/

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

  
// namespace declaration 
namespace CodingChallenge { 
      
    // Class declaration 
    class Challenge 
    { 
        
        static public string Encrypt(string message)
        {
            int n;
            //string answer = " ";
            char[] cArr = message.ToCharArray();
            int temp;
            int diff;

           //Get the starting number
            n = Convert.ToInt32(cArr[0]);

            //Convert to a string and add to answer
            string answer = n.ToString() + " ";

            
            for (int i = 1; i < cArr.Length; i++)
            {
                //store next value in a temp variable
                temp = Convert.ToInt32(cArr[i]);
                
                //find the difference between the current and previous number
                diff = temp - n;
    

                //store the difference in answer
                answer += diff.ToString() + " ";

                //Update n to the current value 
                n = cArr[i];
            }

            return answer;
        }

         /*static public string Decrypt(int[] message)
        {
          
        }*/
      
        // Main Method 
        static void Main(string[] args) 
        { 
          string result = Encrypt("Hello");
          //Decrypt([ 72, 33, -73, 84, -12, -3, 13, -13, -68 ])
          //string result = Encrypt("Sunshine");

          Console.WriteLine(result);
        }
    }
             
            
} 
