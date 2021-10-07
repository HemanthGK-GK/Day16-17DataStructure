using System;
using System.Collections.Generic;
using System.Text;

namespace PermuteString
{
    class Permutation
    {
        public void permute(string str,string words)
        {
            if (str.Length == 0)
            {
                Console.Write(words + "  ");
                return;
            }
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                String left_str = str.Substring(0, i);
                String right_str = str.Substring(i + 1);
                String rest = left_str + right_str;
                permute(rest, words + ch);
            }
        }
    }
}
