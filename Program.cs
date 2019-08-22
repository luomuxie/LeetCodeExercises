using System;

namespace LeetCodeExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine(new AddDigits().addDigits01(38));
            //Console.WriteLine(new Sqrt().MySqrt02(8));
            //Console.WriteLine(new Pow().MyPow02(2,4));
            //Console.WriteLine(new CountPrimes().CountPrimes02(10));
            Console.WriteLine(new TwoSumII().TwoSum01(new int[]{1,2,7,11,15},9));
        }
        /*
            关于二进制运算：
            &是二进制“与”运算，参加运算的两个数的二进制按位进行运算，运算的规律是： 
            0 & 0=0
            0 & 1=0
            1 & 0=0
            1 & 1=1

            int leftShift = 2;
            int newLeftShift = leftShift << 2;
            Console.WriteLine("转换结果：{0},{1}", leftShift << 1,System.Convert.ToString(leftShift << 1,2));
            Console.WriteLine("转换结果：{0},{1}", leftShift << 2,System.Convert.ToString(leftShift << 2,2));
            Console.WriteLine("转换结果：{0},{1}", leftShift << 3,System.Convert.ToString(leftShift << 3,2));
            Console.WriteLine("转换结果：{0},{1}", leftShift << 4,System.Convert.ToString(leftShift << 4,2));
            Console.WriteLine("转换结果：{0},{1}", leftShift << 5,System.Convert.ToString(leftShift << 5,2));
         */

        public static void Rotate(int[] nums, int k)
        {     
            int len = nums.Length;
            if(k>=len)
            {
                Array.Reverse(nums);
                return;
            }

            int index = len-k;
            for (int i = index; i <len; i++)
            {   
                
                int curIndex = i;
                int curVal = nums[i]; 
                while(curIndex >i-index)
                {
                    
                    nums[curIndex] = nums[curIndex-1];
                    curIndex--;
                }
                nums[curIndex] = curVal;
            }
        }
        public static int RemoveDuplicates(int[] nums) {
            if (nums.Length == 0) return 0;
            int i = 0;
            for (int j = 1; j < nums.Length; j++) {
                if (nums[j] != nums[i]) {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }

        public static int RemoveDuplicates02(int[] nums) {
            if(nums.Length<3)return nums.Length;
            int len = nums.Length;
            int index = 2;       
            for (int i = 2; i < len; i++)
            {           
                if(nums[i] == nums[index-1]  )
                { 
                    if(nums [index-1]!= nums[index-2])
                    {
                        nums[index] = nums[i];
                        index++;                           
                    }                                           
                }
                else
                {
                    nums[index] = nums[i];
                    index++;
                }                    
            }
            return index;
        }

    }
}
