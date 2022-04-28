using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPhomework2.Part_3
{
    internal class User
    {
        protected string _name;
        protected int _age;
        public void SetName(string name) { _name = name; }
        public string GetName() { return _name; }
        public void SetAge(int age) { _age = age; }

        public int GetAge() { return _age; }
    }
}
