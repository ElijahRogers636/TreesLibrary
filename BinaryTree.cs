using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesLibrary
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T>? Root { get; set; }
        public int Count { get; set; }
        public enum TraversalEnum { PreOrder, InOrder, PostOrder }

        private void TraversePreOrder(BinaryTreeNode<T>? node, List<BinaryTreeNode<T>> result)
        {
            if (node == null)
            {
                return;
            }
            result.Add(node);
            TraversePreOrder(node.Left, result);
            TraversePreOrder(node.Right, result);
        }

        private void TraverseInOrder(BinaryTreeNode<T>? node, List<BinaryTreeNode<T>> result)
        {
            if (node == null)
            {
                return;
            }
            TraverseInOrder(node.Left, result);
            result.Add(node);
            TraverseInOrder(node.Right, result);
        }

        private void TraversePostOrder(BinaryTreeNode<T>? node, List<BinaryTreeNode<T>> result)
        {
            if (node == null)
            {
                return;
            }
            TraverseInOrder(node.Left, result);
            TraverseInOrder(node.Right, result);
            result.Add(node); 
        }
        
        public List<BinaryTreeNode<T>> Traverse(TraversalEnum mode)
        {
            List<BinaryTreeNode<T>> nodes = [];
            if (Root == null) { return nodes; }
            switch (mode)
            {
                case TraversalEnum.PreOrder:
                    TraversePreOrder(Root, nodes);
                    break;
                case TraversalEnum.InOrder:
                    TraverseInOrder(Root, nodes);
                    break;
                case TraversalEnum.PostOrder:
                    TraversePostOrder(Root, nodes);
                    break;
            }
            return nodes;
        }
       
    }
}
