using System.Collections.Generic;
using System;
using System.Linq;
namespace LeetCodeExercises
{
    public class SubSetsII{
        //解法一：
        public static IList<IList<int>> Subsets01(int[] nums) {
            IList<IList<int>> list = new List<IList<int>>();
            Array.Sort(nums);
            list.Add(new List<int>());
            int preCnt = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int cnt = list.Count;
                int tempCnt = 0;
                for (int j = cnt-1; j >= 0; j--)
                {
                    if( i >0 &&nums[i] == nums[i-1] && j<cnt-preCnt)break;
                    List<int> tempList = new List<int>(list[j]);
                    tempList.Add(nums[i]);                    
                    list.Add(tempList);
                    tempCnt++;                    
                }
                preCnt = tempCnt;
            }
            return list;
        } 

        //解法二：
        public IList<IList<int>> Subsets02(int[] nums) {
            IList<IList<int>> list = new List<IList<int>>();
            Array.Sort(nums);                   
            backtrack(list, new List<int>(), nums, 0);
            return list;
        }
        private void backtrack(IList<IList<int>> list , List<int> tempList, int [] nums, int start){
            list.Add(new List<int>(tempList));
            for(int i = start; i < nums.Length; i++){
                if(i > start && nums[i] == nums[i-1]) continue;
                tempList.Add(nums[i]);
                backtrack(list, tempList, nums, i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}