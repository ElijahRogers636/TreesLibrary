namespace TreesLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BinaryTree<string> tree = GetTree();
            BinaryTreeNode<string>? node = tree.Root;
            while (node != null)
            {
                if (node.Left != null && node.Right != null)
                {
                    Console.WriteLine(node.Data);
                    node = Console.ReadKey(true).Key switch
                    {
                        ConsoleKey.Y => node.Left,
                        ConsoleKey.N => node.Right,
                        _ => node
                    };
                }
                else
                {
                    Console.WriteLine(node.Data);
                    node = null;
                }
            }

            BinaryTree<string> GetTree()
            {
                BinaryTree<string> tree = new();

                tree.Root = new BinaryTreeNode<string>()
                {
                    Data = "Do you have an experience in app development ? ",

                    Children =
                    [
                        new BinaryTreeNode<string>()
                        {
                            Data = "Have you worked as a developer for 5 + years ? ",

                            Children =
                            [
                                new() { Data = "Apply as a senior developer" },

                                new() { Data = "Apply as a middle developer" }
                            ]
                        },
                        new BinaryTreeNode<string>()
                        {
                            Data = "Have you completed a university?",
                            Children =
                            [
                                new() { Data = "Apply as a junior developer" },

                                new BinaryTreeNode<string>()
                                {
                                    Data = "Have you applied to MSSA?",

                                    Children =
                                    [
                                        new() { Data = "Await Approval" },

                                        new BinaryTreeNode<string>()
                                        {
                                            Data = "Do you qualify for MSSA?",

                                            Children =
                                            [
                                                new() { Data = "Apply for next MSSA cohort" },

                                                new() { Data = "Join the Military" }
                                            ]
                                        }
                                    ]
                                }
                            ]
                        }
                    ]
                };
                tree.Count = 11;

                return tree;
            }




            //Binary Tree
            BinaryTree<int> binaryTree = new() { Root = new() { Data = 12 } };

            //Root Children (12 Root)
            binaryTree.Root.Left = new() { Data = 90, Parent = binaryTree.Root };
            binaryTree.Root.Right = new() { Data = 32, Parent = binaryTree.Root };

            //Root Left Children (90)
            binaryTree.Root.Left.Left = new() { Data = -50, Parent = binaryTree.Root.Left };
            binaryTree.Root.Left.Right = new() { Data = 100, Parent = binaryTree.Root.Left };

            //Root Left Right Children (100)
            binaryTree.Root.Left.Right.Left = new() { Data = 46, Parent = binaryTree.Root.Left.Right };

            //Start Right side
            //Root Right Children (32)
            binaryTree.Root.Right.Right = new() { Data = 21, Parent = binaryTree.Root.Right };

            // Root Right Right Children (21)
            binaryTree.Root.Right.Right.Left = new() { Data = 68, Parent = binaryTree.Root.Right.Right };
            binaryTree.Root.Right.Right.Right = new() { Data = 12, Parent = binaryTree.Root.Right.Right };

            //Root Right Right Left Children (68)
            binaryTree.Root.Right.Right.Left.Left = new() { Data = 9, Parent = binaryTree.Root.Right.Right.Left };
            binaryTree.Root.Right.Right.Left.Right = new() { Data = 11, Parent = binaryTree.Root.Right.Right.Left };

            //Root Right Right Right Children (12)
            binaryTree.Root.Right.Right.Right.Right = new() { Data = -6, Parent = binaryTree.Root.Right.Right.Right };


            /*
            // Root Node
            Tree<int> tree = new() { Root = new() { Data = 100 } };

            // 2nd ROW START
            // Root Children
            tree.Root.Children =
                [
                    new() { Data = 50 , Parent = tree.Root},
                    new() { Data = 1 , Parent = tree.Root},
                    new() { Data = 150 , Parent = tree.Root}
                ];
            //Children of left most node of root children
            tree.Root.Children[0].Children =
                [
                    new() { Data = 12, Parent = tree.Root.Children[0]}
                ];
            //Children of 2nd from left node of root children
            tree.Root.Children[1].Children =
                [
                    new() { Data = 70, Parent = tree.Root.Children[1]},
                    new() { Data = 61, Parent = tree.Root.Children[1]}
                ];
            //Children of 3rd node from left of root children
            tree.Root.Children[2].Children =
                [
                    new() { Data = 30, Parent = tree.Root.Children[2]},
                    new() { Data = 5, Parent = tree.Root.Children[2]},
                    new() { Data = 11, Parent = tree.Root.Children[2]}
                ];

            //3rd ROW START
            //Children of left most node on the 3rd row (12)
            tree.Root.Children[0].Children[0].Children =
                [
                    new() { Data = 45, Parent = tree.Root.Children[0].Children[0]},
                    new() { Data = 21, Parent = tree.Root.Children[0].Children[0]}
                ];
            //No children for middle subtree

            //Children of right most node of second subtree on row 3 (30)
            tree.Root.Children[2].Children[0].Children =
                [
                    new() { Data = 96, Parent = tree.Root.Children[2].Children[0]},
                    new() { Data = 9, Parent = tree.Root.Children[2].Children[0]}
                ];

            //4th ROW START
            tree.Root.Children[0].Children[0].Children[1].Children =
               [
                   new() { Data = 6, Parent = tree.Root.Children[0].Children[0].Children[1]}
               ];
            */
        }
    }
}
