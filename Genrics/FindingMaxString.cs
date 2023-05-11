using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genrics
{
    internal class FindingMaxString
    {
        public static void FindingMaxSt(string st1,string st2,string st3) {
            if (st1.CompareTo(st2) > 0 && st1.CompareTo(st3) > 0 ||
                st1.CompareTo(st2) >= 0 && st1.CompareTo(st3) > 0 ||
                st1.CompareTo(st2) > 0 && st1.CompareTo(st3) >= 0)
            {
                Console.WriteLine(st1);
            }
            if (st2.CompareTo(st1) > 0 && st2.CompareTo(st3) > 0 ||
                st2.CompareTo(st1) >= 0 && st2.CompareTo(st3) > 0 ||
                st2.CompareTo(st1) > 0 && st2.CompareTo(st3) >= 0)
            {
                Console.WriteLine(st2);
            }
            if (st3.CompareTo(st1) > 0 && st3.CompareTo(st2) > 0 ||
               st3.CompareTo(st1) >= 0 && st3.CompareTo(st2) > 0 ||
               st3.CompareTo(st1) > 0 && st3.CompareTo(st2) >= 0)
            {
                Console.WriteLine(st3);
            }

        }
    }
}
