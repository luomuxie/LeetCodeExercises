namespace LeetCodeExercises{
    public class RecoverBinarySearchTree{
        private TreeNode prevElement;
        private TreeNode firstElement;
        private TreeNode secondElement;
        public void recoverTree(TreeNode root) {             
            TreeNode node = root;            
        }

        private void traverse(TreeNode root) {
        
            if (root == null)
                return;
                
            traverse(root.left);                
            if (firstElement == null && prevElement.val > root.val) {
                firstElement = prevElement;
            }
            
            if (firstElement != null && prevElement.val > root.val) {
                secondElement = root;
            }        
            prevElement = root;
            
            traverse(root.right);
        }

		public void recoverTree02(TreeNode root) {
			TreeNode pre = null;
			TreeNode first = null, second = null;
			// Morris Traversal
			TreeNode temp = null;
			while(root!=null){
				if(root.left!=null){
					// connect threading for root
					temp = root.left;
					while(temp.right!=null && temp.right != root)
						temp = temp.right;
					// the threading already exists
					if(temp.right!=null){
						if(pre!=null && pre.val > root.val){
							if(first==null){first = pre;second = root;}
							else{second = root;}
						}
						pre = root;
						
						temp.right = null;
						root = root.right;
					}else{
						// construct the threading
						temp.right = root;
						root = root.left;
					}
				}else{
					if(pre!=null && pre.val > root.val){
						if(first==null){first = pre;second = root;}
						else{second = root;}
					}
					pre = root;
					root = root.right;
				}
			}
			// swap two node values;
			if(first!= null && second != null){
				int t = first.val;
				first.val = second.val;
				second.val = t;
			}
		}
    }

    
    
}

