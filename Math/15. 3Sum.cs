/* 
* @Author: XIEXIAN  
* @Date: 2019-06-26 14:56:47  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-26 16:43:40
*/
using System.Collections.Generic;
using System;
namespace LeetCodeExercises
{
    /*
    需求：给出一数组，求数组中，三个元素和为0的组合
     */
    public class ThreeSum
    {
        /*
        Given array nums = [-1, 0, 1, 2, -1, -4],

        A solution set is:
        [
            [-1, 0, 1],
            [-1, -1, 2]
        ]
        */

        //想到解法一：更出所有三个元素的组合，再找出和为o的组和，加上
        public IList<IList<int>> ThreeSum01(int[] nums) {

            return null;
        }

        //解法二：
        //以判断两个数的和，是否等于另一个数的相反数 a + b = -c;=> a + b + c = 0;
        //https://leetcode.com/problems/3sum/discuss/7380/Concise-O(N2)-Java-solution
        public IList<IList<int>> ThreeSum02 (int[] nums) {
            Array.Sort(nums);                        
            IList<IList<int>> res = new List<IList<int>>();
            int len = nums.Length-2;
            for (int i = 0; i < len ; i++) {
                if (i == 0 || (i > 0 && nums[i] != nums[i-1])) {
                    int left = i+1, right = nums.Length-1, sum = 0 - nums[i];
                    while (left < right) {
                        if (nums[left] + nums[right] == sum) {
                            res.Add(new List<int>(){nums[i], nums[left], nums[right]});                                
                            while (left < right && nums[left] == nums[left+1]) left++;
                            while (left < right && nums[right] == nums[right-1]) right--;
                            left++; right--;
                        } else if (nums[left] + nums[right] < sum) {
                            // improve: skip duplicates 跳过相同的数
                            while (left < right && nums[left] == nums[left+1]) left++;
                            left++;
                        } else {
                            // improve: skip duplicates 跳过相同的数
                            while (left < right && nums[right] == nums[right-1]) right--;
                            right--;
                        }
                    }
                }
            }
            return res;        
        }
    }

}