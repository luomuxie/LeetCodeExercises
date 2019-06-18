/* 
* @Author: XIEXIAN  
* @Date: 2019-06-11 17:29:23  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-11 18:00:24
*/
using System;
using System.Text;
namespace LeetCodeExercises
{
    
    public class ExcelSheetColumnTitle
    {

        //解法一：鸭蛋，挂了。。。。,看看别人的解法三
        public string ConvertToTitle01(int n)
        {
            string result = "";
            while(n>0)
            {
                int temp = n%26;
                n = (int) Math.Floor((double)n/26);               
                if(temp== 0&&n!=0)temp = 26;
                if(n == 1 && temp == 26) n = 0;             
                result = ((char)('A'+temp-1)).ToString()+result;
            }
            return result;
        }

        //解法三：
        public string ConvertToTitle03(int n)
        {
            StringBuilder sb = new StringBuilder();
            while (n != 0) {
                int remainder = n % 26;
                if (remainder == 0)
                    remainder += 26; // 'Z'
                if (n >= remainder) {
                    n -= remainder;
                    sb.Insert(0,(char) (remainder + 64));
                }
                n /= 26;
            }
            return sb.ToString();
        }

        //解法二：
        public string ConvertToTitle02(int n)
        {
            StringBuilder sb = new StringBuilder();
            while(n > 0){                
                sb.Insert(0,(char)(--n % 26 + 'A'));
                n /= 26;
            }
            return sb.ToString();
        }
    }
}