/* 
* @Author: XIEXIAN  
* @Date: 2019-06-14 18:29:00  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-14 18:32:18
*/
namespace LeetCodeExercises
{
    public class AddDigits
    {
        public int addDigits01(int num) {
            while(num>9)
            {
                int val = num;
                num = 0;
                while (val>0)
                {                    
                    int remain = val%10;
                    num += remain;
                    val/=10;                    
                }
            }
            return num;
        }
    }
}