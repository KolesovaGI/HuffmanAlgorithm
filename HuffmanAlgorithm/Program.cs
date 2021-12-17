using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HuffmanAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку :");
            string input = Console.ReadLine();

            HuffmanTree huffmanTree = new HuffmanTree();
            huffmanTree.Build(input);                                                                   // Построение дерева Хаффмана
            BitArray encoded = huffmanTree.Encode(input);                                               // Кодирование введённой строки

            Console.Write("Кодирование: ");

            foreach (bool bit in encoded)
            {
                Console.Write((bit ? 1 : 0) + "");
            }
            Console.WriteLine();
            // رشته اصلی
            string decoded = huffmanTree.Decode(encoded);
            Console.WriteLine("Декодирование : " + "'" + decoded + "'" + ", Символов в строке :  " + decoded.Length);
            Console.WriteLine("\n\n");
        }
    }
}
