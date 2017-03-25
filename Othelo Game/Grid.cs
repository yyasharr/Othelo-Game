using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Othelo_Game
{
    class Grid
    {
        int n;
        Piece[,] board;
        int blackcount = 0;
        int whitecount = 0;
        Point[] Directions = { new Point(0, 1), new Point(0, -1), new Point(1, 0), new Point(-1, 0) };

        

        public Grid(int N)
        {
            n = N;
            board = new Piece[n, n];
            blackcount = 2;
            whitecount = 2;
        }
        public void initialize()
        {
            int mid = n / 2;
            board[mid - 1, mid - 1] = new Piece(Color.Black);
            board[mid - 1, mid] = new Piece(Color.White);
            board[mid, mid - 1] = new Piece(Color.White);
            board[mid, mid] = new Piece(Color.Black);
        }

        public bool isPlaceValid(int i, int j)
        {
            if (board[i, j] == null && i < n && j < n)
                return true;
            return false;
        }

        public bool doesItScore(int i, int j, Color c) //checking whether it can flip any piece, and if yes, flip them and update the scores!!
        {
            Color other = c == Color.White ? Color.Black : Color.White;
            bool isThereAnyFlip = false;
            for(int k=0; k<Directions.Length; k++)
            {
                int nexti = i + Directions[k].X;
                int nextj = j + Directions[k].Y;
                List<Point> toBeFlipped=new List<Point>();

                if (board[nexti,nextj].Color!=other) //if the next piece in this direction is not the other color, check another direction
                {
                    continue;
                }
                else    //if the next imidiate peice in this direction is the other color, move forward in this direction,
                {       // until you get to a piece of your own color (flip all) or get to the end of the board and do nothing.
                    
                    while(nexti<n && nextj<n && board[nexti,nextj].Color==other) //creating a list of subsequence pieces with other color
                    {
                        toBeFlipped.Add(new Point(nexti, nextj));
                        nexti = nexti + Directions[k].X;
                        nextj = nextj + Directions[k].Y;
                    }

                    if(nexti<n && nextj<n && board[nexti,nextj].Color==c) //if after the sequence of other color, you saw your own color (trapped other color's pieces), flip the created list
                    {
                        isThereAnyFlip = true;
                        flipList(toBeFlipped);
                    }
                }
            }
            return isThereAnyFlip;
        }

        void flipList(List<Point> toBeFlipped)
        {
            foreach(Point p in toBeFlipped)
            {
                Piece piece= board[p.X, p.Y];
                piece.flip();
                if(piece.Color==Color.White)
                {
                    whitecount--;
                    blackcount++;
                }
                else
                {
                    whitecount++;
                    blackcount--;
                }
                
            }
        }

        public bool isValidMove(int i, int j, Color c)
        {
            //check1: whether the cell is empty and inside the grid
            if (isPlaceValid(i, j) == false)
                return false;
            return true;
        }

        public int getScore(Color c)
        {
            if (c == Color.White)
                return whitecount;
            return blackcount;
        }
    }


}

