using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._12._09_ICopmarer_person
{
    public class Person : IComparable<Person>
    {
        public int Id { get;  set; } = 0; //the setter meant to be private but needs to be public for serialization
        public int Age { get;  set; } //the setter meant to be private but needs to be public for serialization
        public float Height { get;  set; } //the setter meant to be private but needs to be public for serialization
        public string Name { get;  set; } //the setter meant to be private but needs to be public for serialization

        readonly static IComparer<Person> idComparer = default(IComparer<Person>);
        public static IComparer<Person> IdComparer { get => idComparer; }
        private readonly static IComparer<Person> ageComparer = default(IComparer<Person>);
        public static IComparer<Person> AgeComparer { get => ageComparer; }
        private readonly static IComparer<Person> heightComparer = default(IComparer<Person>);
        public static IComparer<Person> HeightComparer { get => heightComparer; }
        private readonly static IComparer<Person> nameComparer = default(IComparer<Person>);
        public static IComparer<Person> NameComparer { get => nameComparer; }

        private static IComparer<Person> DefaultComparer { get; set; }

        static public bool isDefaultComparerUsed = false;





        private Random _rnd = new Random();

        public Person(int age, float height, string name)
        {
            Age = age;
            Height = height;
            Name = name;
            Id = Statics.generateRandomNumberBetween(1, 10000);
        }
        public Person() { }


        static Person() 
        {
            idComparer = new PersonCompareById();
            ageComparer = new PersonCompareByAge();
            heightComparer = new PersonCompareByHeight();
            nameComparer = new PersonCompireByName();
            DefaultComparer = idComparer;
        }

        public override string ToString()
        {
            string str = string.Empty;
            PropertyInfo[] propInfoArr = this.GetType().GetProperties().Where(x => !x.Name.Contains("Comparer")).ToArray();
            foreach (var s in propInfoArr) str += s.Name + ": " +  s.GetValue(this) + Environment.NewLine;

            str += "---------------\n\n";
            return str;
        }

        private IComparer<Person> ModifyDefaultComparer(string modifier)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Type relevantType = asm.GetTypes().Where(x => x.Name.ToLower().Contains(modifier)).First();

            return Activator.CreateInstance(relevantType) as IComparer<Person>;
        }

        public int CompareTo(Person other)
        {


            //MessageBox.Show(Statics.defaultComparerModifier);
            if (isDefaultComparerUsed) DefaultComparer = ModifyDefaultComparer(Statics.defaultComparerModifier);
            

            return DefaultComparer.Compare(this, other);
        }
    }
}
