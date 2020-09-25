namespace leetcode701
{
    /// <summary>
    /// 二叉搜索树
    /// </summary>
    public class BST
    {
        /// <summary>
        /// 701. 二叉搜索树中的插入操作
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            var newNode = new TreeNode { val = val };

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                var currentNode = root;
                TreeNode parentNode = null;

                while (currentNode != null)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.val < val ? currentNode.right : currentNode.left;
                }

                if (parentNode.val < val)
                {
                    // 若插入的元素值小于根节点值，则将元素插入到左子树中
                    parentNode.right = newNode;
                }
                else
                {
                    // 若插入的元素值不小于根节点值，则将元素插入到右子树中
                    parentNode.left = newNode;
                }
            }

            return root;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}