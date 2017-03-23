using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othelo_Game
{
    
    class Othelo
    {
        Grid grid;
        Player player1;
        Player player2;


        public Othelo(int n)
        {
            grid=new Grid(n);
            player1 = new Player(Color.Black);
            player2 = new Player(Color.White);
        }


    }
}
