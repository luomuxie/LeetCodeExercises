using System.Collections.Generic;
using System;
namespace LeetCodeExercises{
    public class Subsets
    {
       
        /*
        Input: nums = [1,2,3]
        Output:        
        [3],
        [1],
        [2],
        [1,2,3],
        [1,3],
        [2,3],
        [1,2],
        []
        */
        //解法一：
        private  IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> subsets01(int[] nums) {
            IList<IList<int>> list = new List<IList<int>>();
            Array.Sort(nums);                   
            backtrack(list, new List<int>(), nums, 0);
            return list;
        }
        private void backtrack(IList<IList<int>> list , List<int> tempList, int [] nums, int start){
            list.Add(new List<int>(tempList));
            for(int i = start; i < nums.Length; i++){
                tempList.Add(nums[i]);
                backtrack(list, tempList, nums, i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }

        //解法二：

    }
}
