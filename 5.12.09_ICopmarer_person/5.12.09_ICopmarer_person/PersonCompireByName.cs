using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._12._09_ICopmarer_person
{
    class PersonCompireByName :PersonCompare, IComparer<Person>
    {
        public override bool IsIcomparer { get => true; }

        public int Compare(Person x, Person y)
        {
            if (ReferenceEquals(x.Name, y.Name)) return 0;
            else return compareCharsNumericReprsentation(x, y);

        }

        private int compareCharsNumericReprsentation(Person x, Person y)
        {
            for (int i = 0; i < x.Name.Length; i++)
            {
                for(int j = 0; j < y.Name.Length; j++ )
                {
                    if((int)x.Name[i] != (int)y.Name[j])
                    {
                        if ((int)x.Name[i] > (int)y.Name[j]) return 1;
                        if ((int)x.Name[i] < (int)y.Name[j]) return -1;
                    }

                }
            }

            return 0;

            

        }



        public override string ToString()
        {
            return "Name";
        }

    }
}
