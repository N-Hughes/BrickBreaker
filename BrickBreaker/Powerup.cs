using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreaker
{
    internal class Powerup
    {

        public int height = 25;
        public int width = 12;

        public int x;
        public int y;
        public int powerNumber;

        Random randGen = new Random();


        public Powerup(int x_, int y_, int powerNumber_)
        {
            x = x_;
            y = y_;


        }

        public void SpawnUp(int powerNumber_)
        {
            powerNumber = powerNumber_;
            powerNumber = randGen.Next(1, 5);

            if ()
            {

            }

        }

    }
}
