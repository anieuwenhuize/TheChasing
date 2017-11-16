using System;
using System.Collections.Generic;
using System.Text;

namespace TheChasing
{
    class Jail
    {
        private Thief prisoner;

        public Jail()
        {

        }

        private bool IsOccupied()
        {
            return prisoner != null;
        }

        public void Imprison(Thief thief)
        {
            // zet de dief gevangen
            this.prisoner = thief;
        }

        public override string ToString()
        {
            if(IsOccupied())
            {
                return $"One thief imprisoned: {prisoner}";
            }
            return "Jail is empty. Do something about it!";
        }
    }
}
