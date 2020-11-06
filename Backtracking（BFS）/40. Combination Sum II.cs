using System.Collections.Generic;
using System;
using System.Linq;
namespace LeetCodeExercises{
    public class combinationSumII
    {
        //解法一：
        public IList<IList<int>> combinationSum01(int[] candidates,int target) {
            IList<IList<int>> list = new List<IList<int>>();
            Array.Sort(candidates);                   
            backtrack(list, new List<int>(), candidates, 0, target);
            return list;
        }
        private void backtrack(IList<IList<int>> list , List<int> tempList, int [] candidates, int start,int target){
            if(tempList.Sum() == target ) {list.Add(new List<int>(tempList));} 
            else if(tempList.Sum() < target) {
                for(int i = start; i < candidates.Length; i++){
                    if(i > start &&candidates[i] ==candidates[i-1]) continue;
                    tempList.Add(candidates[i]);
                    backtrack(list, tempList, candidates, i + 1,target);
                    tempList.RemoveAt(tempList.Count - 1);
                }
            }                 
        }

    }
}
