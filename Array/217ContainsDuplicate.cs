using System;
using System.Collections.Generic;
using System.Linq;
namespace LeetCodeExercises{
    public class ContainsDuplicate{

        //解法一：
        //使用字典解决（主要利用字典的唯一key特性）
        public bool isContainsDuplicate01(int[] nums)
        {
            Dictionary<int,int> dic = new Dictionary<int, int>();
            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                if(dic.ContainsKey(nums[i]))
                    return true;
                else
                    dic.Add(nums[i],1);
            }           
            return false;
        }

        //解法二：
        //使用linq解
        public bool isContainsDuplicate02(int[] nums)
        {             
            return  nums.Distinct().Count() != nums.Length;
        }

        //解法三：
        //最普通遍历解法，时间复杂度最高（不推荐）
        public bool isContainsDuplicate03(int[] nums)
        {
            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; i < len; j++)
                {
                    if(i!=j && nums[i] == nums[j]) return true;
                }
            }
            return false;
        }
    }
}