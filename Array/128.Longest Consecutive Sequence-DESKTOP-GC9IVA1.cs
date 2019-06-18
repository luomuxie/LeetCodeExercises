/* 
* @Author: XIEXIAN  
* @Date: 2019-05-31 11:11:13  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-05-31 11:46:30
*/

using System;
namespace LeetCodeExercises
{   
    public class LongestConsecutiveSequence
    {
        //解法一，这算法已经够优了吧，当然，如果能去掉排序，可以是个优化方向
        public int LongestConsecutive01(int[] nums)
        {
            int len = nums.Length;
            if(len < 0) return 0;
            Array.Sort(nums);
            int res = 0,curVal = nums[0],maxRes = 0;
            for (int i = 1; i < len; i++)
            {
                if(nums[i] == curVal) continue;
                if(nums[i] == curVal+1) res++;
                else
                {
                    maxRes = Math.Max(res,maxRes);
                    res = 0;
                }
                curVal = nums[i];            
            }
            maxRes = Math.Max(res,maxRes);         
            return maxRes == 0?1:maxRes+1;
        }

        //解法二：去除排列TODO
        
    }
}