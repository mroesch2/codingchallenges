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

         static public string Decrypt(int[] message)
        {
            //Converts first number in array to a char
            char c = Convert.ToChar(message[0]);
            
            //Creates the string answer with the first letter
            string answer = c.ToString();
            
            //Variable to hold the sum of two nums in the for loop
            int sum;
           
            //stores temp char to be put in the answer
            char temp;

            //Sets the current number used in the for loop
            int currNum = message[0];

            //starts at 1 since message[0] is already found
            for (int i = 1; i < message.Length; i++)
            {
                //calculates the sum between the current array item and one before it to get the ascii decimal character    
                sum = currNum + message[i];


                //stores the sum value as a temporary char value so it can be added to the string
                temp = Convert.ToChar(sum);

                //stores next char in the answer
                answer += temp.ToString();

                //updates num to current array item to be used in next calculation
                currNum = sum;
                
            }

            return answer;

        }
      
        // Main Method 
        static void Main(string[] args) 
        { 
            int[] arr = {72, 33, -73, 84, -12, -3, 13, -13, -68 };
            //string result = Encrypt("Hello");
            string result = Decrypt(arr);
            //string result = Encrypt("Sunshine");

          Console.WriteLine(result);
        }
    }
             
            
} 
