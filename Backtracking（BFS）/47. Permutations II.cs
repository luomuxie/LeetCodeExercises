using System;
using System.Collections.Generic;
namespace  LeetCodeExercises
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
                    if( (i>0 && nums[i] == nums[i-1])) continue;
                    int len = tempList.Count;
                    if(len>0){
                        if(tempList[len-1] == nums[i]) continue;
                    }
                    tempList.Add(nums[i]);
                    helper(list,nums,tempList);
                    tempList.RemoveAt(tempList.Count-1);
                }
            }
        }

        public List<List<Integer>> permuteUnique(int[] nums) {
            List<List<Integer>> list = new ArrayList<>();
            Arrays.sort(nums);
            backtrack(list, new ArrayList<>(), nums, new boolean[nums.length]);
            return list;
        }
    
        private void backtrack(List<List<Integer>> list, List<Integer> tempList, int [] nums, boolean [] used){
            if(tempList.size() == nums.length){
                list.add(new ArrayList<>(tempList));
            } else{
                for(int i = 0; i < nums.length; i++){
                    if(used[i] || i > 0 && nums[i] == nums[i-1] && !used[i - 1]) continue;
                    used[i] = true; 
                    tempList.add(nums[i]);
                    backtrack(list, tempList, nums, used);
                    used[i] = false; 
                    tempList.remove(tempList.size() - 1);
                }
            }
        }
    }    
}