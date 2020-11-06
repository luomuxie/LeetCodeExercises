using System.Collections.Generic;
using System;
namespace LeetCodeExercises{
    public class CombinationSum
    {       
        //解法一：        
        public IList<IList<int>> subsets01(int[] nums,int target) {
            IList<IList<int>> list = new List<IList<int>>();
            Array.Sort(nums);                   
            backtrack(list, new List<int>(), nums, target,0);
            return list;
        }
        private void backtrack(IList<IList<int>> list , List<int> tempList, int [] nums,int remain, int start){
            if(remain < 0) return;
            list.Add(new List<int>(tempList));
            for(int i = start; i < nums.Length; i++){
                tempList.Add(nums[i]);
                backtrack(list, tempList, nums, remain - nums[i], i);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }

        //解法二：

    }
}
