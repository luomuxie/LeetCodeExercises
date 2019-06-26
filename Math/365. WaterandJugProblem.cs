/* 
* @Author: XIEXIAN  
* @Date: 2019-06-25 16:17:26  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-26 15:48:59
*/
namespace LeetCodeExercises
{
    public class WaterandJugProblem
    {
        //这题，求给出x,y的量杯，是能否能量出Z的体积的水=》//ax + by = Z  
        public bool CanMeasureWater01(int x, int y, int z) {
            //ax + by = Z          
            if(x + y < z) return false;            
            if( x == z || y == z || x + y == z ) return true;                        
            return z%GCD(x, y) == 0;        
        }
        public int GCD(int a, int b){
            while(b != 0 ){
                int temp = b;
                b = a%b;
                a = temp;
            }
            return a;
        }
    }
}