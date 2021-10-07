using System;
using System.Collections;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList s1 = new ArrayList();
            s1.Add('R');
            s1.Add('A');
            s1.Add('C');
            s1.Add('E');
            ArrayList s2 = new ArrayList();
            s2.Add('C');
            s2.Add('A');
            s2.Add('R');
            s2.Add('E');

            Neww obj = new Neww();
            obj.Check(s1, s2);
            obj.display();
           

        }
    }
}
