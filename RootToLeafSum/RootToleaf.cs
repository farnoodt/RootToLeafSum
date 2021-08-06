using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootToLeafSum
{
    class RootToleaf
    {
        public bool SumRootToLeaf(Node root, int sum, List<int> result)
        {
            if (root == null)
                return false;
            if (root.left == null && root.right == null )
            {
                if (sum == root.data)
                {
                    result.Add(root.data);
                    return true;
                }
                else
                    return false;
            }
                
            if(SumRootToLeaf(root.left, sum - root.data, result))
            {
                result.Add(root.data);
                return true;
            }

            if (SumRootToLeaf(root.right, sum - root.data, result))
            {
                result.Add(root.data);
                return true;
            }

            return false;
        }
    }
}
