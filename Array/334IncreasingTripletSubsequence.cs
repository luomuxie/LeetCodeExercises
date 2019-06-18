/* * @Author: XIEXIAN  
* @Date: 2019-05-29 14:54:24  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-05-29 16:36:48
*/
using System;
namespace LeetCodeExercises
{
    
    class IncreasingTripletSubsequence
    {
        //这个问题还是很有趣的，判断在数组中是否存在三个增序的值
        //方法一：在当前index判断左右，左边存在比其小，右边存在比其大的数，和42题中暴力求解的方式有点像
        //不过这个方法很慢，
        public bool IncreasingTriplet(int[] nums) {
            int len = nums.Length;
            if(len<3) return false;
            for (int i = 0; i < len; i++)
            {
                int curVal = nums[i];
                int rightVal = curVal;
                int leftVal = curVal;                
                for (int j = i+1; j < len; j++)
                {
                    if(nums[j]>curVal)
                    {
                        rightVal = nums[j];
                        break;
                    }                    
                }
                
                for (int j = i-1; j >=0 ; j--)
                {
                    if(nums[j]<curVal)
                    {
                        leftVal = nums[j];
                        break;
                    }                     
                }
                if(rightVal!=curVal&& leftVal!= curVal) return true;                
            }
            return false;
        }

        //方法二，优化方法一
        public bool IncreasingTriplet02(int[] nums) {
            int len = nums.Length;
            if(len<3) return false;
            int[] left_Min = new int[len];
            int[] right_Max = new int[len];
            //求左边的的最小值
            int leftMin = int.MaxValue;
            int rightMax = int.MinValue;
            for (int i = 0; i < len; i++)
            {
                leftMin = Math.Min(leftMin,nums[i]);
                left_Min[i] = leftMin;
            }
            for (int i = len -1; i >= 0; i--)
            {
                rightMax = Math.Max(rightMax,nums[i]);
                right_Max[i] = rightMax;
            }
            
            for (int i = 0; i < len; i++)
            {
                if(nums[i]>left_Min[i] && nums[i]<right_Max[i]) return true;
            }            
            return false;
        }

        //解法三：stack解法：
        //解法四：双指针求解
    }
}