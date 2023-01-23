using System;

namespace Summator
{
    public static class Summator
    {
    
        public static long Sum(int[] arr)
        {
            // Test method for sum of array from numbers
            long sum = 0;
            for (int i=0; i<arr.Length; i++)
                sum += arr[i];
        
            return sum;
        }
    
        public static double Average(int[] arr)
        {
            double sum = 0;
        
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
        

                double avgSum = Math.Round(sum / arr.Length, 2);

                return avgSum;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide with 0!", e);
                throw;
            }

        }
    }
}

