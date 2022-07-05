using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.Name= name;
            this.Age = age;
        }
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
    }
}
