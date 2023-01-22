using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Sims_Up
{
    class Monkey : Animal
    {
        public Monkey(string _name, int _age)
        {
            Name = _name;
            Age = _age;
        }
        public static int MaxAge = 40;

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
