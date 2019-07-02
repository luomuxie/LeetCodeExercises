/* 
* @Author: XIEXIAN  
* @Date: 2019-06-28 16:29:28  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-07-01 18:08:17
*/
using System.Collections.Generic;
namespace LeetCodeExercises
{

  //Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }

 /*
    需求：返回树的先根遍历
  */
    public class BinaryTreePreorderTraversal
    {
        
        
        //解法一：递归280 ms	27.8 MB	很慢啊
        public IList<int> PreorderTraversal01(TreeNode root) {
            IList<int> res = new List<int>();
            if(root == null) return res;      
            TreePreOrder( res,root);
            return res;
        }

        private void TreePreOrder(IList<int> res,TreeNode node)
        {
            if(node == null) return;
            res.Add(node.val);  
            TreePreOrder(res, node.left);
            TreePreOrder( res,node.right);
                      
        }

        //解法二：while迭代 252 ms	28.2  只是比一快一丢丢
        public IList<int> PreorderTraversal02(TreeNode root) {
            IList<int> res = new List<int>();
            Stack<TreeNode> rights = new Stack<TreeNode>();
            while(root != null) {
                res.Add(root.val);
                if (root.right != null) {
                    rights.Push(root.right);
                }
                root = root.left;
                if (root == null && (rights.Count != 0)) {
                    root = rights.Pop();
                }
            }
            return res;        
        }

        //解法三：和解法二差不多，相对更加直观
        public IList<int> PreorderTraversal03(TreeNode root) {            
            IList<int> res = new List<int>();
            if(root == null) return res;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while(stack.Count != 0)
            {
                TreeNode node = stack.Pop();
                res.Add(node.val);
                if(node.right != null) stack.Push(node.right);
                if(node.left != null) stack.Push(node.left);                
            }
            return res;
        }
    }
}
