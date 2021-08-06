using System;
using System.Collections.Generic;

namespace RootToLeafSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Node tree = new Node(10);
            tree.left = new Node(12);
            tree.left.right = new Node(8);
            tree.left.left = new Node(14);

            RootToleaf RTL = new RootToleaf();
            List<int> res = new List<int>();
            Console.WriteLine(RTL.SumRootToLeaf(tree, 30, res));
            Console.WriteLine(string.Join(", ", res));
            Console.ReadLine();
        }
    }
}
