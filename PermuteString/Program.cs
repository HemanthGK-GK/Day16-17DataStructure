using System;

namespace PermuteString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string words=" ";
            Console.WriteLine("Enter the string : ");
            str = Console.ReadLine();
            Permutation ob = new Permutation();
            Console.WriteLine("All possible strings are : ");
            ob.permute(str, words);
        }
    }
}
