using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othelo_Game
{
    enum Color { Black, White };
    class Piece
    {
        Color _color;
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public Piece(Color color)
        {
            _color=color;
        }

    }
}
