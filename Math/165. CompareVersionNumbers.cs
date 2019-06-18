/* 
* @Author: XIEXIAN  
* @Date: 2019-06-14 14:48:57  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-14 14:50:47
*/
using System;
namespace LeetCodeExercises
{
    public class CompareVersionNumbers
    {

        //速度还可以，这题比较简单，就不多写几个方法了
        public int CompareVersion(string version1, string version2)
        {
            //version1 = "1.01", version2 = "1.001"
            string[] ver01Arr = version1.Split(".");
            string[] ver02Arr = version2.Split(".");
            int len1 = ver01Arr.Length;
            int len2 = ver02Arr.Length;
            int len = Math.Max(len1,len2);
            for (int i = 0; i < len; i++)
            {
                int Val1 = len1 >i?int.Parse(ver01Arr[i]):0;
                int Val2 =  len2 >i?int.Parse(ver02Arr[i]):0;
                if(Val1>Val2) return 1;
                else if (Val1<Val2) return -1;               
            }
            return 0;
        }
    }
}