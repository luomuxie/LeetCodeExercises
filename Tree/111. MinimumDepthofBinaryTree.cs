using System.Collections.Generic;
using System;
namespace LeetCodeExercises{
    public class MinimumDepthofBinaryTree
    {
        //求二叉树的最小深度，dfs
        public int MinDepth01(TreeNode root) {            
            if(root == null) return 0;
            Stack<DeepVO> stack = new Stack<DeepVO>();
            int deep = 9999;
            stack.Push(new DeepVO(1,root));           
            while(stack.Count >0){
                DeepVO vo = stack.Pop();                          
                if(vo.node.left == null && vo.node.right == null)
                {                   
                    deep = Math.Min(vo.deep,deep);
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

        //解法二： 递归求解   
        public int MinDepth02(TreeNode root) {
            if (root == null)	return 0;
            if (root.left == null)	return MinDepth02(root.right) + 1;
            if (root.right == null) return MinDepth02(root.left) + 1;
            return Math.Min(MinDepth02(root.left),MinDepth02(root.right)) + 1;
        } 

        //解法三：队列dfs求解
        public int MinDepth03(TreeNode root) {
            if(root == null) return 0;
            Queue<DeepVO> que = new Queue<DeepVO>();
            que.Enqueue(new DeepVO(1,root));
            while(que.Count >0)
            {
                DeepVO vo = que.Dequeue();                          
                if(vo.node.left == null && vo.node.right == null)
                {                   
                   return vo.deep;
                }else{
                    if(vo.node.left != null){
                        que.Enqueue(new DeepVO(vo.deep+1,vo.node.left)); //要注意n++和n+1的陷阱                                      
                    }
                    if(vo.node.right != null){
                       que.Enqueue(new DeepVO(vo.deep+1,vo.node.right));                       
                    }                                   
                }
            }
            return 0;
        }
        /*

        def minDepth(self, root):
            if root == None:
                return 0
            queue, level = deque([(root, 1)]), 0
            while queue:
                node, level = queue.popleft()
                if not node.left and not node.right:
                    return level
                if node.left:
                    queue.append((node.left, level + 1))
                if node.right:
                    queue.append((node.right, level + 1))

        */

    }
    public class DeepVO{
        public int deep;
        public TreeNode node;
        public DeepVO(int deep,TreeNode node)
        {
            this.deep = deep;
            this.node = node;
        }

    }
}
