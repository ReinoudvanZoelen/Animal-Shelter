using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Shelter.Classes
{
    class Cat : Animal
    {
        string behavior { get; set; }

        public Cat(string name, int chip, Gender gender)
        {
            this.name = name;
            this.chip = chip;
            this.gender = gender;
        }

    }
}
