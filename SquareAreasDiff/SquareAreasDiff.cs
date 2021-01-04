/*Imagine a circle and two squares: a smaller and a bigger one. For the smaller one, 
the circle is a circumcircle and for the bigger one, an incircle.
Create a function, that takes an integer (radius of the circle) 
and returns the difference of the areas of the two squares.

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
        

        static public int SquareAreasDiff(int r)
        {
            //Need the area of the inner square which is r*r*2
            int inner = (r*r*2);

            //Area for outer would be the opposite r/r/2
            int outer = (r/r/2);

            //Stores the different between the two areas 
            int result = inner - outer;

            return result;
        
        }
      
        // Main Method 
        static void Main(string[] args) 
        { 
            //int radius = 5;       //Passed
            //int radius = 6;       //Passed
            int radius = 7;

            int difference = SquareAreasDiff(radius);

            Console.WriteLine(difference);
        }
    }
             
            
} 
