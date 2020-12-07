/* Create a function that takes an array of arrays with numbers. 
Return a new (single) array with the largest numbers of each.
*/

//Difficulty: Medium


using System; 
using System.Text.RegularExpressions;
  
// namespace declaration 
namespace CodingChallenge { 
      
    // Class declaration 
    class Challenge 
    { 
        

        static public int[] FindLargest(int[][] jaggedArr)
        {
            int[] largestArr = new int[jaggedArr.Length];

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
           int[][] jaggedArr = new int[][]
           {
                new int[] {4, 2, 7, 1},
                new int[] {20, 70, 40, 90},
                new int[] {1, 2, 0}
           };

           int[] result;

           result = FindLargest(jaggedArr);

           foreach (int i in result)
           {
               Console.WriteLine("{0}", i);
           }
        }
             
            
    } 
}