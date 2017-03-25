using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othelo_Game
{
    enum Color { Black, White };
    class Othelo
    { //Singleton

        private static Othelo _instance;
        readonly int n = 10; //row and column are always 10
        Grid grid;
        Player player1;
        Player player2;
        Color turn;

        public static Othelo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Othelo();
                }
                return _instance;
            }
        }

        protected Othelo() //or private
        {
            grid = new Grid(n);
            player1 = new Player(Color.Black);
            player2 = new Player(Color.White);
            turn = Color.Black;
        }

        public string getScore()
        {
            return "White: " + grid.getScore(Color.White) + "\nBlack: " + grid.getScore(Color.Black);
        }

        public void changeTurn()
        {
            turn = turn == Color.White ? Color.Black : Color.White;
        }

        public int getScore(Color c)
        {
            return grid.getScore(c);
        }

        public bool placePiece(int i, int j, Color c)
        {
            //Check1: Is it this user's turn?
            if (c != turn)
            {
                Console.WriteLine("This is not" + c.ToString() + "'s turn");
                return false;
            }

            //check2: Is it a valid move? It should be empty, inside the grid, and should flip at least one piece.
            bool checker = grid.isValidMove(i, j, c);

            if (checker == true)
            {
                int whitecount = grid.getScore(Color.White);
                int blackcount = grid.getScore(Color.Black);
                Color winner;
                if (whitecount+blackcount==n*n)
                {
                    winner = whitecount > blackcount ? Color.White : Color.Black;
                    Console.WriteLine("The match is over! " + winner.ToString() + " Won the game");
                    Console.WriteLine("White: " + whitecount);
                    Console.WriteLine("Black: " + blackcount);
                }
                changeTurn();
            }

            return checker;
        }

    }
}
