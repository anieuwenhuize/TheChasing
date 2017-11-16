using System;
using System.Collections.Generic;
using System.Text;

namespace TheChasing
{
    class Cop
    {
        private Jail Jail;

        public Cop(Jail jail)
        {
            Jail = jail;
        }

        public void Catch(Thief thief)
        {
            this.Jail.Imprison(thief);
        }
    }
}
