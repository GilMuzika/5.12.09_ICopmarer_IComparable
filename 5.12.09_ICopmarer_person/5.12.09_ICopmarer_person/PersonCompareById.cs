using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._12._09_ICopmarer_person
{
    class PersonCompareById :PersonCompare, IComparer<Person>
    {
        public override bool IsIcomparer { get => true; }

        public int Compare(Person x, Person y)
        {
            return x.Id - y.Id;
        }

        public override string ToString()
        {
            return "Id";
        }
    }
}
