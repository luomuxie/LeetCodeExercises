namespace LeetCodeExercises
{
    using System;
    public class BinarShearch{
        public int BinarShearch01(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length-1;
            int mid;
            while(left <= right)
            {
                mid = (left+ right)/2;
                if(nums[mid] == target)
                {
                    return mid;
                }
                else if(nums[mid]< target)
                    left = mid+1;
                else if(nums[mid]>target)
                    right = mid-1;
                Console.WriteLine("left:{0},mid:{1},right:{2},",left,mid,right);
            }
            return -1;
        }

        public int BinarShearch02(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length;
            int mid;
            while(left <right)//意数是最大到等于的时候要找到
            {
                mid = (left +right)/2;
                if(nums[mid] == target)
                    return mid;
                else if(nums[mid]< target)
                    left = mid+1;
                else if(nums[mid]>target)
                    right = mid-1;
                Console.WriteLine("left:{0},mid:{1},right:{2},",left,mid,right);               
            }
            return -1;
        }
    }
}