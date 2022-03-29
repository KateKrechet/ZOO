using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Cat:IAnimal
    {
        public string Name { get; private set; }
        public Cat(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public string Voice()
        {
            return $"Кот {Name} говорит Мяу";

        }
        public string Feed()
        {
            return $"Кот {Name} поел свежей рыбы";
        }
    }
}
