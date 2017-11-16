using System;
using System.Collections.Generic;
using System.Text;

namespace TheChasing
{
    class Thief
    {
        private string name;

        public Thief( string name )
        {
            // wijs de naam toe aan het veld
            this.name = name;
        }

        public override string ToString()
        {
            return $"Yo, call me {name}. No betraying, ok?";
        }
    }
}
