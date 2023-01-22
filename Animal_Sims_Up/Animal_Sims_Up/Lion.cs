using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Sims_Up
{
    internal class Lion : Animal
    {
        public Lion(string _name, int _age)
        {
            Name = _name;
            Age = _age;
        }
        public static int MaxAge = 16;

        public override void Drink()
        {
            throw new NotImplementedException();
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            throw new NotImplementedException();
        }

        public override void Speak()
        {
            throw new NotImplementedException();
        }

        public override void Logic()
        {
            throw new NotImplementedException();
        }
    }
}
