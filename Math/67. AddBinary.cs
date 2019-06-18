using System;
using System.Text;
namespace LeetCodeExercises
{
    public class AddBinary
    {
        //解法一：不可，没通过
        public String addBinary01(String a, String b) {
            
            return Convert.ToString((Convert.ToInt32(a,2)+Convert.ToInt32(b,2)),2);//这个方法，不能处理大数据，只能在int范围内处理
        }

        //解法二：通过
        public String addBinary02(String a, String b) {
            
            StringBuilder sb = new StringBuilder();
            int i = a.Length - 1, j = b.Length -1, carry = 0;
            while (i >= 0 || j >= 0) {
                int sum = carry;
                if (j >= 0) sum += b[j--] - '0';
                if (i >= 0) sum += a[i--] - '0';
                sb.Insert(0,sum % 2);
                carry = sum / 2;
            }
            if (carry != 0) sb.Insert(0,carry);
            return sb.ToString();
        }
        
    }
}