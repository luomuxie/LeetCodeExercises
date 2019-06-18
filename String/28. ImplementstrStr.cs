/* 
* @Author: XIEXIAN  
* @Date: 2019-06-04 14:54:02  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-04 14:54:44
*/
namespace LeetCodeExercises
{
    //解法一：
    public class ImplementstrStr
    {
        public int StrStr01(string haystack, string needle) {
            if(needle == "")return 0;
            if(haystack.Contains(needle)) return haystack.Split(needle)[0].Length;                
            return -1;
        }
    }
}