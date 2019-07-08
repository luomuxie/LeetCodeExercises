/* 
* @Author: XIEXIAN  
* @Date: 2019-07-02 11:34:30  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-07-02 22:13:14
*/
using System.Collections.Generic;
namespace LeetCodeExercises
{
    public class SameTree
    {
        /*
        需求：判断是否为相同的树
        */

        //解法一：来一遍先根遍历对比,慢 //108 ms, faster than 19.81% of C# online submissions for Same Tree.
        //使用while
        public bool IsSameTree01(TreeNode p, TreeNode q) {
            if (p == null || q == null) return (p == q);
            Stack<TreeNode> stackp = new Stack<TreeNode>();
            Stack<TreeNode> stackq = new Stack<TreeNode>();
            TreeNode curP = p;
            TreeNode curq = q;
            while( curP != null && curq != null)
            {     
                if(curP.val != curq.val) return false;          
                if((curq.right == null && curP.right != null)|| (curq.right != null && curP.right == null) ) return false;
                if(curP.right != null) stackp.Push(curP.right);
                if(curq.right != null) stackq.Push(curq.right);                                
                curP = curP.left;                                
                curq = curq.left;
                if(curP == null && stackp.Count != 0) curP = stackp.Pop();
                if(curq == null && stackq.Count != 0) curq = stackq.Pop();
                if((curP == null && curq != null)|| (curP != null && curq == null) ) return false;               
            }
            return true;
        }
        
        //解法二：
        //使用递归
         public bool IsSameTree02(TreeNode p, TreeNode q) {
            if (p == null || q == null) return p == q;
            return p.val == q.val && IsSameTree02(p.left, q.left) && IsSameTree02(p.right, q.right);
         }
    }
}