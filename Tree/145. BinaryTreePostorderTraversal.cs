/* 
* @Author: XIEXIAN  
* @Date: 2019-07-02 11:20:54  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-07-04 20:29:01
*/
using System.Collections.Generic;
namespace LeetCodeExercises
{
    public class BinaryTreePostorderTraversal
    {
        //解法一：递归
        public IList<int> PostorderTraversal01(TreeNode root) {
            IList<int> res = new List<int>();
            if (root == null) return res;
            Postorder(res,root);                        
            return res;
        }

        private void Postorder(IList<int> res,TreeNode node)
        {
            if(node == null) return;
            Postorder(res,node.left);            
            Postorder(res,node.right);
            res.Add(node.val);
        }

        //解法二：while迭代
        public IList<int> PostorderTraversal02(TreeNode root) {
            IList<int> res = new List<int>();
            if (root == null) return res;
            Stack<TreeNode> stack = new Stack<TreeNode>();            
            stack.Push(root);
            while(stack.Count != 0 )
            {
                TreeNode cur = stack.Pop();
                res.Insert(0,cur.val);
                if(cur.left != null) stack.Push(cur.left);
                if(cur.right != null) stack.Push(cur.right);                
            }
            return res;
        }
    }
}