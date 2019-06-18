using System;
namespace LeetCodeExercises{
    public class JumpGameII{

        //解法一：
        public int Jump01(int[] nums) {
            int len = nums.Length;
            int maxDis = 0;
            int cnt = 0;
            int next = 0;
            for (int i = 0; i < len; i++)
            {
                if(maxDis<i)
                {
                    maxDis = next;
                    cnt++;
                };                
                if(maxDis>=len-1) return cnt;
                next= Math.Max(next,i+nums[i]);                
            }
            return cnt;
        }

        //解法二:
        public int Jump02(int[] nums) {
            
            
            return 0;     
        }
    }
}