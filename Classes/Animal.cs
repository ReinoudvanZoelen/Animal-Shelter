using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Shelter.Classes
{
    abstract class Animal
    {
        public enum Gender { male, female};

        public string name;
        public int chip;
        public Gender gender;
        public Reservor reservedBy { get; private set; }
        public DateTime reservedAt { get; private set; }

        public void reserve(Reservor reservedBy, DateTime reservedAt)
        {
            this.reservedBy = reservedBy;
            this.reservedAt = reservedAt;
        }
    }
}
