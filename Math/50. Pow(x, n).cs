namespace LeetCodeExercises
{
    using System;
    public class Pow
    {
        //实现幂运算
        public double MyPow01(double x, int n) {
            //return Math.Pow(x,n);//如果单纯这样写，会时间超时
            if(n==0) return 1;
            if(n<0){
                n = -n;
                x = 1/x;
            }
            return n%2==0 ? MyPow01(x*x, n/2) : x*MyPow01(x*x, n/2);

        }

        //使用二进制位运算
        //关于位运算相关知识：https://blog.csdn.net/xiaochunyong/article/details/7748713
        public double MyPow02(double x, int n) {
            /* 
            double result = x,tempResult=1;            
            while(n>=0)
            {
                int temp = n;
                while(temp >0)
                {
                    temp = temp>>1;               
                    tempResult = result;
                    result *=result;             
                }
                n-=temp<<1;
                result /= tempResult;
            }
            return result;
            */

            if (n == 0) return 1;
            if (x == 1) return 1;
            if (x == -1) {
                if (n % 2 == 0) return 1;
                else return -1;
            }
            if (n == int.MinValue) return 0;
            if (n < 0) {
                n = -n;
                x = 1/x;
            }
            double ret = 1.0;
            while (n > 0) {
                if ((n & 1) != 0) 
                    ret *= x;
                x = x * x;
                n = n >> 1;
            }
            return ret;
        }
    }
}