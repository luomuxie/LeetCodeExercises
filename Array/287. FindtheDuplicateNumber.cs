/* 
* @Author: XIEXIAN  
* @Date: 2019-06-03 21:43:24  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-04 12:30:31
*/

namespace LeetCodeExercises
{
    using System;
    public class FindtheDuplicateNumber
    {
        //找出重复字
        public int FindDuplicate01(int[] nums) 
        {   
            
            int len = nums.Length;
            if(len == 0) return 0;
            Array.Sort(nums);            
            int curVal = nums[0];
            for (int i = 1; i < len; i++)
            {
                if(nums[i] == curVal) return curVal;
                curVal = nums[i];
            }
            return 0;
        }

        //此解法比，减少了解法一中的排序过程，但空间多了n，运算时间优一点点
        public int FindDuplicate02(int[] nums) 
        {               
            int len = nums.Length;
            int[] s = new int[len];
            Boolean[] seen = new Boolean[len];            
            int i = 0;            
            while (i < len) {
                
                if (seen[nums[i]]) {
                    return nums[i];
                } else {
                    seen[nums[i]] = true;
                }
                i++;
            }
            return -1;
        }

        //解法三：
        public int FindDuplicate03(int[] nums) {
                int i = 0;
            while (i < nums.Length) {
                if(nums[i] != i+1){
                    if (nums[i] != nums[nums[i] - 1])
                        Swap(nums, i, nums[i] - 1);
                    else // we have found the duplicate
                        return nums[i];
                }                
                else
                    i++;
            }
            return -1;
        }
        private void Swap(int[] arr, int i, int j) {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}

