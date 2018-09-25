using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        public override void GetChoiceGesture()
        {
            Random random = new Random();
            gesture = random.Next(1, 5);
        }
        public override void GetName()
        {
            name = "Computer";
        }

        public override void Score()
        {
            
        }
    }
}
