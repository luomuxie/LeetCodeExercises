/* 
* @Author: XIEXIAN  
* @Date: 2019-06-05 15:53:22  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-05 17:27:12
*/
using System;
using System.Linq;
namespace LeetCodeExercises
{
    public class ReverseWordsinaString
    {
        //解法一：慢慢的
        public string ReverseWords01(string s) {
            if(s == "") return "";          
            string[] strArr = s.Split();
            string res ="";
            for (int i = strArr.Length -1; i >= 0; i--)
            {
                if(strArr[i] != "")
                {
                    if(res == "") res += strArr[i];
                    else res += " "+strArr[i];
                }
            }                  
            return res;
        }

        //解法一：没了循环里面的判断，能快40多ms
        public string ReverseWords02(string s) {
            if (String.IsNullOrEmpty(s) || String.IsNullOrWhiteSpace(s)) return string.Empty;           
            if(s == "") return "";          
            string[] strArr = s.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            string res ="";
            for (int i = strArr.Length -1; i >= 0; i--)
            {
                res += " "+strArr[i];
            }                  
            return res.Substring(1);
        }

        //解法三：加入双指针，其实和二差不多
        public string ReverseWords03(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            var words = s.Split(new [] {" "}, StringSplitOptions.RemoveEmptyEntries);
            int i = 0, j = words.Length - 1;
            while(i <= j) {
                var t = words[i];
                words[i] = words[j];
                words[j] = t;
                i++;j--;
            }
            return string.Join(" ", words); 
        }    

    }
}