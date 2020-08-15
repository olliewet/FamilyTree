using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTreeC
{
    class Person
    {
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        protected bool Alive { get; set; }
        public List<Person> Children { get; set; } = new List<Person>();
        public Person()
        {
        }
        public Person(string name, string dob, bool isAlive)
        {
            this.Name = name;
            this.DateOfBirth = dob;
            this.Alive = isAlive;
        }
        public string isAlive()
        {
            string _IsAlive = "Person is Alive";
            string _isntAlive = "Person Sadly Passed Away";
            if (this.Alive == true)
            {
                return _IsAlive;
            }
            else
            {
                return _isntAlive;
            }
        }
        public override string ToString()
        {
            return String.Format("{0} was born on {1} and the {2}", this.Name, this.DateOfBirth, isAlive());
        }
    }
}
