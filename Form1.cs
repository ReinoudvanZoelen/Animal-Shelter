using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animal_Shelter.Classes;

namespace Animal_Shelter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Shelter shelter = new Shelter();

            shelter.listAnimal.Add(new Cat("Minoes", 123231, Animal.Gender.male));
            shelter.listAnimal.Add(new Dog("Shelly", 234343, Animal.Gender.female));

            Reservor Willem = new Reservor("Willem");

            shelter.listAnimal[1].reserve(Willem, DateTime.Now);

            MessageBox.Show("Het dier " + shelter.listAnimal[1].name + " is gereserveerd door " + shelter.listAnimal[1].reservedBy.name + " en is gereserveerd op " + shelter.listAnimal[1].reservedAt.ToString());
        }
    }
}
