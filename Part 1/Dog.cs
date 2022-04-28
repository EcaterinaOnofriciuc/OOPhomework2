using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPhomework2
{
    internal class Dog : Mammal
    {
        public string name;
        public Dog(string dogName)
        {
            name = dogName;
        }
        public override void Breathe()
        {
            Console.WriteLine("The dog breathes");
        }

        public override int GetPaws()
        {
            return 4;
        }

        public override bool HasTail()
        {
            return true;
        }

        public override bool HasWool()
        {
            return true;
        }

        public override void Walk()
        {
            Console.WriteLine("The dog walks");
        }

        public static void BarkToConsole(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("gav gav");
            }
        }
    }
}
