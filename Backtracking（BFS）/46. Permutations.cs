using System;
using System.Collections.Generic;
namespace LeetCodeExercises{
    public class Permutations{
        public IList<IList<int>> Permute(int[] nums) {
            IList<IList<int>> list = new List<IList<int>>();
            helper(list,nums,new List<int>());
            return list;
        }

        private void helper(IList<IList<int>> list,int[] nums,List<int> tempList){
            if(tempList.Count == nums.Length){
                list.Add(new List<int>(tempList));               
            }else{
                for (int i = 0; i <nums.Length ; i++)
                {
                    if(tempList.Contains(nums[i])) continue;
                    tempList.Add(nums[i]);
                    helper(list,nums,tempList);
                    tempList.RemoveAt(tempList.Count-1);
                }
            }            
        } 
    }
}
