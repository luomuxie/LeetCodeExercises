using System.Collections.Generic;
using System;
namespace LeetCodeExercises{
    public class MaximumDepthofBinaryTree{
        //解法一：使用栈bfs
        public int MaxDepth01(TreeNode root) {
            if(root == null) return 0;
            Stack<DeepVO> stack = new Stack<DeepVO>();
            int deep = 1;
            stack.Push(new DeepVO(1,root));           
            while(stack.Count >0){
                DeepVO vo = stack.Pop();                          
                if(vo.node.left == null && vo.node.right == null)
                {                   
                    deep = Math.Max(vo.deep,deep);
                }else{
                    if(vo.node.left != null){
                        stack.Push(new DeepVO(vo.deep+1,vo.node.left)); //要注意n++和n+1的陷阱                                      
                    }
                    if(vo.node.right != null){
                       stack.Push(new DeepVO(vo.deep+1,vo.node.right));                       
                    }                                   
                }
            }
            return deep;        
        }

        //解法二：使用递归求解
        public int MaxDepth02(TreeNode root) {
            if (root == null)	return 0;
            if (root.left == null)	return MaxDepth02(root.right) + 1;
            if (root.right == null) return MaxDepth02(root.left) + 1;
            return Math.Max(MaxDepth02(root.left),MaxDepth02(root.right)) + 1;
        }
    }
}