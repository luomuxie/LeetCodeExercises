using System;
using System.Collections.Generic;
namespace LeetCodeExercises
{
    public class CombinationSumIII{
        public IList<IList<int>> CombinationSum3(int k, int n) {
            IList<IList<int>> list =  new List<IList<int>>();
            backtrack(list,new List<int>(),n,1,k);
            return list;
        }
        private void backtrack(IList<IList<int>> list , List<int> tempList,int remain, int start,int cnt){
            if(remain <=0){
                if(remain == 0 && tempList.Count == cnt)list.Add(new List<int>(tempList));
                return;
            }            
            for (int i = start; i <= 9; i++)
            {
                tempList.Add(i);
                backtrack(list,tempList,remain-i,i+1,cnt);
                tempList.RemoveAt(tempList.Count-1);
            }
        }
    }

}