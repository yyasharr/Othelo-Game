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


            

            Othelo myGame = Othelo.Instance;
            Console.WriteLine(myGame.Player1.placePiece(4, 2));
            Console.WriteLine(myGame.Player2.placePiece(2, 1));
            Console.WriteLine(myGame.Player1.placePiece(1, 2));
            Console.WriteLine(myGame.Player2.placePiece(4, 3));
            Console.WriteLine(myGame.Player1.placePiece(3, 4));
            Console.WriteLine(myGame.Player2.placePiece(4, 1)); //This line returns false, however it's a valid move by white player






            Console.WriteLine(myGame.getTurn().Color);
            Console.WriteLine(myGame.getScore());
            
            Console.ReadKey();

        }
    }
}
