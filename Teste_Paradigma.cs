using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
        }
    }

    static TreeNode BuildTree(int[] array)
    {
        if (array == null || array.Length == 0)
            return null;

        int maxIndex = Array.IndexOf(array, array.Max());
        TreeNode root = new TreeNode(array[maxIndex]);

        root.Left = BuildTree(array.Take(maxIndex).ToArray());
        root.Right = BuildTree(array.Skip(maxIndex + 1).ToArray());

        return root;
    }

    static void PrintTree(TreeNode node, string indent = "", bool isLeft = true)
    {
        if (node == null) return;

        Console.WriteLine(indent + (isLeft ? "├── " : "└── ") + node.Value);
        PrintTree(node.Left, indent + (isLeft ? "│   " : "    "), true);
        PrintTree(node.Right, indent + (isLeft ? "│   " : "    "), false);
    }

    static void Main()
    {
        var input1 = new int[] { 3, 2, 1, 6, 0, 5 };
        var tree1 = BuildTree(input1);
        Console.WriteLine("Árvore do cenário 1:");
        PrintTree(tree1);

        Console.WriteLine();

        var input2 = new int[] { 7, 5, 13, 9, 1, 6, 4 };
        var tree2 = BuildTree(input2);
        Console.WriteLine("Árvore do cenário 2:");
        PrintTree(tree2);
    }
}