using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPhomework2
{
    internal class Dove : Bird
    {
        public Dove()
        {
            Console.WriteLine("kurlik");
        }
        public override void Breathe()
        {
            Console.WriteLine("The dove breathes");
        }

        public override void Fly()
        {
            Console.WriteLine("The dove flies");
        }

        public override int GetPaws()
        {
            return 2;
        }

        public override bool HasTail()
        {
            return true;
        }

        public override void Walk()
        {
            Console.WriteLine("The dove walks");
        }
    }
}
