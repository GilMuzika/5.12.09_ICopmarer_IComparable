using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._12._09_ICopmarer_person
{
    class PersonCompareByHeight :PersonCompare, IComparer<Person>
    {
        public override bool IsIcomparer { get => true; }

        public int Compare(Person x, Person y)
        {
            if (x.Height == y.Height) return 0;
            if (x.Height > y.Height) return 1;

            return -1;
        }

        public override string ToString()
        {
            return "Height";
        }
    }
}
