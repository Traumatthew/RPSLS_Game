using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
  
        public abstract class Player
        {
            public string name;
            public int gesture;
            public int score;

            public abstract void GetChoiceGesture();

            public abstract void GetName();

        public abstract void Score();

        }


    
}
