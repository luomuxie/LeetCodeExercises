using System;
using System.Linq;

namespace LeetCodeExercises
{
    public class MaxSubArray
    {
        public int  GetMaxSubArray(int[] nums) {
            //{-2,1,-3,4,-1,2,1,-5,4});
            int len = nums.Length;
            for (int i = 1; i < len ; i++)
            {
                if(nums[i-1]>0)
                    nums[i] += nums[i-1];                            
            }
            
            return nums.Max();          
        }
    }
}
