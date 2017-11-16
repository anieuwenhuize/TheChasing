using System;

namespace TheChasing
{
    class Program
    {
        static void Main(string[] args)
        {
            // make jail
            Jail jail = new Jail();

            // make thief
            Thief jano = new Thief("Jano");

            // make cop
            Cop police = new Cop(jail);

            police.Catch(jano);

            // cop puts thief in jail
            Console.WriteLine(jail);

            Console.Read();
        }
    }
}
