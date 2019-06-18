/* 
* @Author: XIEXIAN  
* @Date: 2019-06-13 11:00:39  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-13 16:04:28
*/
using System.Text;
namespace LeetCodeExercises
{
    public class IntegertoRoman
    {
        //这题，嗯，其实我还没搞明白
        /*
            Input: 1994
            Output: "MCMXCIV"
            Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
         */
         //呃解上不出，怎么办哦，算了，直接看答案吧
        public string IntToRoman01(int num) {
            string[] numerals = new string[] {"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"};
            int[] values = new int[] {1000,900,500,400,100,90,50,40,10,9,5,4,1};
            StringBuilder sb = new StringBuilder();
            int i=0;
            while(num>0){
                if(num-values[i]>=0){
                    sb.Append(numerals[i]);
                    num=num-values[i];
                }else{
                    i++;
                }
            }
            return sb.ToString();            
        }

        public string toInt(int item) {
            switch(item) {
                case 1: return "I";
                case 5: return "V"; 
                case 10: return "X";
                case 50: return "L";
                case 100: return "C";
                case 500: return "D";
                case 1000: return "M";
            }
            return "";
        }
    }
}