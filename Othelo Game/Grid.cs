using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othelo_Game
{
    class Grid
    {
        int n;
        Piece[,] board;
        int blackcount = 0;
        int whitecount = 0;

        public Grid(int N)
        {
            n = N;
            if (n < 6 || n % 2 == 1)
                throw new InvalidOperationException("The grid should have even number of rows/columns and can't be smaller than 6x6.");
            else
            {
                board = new Piece[n, n];
                blackcount = 2;
                whitecount = 2;
            }
        }
        public void initialize()
        {
            int mid = n / 2;
            board[mid - 1, mid - 1] = new Piece(Color.Black);
            board[mid - 1, mid] = new Piece(Color.White);
            board[mid, mid - 1] = new Piece(Color.White);
            board[mid, mid] = new Piece(Color.Black);
        }

        bool isValid(Color col, int i, int j) //check if placing a piece in (i,j) is valid
        {
            Color other = col == Color.White ? Color.Black : Color.White;
            if (i < n && j < n &&
                (board[i + 1, j].Color == other || board[i, j + 1].Color == other || board[i - 1, j].Color == other || board[i, j - 1].Color == other))
                return true;
        }
    }


}

