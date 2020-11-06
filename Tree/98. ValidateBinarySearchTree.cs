using System;
namespace LeetCodeExercises{
    public class ValidateBinarySearchTree{
        public bool IsValidBST01(TreeNode root) {
            if(root == null) return true;            
            return  IsValidBST01Help(root,int.MinValue);
        }
        public bool IsValidBST01Help(TreeNode root,int preVal) {
            if(root == null) return true;
            if(root.left != null){
                Console.WriteLine("left.val:{0},preVal:{1}",root.left.val,preVal);
                if(root.left.val>=root.val ||　root.left.val <= preVal) return false;                
            }
            if(root.right != null){
                if(root.right.val<=root.val) return false;              
            }
            return IsValidBST01Help(root.left,root.val) && IsValidBST01Help(root.right,root.val);
        }
    }
}