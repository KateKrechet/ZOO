using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Elephant:IAnimal
    {
        public string Name { get; private set; }
        public Elephant(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public string Voice()
        {
            return $"Слон {Name} говорит УУууУУ";

        }
        public string Feed()
        {
            return $"Слон {Name} поел травы";
        }
    }
}
