/* 
* @Author: XIEXIAN  
* @Date: 2019-06-28 14:41:50  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-28 14:51:19
*/
namespace LeetCodeExercises
{
    /*
    需求：查找数组内相加等于目标值的两个数的下标
     */
    public class TwoSumII
    {
        //解法一：双指针
        public int[] TwoSum01(int[] numbers, int target) {
            for(int i = 0, j = numbers.Length -1; i< j;){
                int sum = numbers[i] + numbers[j];
                if(sum == target){
                    return new int[] {i+1,j+1};     
                }
                else if(sum > target) j--;
                else i++;
            }
            return new int[] {-1, -1};
        }

        //解法二：二分法查找Binary Search
        public int[] TwoSum02(int[] numbers, int target) {
            int len = numbers.Length;
            for (int i = 0; i < len; i++)
            {
                int bsRes = BinarySearch(i,len-1,target,numbers);
                if(bsRes == -1) continue;
                return new int[]{i+1,bsRes+1};
            }
            return null;
        }

        private int BinarySearch(int left,int right,int target,int[] nums)
        {
            while(left<right)
            {
                int mid = left +(right - left)/2;
                if(nums[mid] == target) return mid;
                else if(nums[mid]<target) left = mid +1;
                else right = mid -1;
            }
            return nums[right] == target? right:-1;
        }
    }
}
