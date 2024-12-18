using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesLibrary
{
    public class BinarySearchTree<T> : BinaryTree<T> 
        where T : IComparable
    {
        public bool Contains(T data)
        {
            BinaryTreeNode<T>? root = Root;
            while (root != null)
            {
                int result = data.CompareTo(root.Data);
                if (result == 0) { return true; }
                else if (result < 0) { root = root.Left; }
                else { root = root.Right;  }
            }
            return false;
        }
    }
}
