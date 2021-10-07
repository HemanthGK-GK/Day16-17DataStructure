using System;
using System.Collections;
using System.Text;

namespace Anagram
{
    class Neww
    {
        bool flag = false;
        public void Check(ArrayList s1,ArrayList s2)
        {
            s1.Sort();
            s2.Sort();
          
            for(int i=0;i<s1.Count;i++)
            {
                if (s1[i] != s2[i])
                    flag = false;
                
            }
            flag = true;

        }
        public void display()
        {
            if (this.flag = false)
            {
                Console.WriteLine("Not Anagram");
            }
            else
                Console.WriteLine("Anagram string");

        }
    }
}
