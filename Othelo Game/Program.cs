using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othelo_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //player1: black, player2: white, game starts with black.    
            //Sample test:

            Othelo myGame = Othelo.Instance;
            Console.WriteLine(myGame.Player1.placePiece(4, 2));
            Console.WriteLine(myGame.Player2.placePiece(2, 1));
            Console.WriteLine(myGame.Player1.placePiece(1, 2));
            Console.WriteLine(myGame.Player2.placePiece(4, 3));
            Console.WriteLine(myGame.Player1.placePiece(3, 4));
            Console.WriteLine(myGame.Player2.placePiece(4, 1));
            Console.WriteLine(myGame.Player1.placePiece(5, 2));
            myGame.Player2.Pass();
            Console.WriteLine(myGame.Player1.placePiece(4, 0));
            myGame.Player2.Pass();
            Console.WriteLine(myGame.Player1.placePiece(2, 0));
            myGame.Player2.Pass();
            Console.WriteLine(myGame.Player1.placePiece(1, 3));
            myGame.Player2.Pass();
            Console.WriteLine(myGame.Player1.placePiece(4, 4));

            //Add the below lines to check everytime whose turn is it and what is the current score:
            //Console.WriteLine(myGame.getTurn().Color);
            //onsole.WriteLine(myGame.getScore());
            
            Console.ReadKey();
        }
    }
}
