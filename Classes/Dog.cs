using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Shelter.Classes
{
    class Dog : Animal
    {
        public DateTime lastWalk;

        public Dog(string name, int chip, Gender gender)
        {
            this.name = name;
            this.chip = chip;
            this.gender = gender;
        }

        public void setLastWalk()
        {
            lastWalk = DateTime.Now;
        }
        public void setLastWalk(DateTime laatstUitgelaten)
        {
            lastWalk = laatstUitgelaten;
        }
    }
}
