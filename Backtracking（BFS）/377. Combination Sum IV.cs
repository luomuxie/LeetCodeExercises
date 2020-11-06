using System;
using System.Collections.Generic;
namespace  LeetCodeExercises{
    public class CombinationSumIV{

        //解法一，该解法在leetcode上会因为时间超时，而无法通过
        private int res;
        public int CombinationSum4_01(int[] nums, int target) {            
            backtrack(new List<int>(),target,nums);           
            return res;
        }
        private void backtrack( List<int> tempList,int remain,int[] nums){
            if(remain <=0){
                if(remain == 0 )res++;
                return;
            }            
            for (int i = 0; i <nums.Length; i++)
            {
                tempList.Add(i);
                backtrack(tempList,remain-nums[i],nums);
                tempList.RemoveAt(tempList.Count-1);
            }
        }

        //解法二，使用dp算法对解法一优化
        private int[] dp;
        public int CombinationSum4_02(int[] nums, int target) {
            dp = new int[target + 1];
            Array.Fill(dp, -1);
            dp[0] = 1;
            return helper(nums, target);
        }

        private int helper(int[] nums, int target) {
            if (dp[target] != -1) {
                return dp[target];
            }
            int res = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (target >= nums[i]) {
                    res += helper(nums, target - nums[i]);
                }
            }
            dp[target] = res;
            return res;
        }

        //解法三,对解法二的优化
        public int CombinationSum4_03(int[] nums, int target) {
            int[] comb = new int[target + 1];
            comb[0] = 1;
            for (int i = 1; i < comb.Length; i++) {
                for (int j = 0; j < nums.Length; j++) {
                    if (i - nums[j] >= 0) {
                        comb[i] += comb[i - nums[j]];
                    }
                }
            }
            return comb[target];
        }
    }
} 
