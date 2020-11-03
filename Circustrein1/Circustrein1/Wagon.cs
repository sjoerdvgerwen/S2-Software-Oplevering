using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Circustrein1
{
    public class Wagon
    {
        public List<Animal> AnimalList = new List<Animal>();
        public const int MaxCapacity = 10;

        public Wagon()
        {
            AnimalList = new List<Animal>();
            
        }

    }
}

//constant van maxcapacity maken.
// stapsgewijs werken, eerst het een dan het ander.