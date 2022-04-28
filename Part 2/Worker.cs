using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPhomework2.Part_2
{
    internal class Worker
    {
        private string _name;
        private float _salary;
        private int _age;
        public Worker(string name, float salary, int age)
        {
            _name = name;
            _salary = salary;
            _age = age;

        }
        public string GetName() { return _name; }
        public float GetSalary() { return _salary; }
        public int GetAge() { return _age; }

    }
}
