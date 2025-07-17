using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Paradigma.Objects
{
    public static class TreeBuilder
    {
        public static TreeNode? Build(int[] array)
        {
            if (array == null || array.Length == 0)
                return null;

            int maxIndex = Array.IndexOf(array, array.Max());
            var root = new TreeNode(array[maxIndex]);

            root.Left = Build(array.Take(maxIndex).ToArray());
            root.Right = Build(array.Skip(maxIndex + 1).ToArray());

            return root;
        }
    }
}
