/* 
* @Author: XIEXIAN  
* @Date: 2019-06-03 20:36:35  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-03 21:10:58
*/
namespace LeetCodeExercises
{
    using System;
    public class MaximumGap
    {
        //解法一：
        public int MaximumGap01(int[] nums) {
            int len = nums.Length;
            if(len<2) return 0;
            Array.Sort(nums);
            int curVal = nums[0],maxDiff = int.MinValue;
            for (int i = 1; i < len; i++)
            {
                maxDiff = Math.Max(maxDiff,nums[i]-curVal);
                curVal = nums[i];
            }
            return maxDiff;
        }

        
        //解法二：暂时没想出比一还优的方法
        public int MaximumGap02(int[] nums) {
            return 0;
        }
    }
}