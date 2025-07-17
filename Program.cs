using Teste_Paradigma.Objects;

namespace Teste_Paradigma
{
    internal class Program
    {
        static void Main()
        {
            var input1 = new int[] { 3, 2, 1, 6, 0, 5 };
            var input2 = new int[] { 7, 5, 13, 9, 1, 6, 4 };

            Console.WriteLine("Árvore do cenário 1:");
            var tree1 = TreeBuilder.Build(input1);
            TreePrinter.Print(tree1);

            Console.WriteLine();

            Console.WriteLine("Árvore do cenário 2:");
            var tree2 = TreeBuilder.Build(input2);
            TreePrinter.Print(tree2);
        }
    }
}
