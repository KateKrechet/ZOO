using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Parrot:IAnimal
    {
        public string Name { get; private set; }
        public Parrot(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public string Fly(int time)
        {
            return $"{ Name} летал по вольеру в течение {time} минут";
        }
        public string Voice()
        {
            return $"Попугай {Name} повторяет за людьми";

        }
        public string Feed()
        {
            return $"Попугай {Name} поел семечек";
        }
    }
}
