using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestions
{
    public class ArrayRotation
    {
        public void RotateArray()
        {
            Console.WriteLine("Enter Size Of Array To be Rotated");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] originalArray = new int[n];
            Console.WriteLine("Enter the Original Array");
            for(int i=0;i<n;i++)
            {
                originalArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the value you want by which you want array to rotate");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Enter 1 to rotate Left" +
                "2. Enter 2 to rotate Right");
            int choice = Convert.ToInt32(Console.ReadLine());

            int[] rotatedArray=new int[n];

            switch(choice)
            {
                case 1:
                    rotatedArray=printLeftRotatedArray(originalArray, d, n);
                    break;
                case 2:
                    rotatedArray=printRightRotatedArray(originalArray, d, n);
                    break;
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Original Array");
            Console.WriteLine("-------------------------------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.Write(originalArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Rotated Array");
            Console.WriteLine("--------------------------------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.Write(rotatedArray[i]);

            }



        }

        public int[] printLeftRotatedArray(int[] originalArray,int d, int n)
        {
            int k = 0;//Keeping rotated array index

            int[] rotatedarray=new int[n];
            for(int i=d;i<n;i++)
            {
                rotatedarray[k]=originalArray[i];
                k++;
            }
            for (int i = 0; i < d; i++)
            {
                rotatedarray[k] = originalArray[i];
                k++;
            }
            return rotatedarray;
            
        }
        public int[] printRightRotatedArray(int[] originalArray,int d, int n)
        {
            int k = 0;//Keeping rotated array index

            int[] rotatedarray = new int[n];
            for (int i = n-d; i < n; i++)
            {
                rotatedarray[k] = originalArray[i];
                k++;
            }
            for (int i = 0; i < n-d; i++)
            {
                rotatedarray[k] = originalArray[i];
                k++;
            }
            return rotatedarray;

        }
    }
}
