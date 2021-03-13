using System;
using System.Collections;

namespace HyperGenesis
{
    public class Critter
    {
        public string name
        {
            get;
            set;
        }
        public string type
        {
            get;
            set;
        }

        public Critter(string name = "Default Paul", string type = "Not a Pokemon")
        {
            this.name = name;
            this.type = type;
        }
    }
}