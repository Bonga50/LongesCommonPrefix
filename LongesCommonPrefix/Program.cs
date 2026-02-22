using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongesCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            longestCommon obj = new longestCommon();
            string[] words = { "cir", "car" };
            Console.WriteLine(obj.LongestCommonPrefix(words));

            Console.Read();
        }
    }
}
