using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othelo_Game
{
    class Player
    {
        Color _color;
        public Color Color
        {
            get { return _color; }
        }

        public Player(Color color)
        {
            _color = color;
        }

        bool placePiece(int i, int j)
        {
            return Othelo.Instance.placePiece(i, j, _color);
        }

        void Pass() //If the current player doesn't have any option to play, they can (must!) pass their turn.
        {
            Othelo.Instance.changeTurn();
        }
    }
}
