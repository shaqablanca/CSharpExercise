using System;

namespace BuildArrayFromPermutation
{
   
    public class BuildArrayFromPermutation
    {
        static void Main(String[] args)
        {
            int[] nums = {0,2,1,5,3,4};
            int[] ans = Array.Empty<int>();
            int i = 0;

            while(i<nums.Length)
            {
                ans = ans.Append(nums[nums[i]]).ToArray();
                i++;
            }

            Console.WriteLine(string.Join("-", ans));
           
        }
              
    }
}
