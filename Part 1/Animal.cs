using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPhomework2
{
    internal abstract class Animal
    {
        public abstract int GetPaws();
        public abstract bool HasTail();
        public abstract void Walk();
        public abstract void Breathe();
    }
}
