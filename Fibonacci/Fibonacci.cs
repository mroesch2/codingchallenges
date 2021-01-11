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
        
        static public string Fibonacci(int n)
        {
            double result;

            //Following store parts of Binet Formula that don't change
            double squareOfFive = Math.Sqrt(5);     
            double num1 = (1 + squareOfFive)/2;      
            double num2 = (1 - squareOfFive)/2; 

           //check n value to see if its greater than 200
           if (n > 200)
           {
               return "Number is too high";
           }
            //Calculation for everything past 1 using Binet Formula
            // F(n)=((1+sqrt(5)/2)^n - (1-sqrt(5)/2)^2)/sqrt(5)
            else
            {
                num1 = Math.Pow(num1, n);
                num2 = Math.Pow(num2, n);

                result = (num1 - num2)/squareOfFive;

                string answer = result.ToString();

                return answer;
            }
        }
      
        // Main Method 
        static void Main(string[] args) 
        { 
           int n = 11;

           string result = Fibonacci(n);

           //If n is greater than 200, print an error message 
               Console.WriteLine($"Done. Answer is {result}");
        }
    }
             
            
} 