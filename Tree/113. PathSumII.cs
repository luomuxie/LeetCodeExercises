using System.Collections.Generic;
using System;
namespace LeetCodeExercises
{
    /*求二叉树下，和为sum的所有路径 
    Given the below binary tree and sum = 22,
       5
      / \
     4   8
    /   / \
   11  13  4
  /  \    / \
 7    2  5   1

    [
        [5,4,11,2],
        [5,8,4,5]
    ]
     */
    public class PathSumII
    {

        //解法一：DFS 深度优先搜索算法
        public IList<IList<int>> PathSum01(TreeNode root, int sum) {
            List<IList<int>> res = new List<IList<int>>();
            IList<int> cur = new List<int>();            
            if(root == null) return res;
            pathSum(root,sum,cur,res);              
            return res;                               
        }
        public void pathSum(TreeNode root, int sum, IList<int>cur, IList<IList<int>>res){
            if (root == null){
                return; 
            }
            cur.Add(root.val);
            if (root.left == null && root.right == null && root.val == sum){                    
                res.Add(new List<int>(cur));//note:这里，如果直接用res.Add(cur),传入的只是一个引用，以后面的回溯操作中会更改，所以要new一个出来           
            }              
            pathSum(root.left, sum - root.val, cur, res);
            pathSum(root.right, sum - root.val, cur, res);
            cur.RemoveAt(cur.Count-1);//回溯
        }

        //解法二：BFS 广度优先
        //这个解法好像不太对，下次看到重新修正下吧
        public IList<IList<int>> PathSum02(TreeNode root, int sum) {

            List<IList<int>> res = new List<IList<int>>();
            IList<int> cur = new List<int>();            
            if(root == null) return res;
            Queue<pathVo> que = new Queue<pathVo>();
            que.Enqueue(new pathVo(root,sum,new List<int>(root.val)));
            while(que.Count>0)
            {
                pathVo vo = que.Dequeue();
                if(vo.root.left == null && vo.root.right == null&& vo.val == sum)
                {
                    res.Add(vo.path);
                }else{
                    if(vo.root.left != null)
                    {
                        vo.path.Add(vo.val);
                        que.Enqueue(new pathVo(vo.root.left,vo.val+vo.root.left.val,new List<int>(vo.path)));
                    }
                    if(vo.root.right != null)
                    {
                        vo.path.Add(vo.val);
                        que.Enqueue(new pathVo(vo.root.right,vo.val+vo.root.right.val,new List<int>(vo.path)));
                    }
                }
            }                                     
            return res;                               
        }
    }

    public class pathVo{
        public TreeNode root;
        public int val;
        public List<int> path;
        public pathVo(TreeNode root,int val,List<int> path)
        {
            this.root = root;
            this.val = val;
            this.path = path;
        }
    }
}