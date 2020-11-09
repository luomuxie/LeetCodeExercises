using System;
using System.Collections.Generic;
namespace LeetCodeExercises
{
    public class PermutationsII{
        public IList<IList<int>> PermuteUnique(int[] nums) {
            IList<IList<int>> list = new List<IList<int>>();
            Array.Sort(nums);
            helper(list,nums,new List<int>());
            return list;
        }
        private void helper(IList<IList<int>> list,int[] nums,List<int> tempList){
            if(tempList.Count == nums.Length){
                list.Add(new List<int>(tempList));               
            }else{
                for (int i = 0; i <nums.Length ; i++)
                {                    
                    if( (i>0 && nums[i] == nums[i-1])) continue;//如果是重复的跳过
                    int len = tempList.Count;
                    if(len>0){
                        if(tempList[len-1] == nums[i]) continue;//如果是自己跳过
                    }
                    tempList.Add(nums[i]);
                    helper(list,nums,tempList);
                    tempList.RemoveAt(tempList.Count-1);//回溯到这个分支前的tempList状态
                }
            }
        }
    }    
}