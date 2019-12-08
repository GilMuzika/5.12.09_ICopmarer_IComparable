using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._12._09_ICopmarer_person
{
    class ComboItem
    {
        public Person Item { get; set; } = null;

        public ComboItem(Person item)
        {
            Item = item;
        }

        public override string ToString()
        {
            return this.Item.Name;
        }
    }
}
