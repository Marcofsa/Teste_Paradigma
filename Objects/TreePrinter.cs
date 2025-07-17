using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Paradigma.Objects
{
    public static class TreePrinter
    {
        public static void Print(TreeNode? node, string indent = "", bool isLeft = true)
        {
            if (node == null) return;

            Console.WriteLine(indent + (isLeft ? "├── " : "└── ") + node.Value);
            Print(node.Left, indent + (isLeft ? "│   " : "    "), true);
            Print(node.Right, indent + (isLeft ? "│   " : "    "), false);
        }
    }
}
