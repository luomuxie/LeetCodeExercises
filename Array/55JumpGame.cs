using System;
using System.Linq;
namespace LeetCodeExercises{
    public class JumpGame{
        
        //解法一：求出遍历到当前点中，前面可以到达的最大距离=>最大距离当然是当前index+当前步数
        public bool CanJump01(int[] nums)
        {            
            int len = nums.Length;
            int maxDic = 0;
            for (int i = 0; i < len; i++)
            {
                if(maxDic<i) return false;
                maxDic = Math.Max(maxDic,i+nums[i]);
                if(maxDic>=len-1) return true;
            }
            return false;
        }

        //解法二：由一发展得到,只遍历到最大可走到的，虽然少了几行，可以运行起来，速度和1差不多
        public bool CanJump02(int[] nums)
        {
            int len = nums.Length;
            int i = 0;
            for (int maxDic = 0; i < len&& maxDic>=i; i++)
            {
                maxDic = Math.Max(maxDic,nums[i]+i);
            }
            return i==len;
        }

        //解法三：该方法刚好和前两种返过来，拿最大值--,减到最后还有，说明可到达
        public bool CanJump03(int[] nums)
        {
            int len = nums.Length;
            if(len<2)
                return true;
            if(nums[0]<1)
                return false;
            int curr=nums[0];
            for(int i =1;i<len;i++){
                if(nums[i]>=curr) curr=nums[i];   
                else curr--;
                if(curr<=0&&i!=len-1) return false;
            }
            return true;
        }
    }
}