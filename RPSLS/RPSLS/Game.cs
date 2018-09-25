using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables(HAS A)
        Player player1;
        Player player2;
        List<int> gestures = new List<int>();

        //constructor (SPAWNER)
        
        public void DeterminePlayers()
        {
            Console.WriteLine("How many players?");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if (userInput == "2")
            {
                player1 = new Human();
                player2 = new Human();
            }
        }
        public void GetChoiceGestures()
        {
            player1.GetChoiceGesture();
            player2.GetChoiceGesture();
        }
        public void CompareGestures()
        {
            //1 is Rock
            //2 is Paper
            //3 is Scissors
            //4 is Lizard
            //5 is Spock
            if (player1.gesture == 1 && player2.gesture == 1)
            {
                Console.WriteLine(player1.name + " Tie!");
            }
            else if (player1.gesture == 1 && player2.gesture == 2)
            {
                Console.WriteLine(player1.name + " Loses!");
            }
            else if (player1.gesture == 1 && player2.gesture == 3)
            {
                Console.WriteLine(player1.name + " Wins!");
                player1.score++;
            }
            else if (player1.gesture == 1 && player2.gesture == 4)
            {
                Console.WriteLine(player1.name + "Wins!");
                player1.score++;
            }
            else if (player1.gesture == 1 && player2.gesture == 5)
            {
                Console.WriteLine(player1.name + "Loses!");
            }
            else if (player1.gesture == 2 && player2.gesture == 1)
            {
                Console.WriteLine(player1.name + "Wins!");
                player1.score++;
            }
            else if (player1.gesture == 2 && player2.gesture == 2)
            {
                Console.WriteLine(player1.name + "Tie!");
            }
            else if (player1.gesture == 2 && player2.gesture == 3)
            {
                Console.WriteLine(player1.name + "Loses!");
            }
            else if (player1.gesture == 2 && player2.gesture == 4)
            {
                Console.WriteLine(player1.name + "Win!");
                player1.score++;
            }
            else if (player1.gesture == 2 && player2.gesture == 5)
            {
                Console.WriteLine(player1.name + "Win!");
                player1.score++;
            }
            else if (player1.gesture == 3 && player2.gesture == 1)
            {
                Console.WriteLine(player1.name + "Lose!");
            }
            else if (player1.gesture == 3 && player2.gesture == 2)
            {
                Console.WriteLine(player1.name + "Wins!");
                player1.score++;
            }
            else if (player1.gesture == 3 && player2.gesture == 3)
            {
                Console.WriteLine(player1.name + "Tie!");
            }
            else if (player1.gesture == 3 && player2.gesture == 4)
            {
                Console.WriteLine(player1.name + "Win!");
                player1.score++;
            }
            else if (player1.gesture == 3 && player2.gesture == 5)
            {
                Console.WriteLine(player1.name + "Lose!");
            }
            else if (player1.gesture == 4 && player2.gesture == 1)
            {
                Console.WriteLine(player1.name + "Lose!");
            }
            else if (player1.gesture == 4 && player2.gesture == 2)
            {
                Console.WriteLine(player1.name + "Wins!");
                player1.score++;
            }
            else if (player1.gesture == 4 && player2.gesture == 3)
            {
                Console.WriteLine(player1.name + "Lose!");
            }
            else if (player1.gesture == 4 && player2.gesture == 4)
            {
                Console.WriteLine(player1.name + "Tie!");
            }
            else if (player1.gesture == 4 && player2.gesture == 5)
            {
                Console.WriteLine(player1.name + "Wins!");
                player1.score++;
            }
            else if (player1.gesture == 5 && player2.gesture == 1)
            {
                Console.WriteLine(player1.name + "Wins!");
                player1.score++;
            }
            else if (player1.gesture == 5 && player2.gesture == 2)
            {
                Console.WriteLine(player1.name + "Lose!");
            }
            else if (player1.gesture == 5 && player2.gesture == 3)
            {
                Console.WriteLine(player1.name + "Wins!");
                player1.score++;
            }
            else if (player1.gesture == 5 && player2.gesture == 4)
            {
                Console.WriteLine(player1.name + "Lose!");
            }
            else if (player1.gesture == 5 && player2.gesture == 5)
            {
                Console.WriteLine(player1.name + "Tie!");
            }
        }
        public void Score()
        {
          
        }
        public void GetName()
        {
            player1.GetName();
            player2.GetName();
        }
        public void RunGame()
        {
            DeterminePlayers();
            GetName();
            while (CompareGestures().score <= 3; RunGame() ) ;
            GetChoiceGestures();
            CompareGestures();
        }
    }   
}
