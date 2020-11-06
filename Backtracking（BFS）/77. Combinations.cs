using System.Collections.Generic;
using System;
namespace  LeetCodeExercises
{
    public class Combinations{
        public IList<IList<int>> Combine(int n, int k) {
            IList<IList<int>> list = new List<IList<int>>();
            IList<IList<int>> res = new List<IList<int>>();
            int[] nums = new int[n];           
            for (int i = 1; i <= n; i++)
            {
                nums[i-1] = i;
            }            
            list.Add(new List<int>());
            for (int i = 0; i < nums.Length; i++)
            {
                int cnt = list.Count;
                for (int j = 0; j < cnt; j++)
                {
                    List<int> tempList = new List<int>(list[j]);
                    tempList.Add(nums[i]);
                    if(tempList.Count>k)continue;
                    list.Add(tempList); 
                    if(tempList.Count == k) res.Add(tempList);                                     
                } 
            }
            return res;        
        }

        //解法二：
        private  IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> Combine02(int n, int k) {
            IList<IList<int>> list = new List<IList<int>>();
            res.Clear();
            int[] nums = new int[n];           
            for (int i = 1; i <= n; i++) nums[i-1] = i;                 
            backtrack(list, new List<int>(), nums, 0,k);
            return res;
        }
        private void backtrack(IList<IList<int>> list , List<int> tempList, int [] nums, int start,int k){
            list.Add(new List<int>(tempList));
            if(tempList.Count == k) res.Add(new List<int>(tempList));
            for(int i = start; i < nums.Length; i++){                
                tempList.Add(nums[i]);
                backtrack(list, tempList, nums, i + 1,k);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }

         //解法三：

        public IList<IList<int>> combine(int n, int k) {
            IList<IList<int>> list = new List<IList<int>>();
            dfs(list, new List<int>(), k, 1, n-k+1);
            return list;
        }

        private void dfs(IList<IList<int>> list, List<int> tempList, int k, int from, int to) {
            if (k == 0) {list.Add(new List<int>(tempList)); return; }
            for (int i=from; i<=to; ++i) {
                tempList.Add(i);
                dfs(list, tempList, k-1, i+1, to+1);
                tempList.RemoveAt(tempList.Count-1);
            }
        }
    }
}