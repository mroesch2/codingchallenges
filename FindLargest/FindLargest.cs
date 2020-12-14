/* Create a function that takes an array of arrays with numbers. 
Return a new (single) array with the largest numbers of each.
*/

//Difficulty: Medium


using System;
using System.Linq;
using System.Collections.Generic;
  
// namespace declaration 
namespace CodingChallenge { 
      
    // Class declaration 
    class Challenge 
    { 
        

        static public double[] FindLargest(double[][] jaggedArr)
        {
            double[] largestArr = new double[jaggedArr.Length];

            //get into the rows of the array
            for (int i = 0; i < jaggedArr.Length; i++)
            {
 
                //Gets into the columns of the array
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    /*If the element of the jagged array is bigger 
                    Replace with larger element*/
                    if (largestArr[i] < jaggedArr[i][j])
                    {
                        largestArr[i] = jaggedArr[i][j];
                    }
                   
                }

            }

            return largestArr;
        }
      
        // Main Method 
        static void Main(string[] args) 
        { 
           //Create and initialize an array of arrays
           double[][] jaggedArr = new double[][]
           {
                new double[] {0.4321, 0.7634, 0.652},
                new double[] {1.324, 9.32, 2.5423, 6.4314},
                new double[] {9, 3, 6, 3}
           };

           double[] result;

           result = FindLargest(jaggedArr);

           foreach (int i in result)
           {
               Console.WriteLine("{0}", i);
           }
        }
             
            
    } 
}