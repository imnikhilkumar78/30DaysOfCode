/* Prog 1- Two Sum
 Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1] */

using System.Globalization;
using System.Numerics;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Size of array");
        int sizeofArray = Convert.ToInt32(Console.ReadLine());
        int[] numarray = new int[sizeofArray];
        Console.WriteLine("Enter The Array");
        for(int i=0;i<sizeofArray;i++)
        {
            numarray[i]=Convert.ToInt32(Console.ReadLine());    
        }
        Console.WriteLine("Enter The Target");
        int target=Convert.ToInt32(Console.ReadLine());

        Program newProgram = new Program();
        newProgram.TwoSum(numarray, target);
    }

    void TwoSum(int[] numarray, int target)
    {
        for(int i=0;i<numarray.Length;i++)
        {
            for(int j=i+1;j<numarray.Length;j++)
            {
                if (numarray[i] + numarray[j]==target)
                {
                    Console.WriteLine("["+i+", "+j+"]");
                    break;
                }
            }
            
        }

    }
}