using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPhomework2.Part_3
{
    internal class Worker2:User
    {
        private float _salary;
        public void SetSalary(float salary) { _salary = salary; }
        public float GetSalary() { return _salary; }
    }
}
