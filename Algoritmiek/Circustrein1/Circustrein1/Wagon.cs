using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Circustrein1
{
    public class Wagon
    {
        public List<Animal> AnimalList { get; set; }
        public int MaxCapacity { get; set; }

        public Wagon()
        {
            AnimalList = new List<Animal>();
            MaxCapacity = 10;
        }

        public List<Animal> GetAnimals()
        {
            return new List<Animal>(AnimalList);
        }
        


    }
}


//constant van maxcapacity maken.
// stapsgewijs werken, eerst het een dan het ander.