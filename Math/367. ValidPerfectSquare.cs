namespace LeetCodeEnumercises
{
    public class ValidPerfectSquare
    {

        //不使用数数math.sqr，求出开方是否为整数
        public bool IsPerfectSquare01(int num) {
            if(num == 0 || num == 1) return true;
            int start = 2,end = num/2;
            while (start<= end)
            {
                int mid = start+(end-start) /2;
                if(mid == num/mid) return mid*mid == num ;
                else if(mid<num/mid) start = mid+1;
                else end = mid-1;
            }                        
            return false;
        }

        /*
        解法二：
        1 = 1
        4 = 1 + 3
        9 = 1 + 3 + 5
        16 = 1 + 3 + 5 + 7
        25 = 1 + 3 + 5 + 7 + 9
        36 = 1 + 3 + 5 + 7 + 9 + 11
        ....
        so 1+3+...+(2n-1) = (2n-1 + 1)n/2 = nn
        */
        public bool IsPerfectSquare02(int num) {
            int i = 1;
            while (num > 0) {
                num -= i;
                i += 2;
            }
            return num == 0;
        }

        //解法三：
        public bool IsPerfectSquare03(int num) {
            long r = num;
            while (r*r > num)
                r = (r + num/r) / 2;
            return r*r == num;
        }
    }
}