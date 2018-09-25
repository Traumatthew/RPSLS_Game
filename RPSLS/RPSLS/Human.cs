using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public override void GetChoiceGesture()
        {
            //Print the choices to the console
            //Use Console.ReadLine() to get user choice

            Console.WriteLine("Press 1 for Rock");
            Console.WriteLine("Press 2 for Paper");
            Console.WriteLine("Press 3 for Sissors");
            Console.WriteLine("Press 4 for Lizard");
            Console.WriteLine("Press 5 for Spock");
            gesture = int.Parse(Console.ReadLine());
        }

        public override void GetName()
        {
            Console.WriteLine("Enter name please.");
            name = Console.ReadLine();
        }

        public override void Score()
        {
            
        }

    }
}
