using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othelo_Game
{
    
    class Piece
    {
        Color _color;

        public Color Color
        {
            get { return _color; }
        }

        public Piece(Color color)
        {
            _color=color;
        }

        public void flip()
        {
            if (_color == Color.White)
                _color = Color.Black;
            else
            {
                _color = Color.White;
            }
        }

    }
}
