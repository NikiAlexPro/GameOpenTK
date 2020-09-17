using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTKGame
{
    class Program
    {
        public static void Main()
        {
            using (Game game = new Game(800, 600, "My New Game"))
            {
                game.Run(60.0);
            }

            
        }

        
        
    }
}
