
namespace LeetCodeExercises
{
    public class FirstMissingPositive
    {
        public int GetFirstMissingPositive(int[] nums) {                              
            if(nums == null && nums.Length == 0) return 1;            
            int len = nums.Length;          
            for (int i = 0; i < len; i++)
            {
                while(nums[i]>0 && nums[i]<len && nums[nums[i]-1] != nums[i])
                {
                    int temp = nums[nums[i]-1];
                    nums[nums[i]-1] = nums[i];
                    nums[i] = temp;
                }
            }

            for (int i = 0; i < len; i++)
            {
                if(nums[i] != i+1) return i+1;
            }
            return 1;
        }
    }
}