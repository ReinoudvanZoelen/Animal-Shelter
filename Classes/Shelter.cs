using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Shelter.Classes
{
    class Shelter
    {
        public List<Animal> listAnimal { get; set; }

        public Shelter()
        {
            listAnimal = new List<Animal>();
        }
    }
}
