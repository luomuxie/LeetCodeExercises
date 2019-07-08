/* 
* @Author: XIEXIAN  
* @Date: 2019-07-01 17:08:13  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-07-02 12:13:30
*/
using System.Collections.Generic;
namespace LeetCodeExercises
{
    /*
        需求：返回树的中根遍历
    */
    public class BinaryTreeInorderTraversal
    {
        
        //解法一：迭代
        public IList<int> InorderTraversal01(TreeNode root) {
            IList<int> res = new List<int>();
            if (root == null) return res;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode cur = root;
            while(cur!=null || stack.Count != 0){
                while(cur!=null){
                    stack.Push(cur);
                    cur = cur.left;
                }
                cur = stack.Pop();
                res.Add(cur.val);
                cur = cur.right;
            }
            return res;

        }

        //解法二：递归
        public IList<int> InorderTraversal02(TreeNode root) {
            IList<int> res = new List<int>();
            if (root == null) return res;
            TreeInorder(res,root);            
            return res;
        }

        private void TreeInorder(IList<int> res,TreeNode node)
        {
            if(node == null) return;
            TreeInorder(res,node.left);
            res.Add(node.val);
            TreeInorder(res,node.right);
        }
    }
}