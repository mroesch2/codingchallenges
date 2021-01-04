/* Every quadratic curve y = a x² + b x + c has a vertex point: 
the turning point where the curve stops heading down and starts going up.

Given the values a, b and c, you need to return the coordinates of the vertex. 
Return your answers rounded to 2 decimal places.

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
        
        //Returning multiple values so store it in a double array
        static public double[] FindVertex(double a, double b, double c)
        {
            //Quad equation: y = ax2 + bx + c

            //store values in double array
            double[] result = new double[2];
            
            //to find x-coordinate use -b/2a
            double x = (b * -1)/(2*a);

            //for y, plug in above result for x and solve for y
            double y = (a*x*2) + (b * x) + c;

            result[0] = x;
            result[1] = y;

            return result;

        }
      
        // Main Method 
        static void Main(string[] args) 
        { 
            double[] result = new double[2];
            
            result = FindVertex(1, 0, 25);        //[0, 25]
            //FindVertex(-1, 0, 25)       //[0, 25]
            //FindVertex(1, 10, 4)        //[-5, -21]

            Console.WriteLine($"The vertex is at: ({result[0]} , {result[1]})");
        }
    }
             
            
} 