/* 
* @Author: XIEXIAN  
* @Date: 2019-06-05 14:59:55  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-05 15:19:10
*/
namespace LeetCodeExercises
{
    public class RansomNote
    {
        //该方法很慢很慢，应该出在了indexOf和remove的两个调用上了
        public bool CanConstruct01(string ransomNote, string magazine) {
            int len = ransomNote.Length;
            for (int i = 0; i < len; i++)
            {
                char ch = ransomNote[i];
                if(magazine.IndexOf(ch)==-1) return false;
                else
                {
                    magazine = magazine.Remove(magazine.IndexOf(ch),1);
                }
            }
            return true;
        }

        // 解法二：记录个数对比
        public bool CanConstruct02(string ransomNote,string magazine)
        {
            int[] count = new int[26];
            foreach(char c in magazine)
            {
                count[c - 'a']++;
            }            
            foreach(char c in ransomNote)
            {
                if (--count[c - 'a'] < 0)return false;
            }
            return true;
        }
    }
}