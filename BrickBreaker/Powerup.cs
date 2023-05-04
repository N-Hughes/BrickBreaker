using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreaker
{
    internal class Powerup
    {

        public int height = 25;
        public int width = 12;
        public int speed = 3;

        public int x;
        public int y;

        Random randGen = new Random();

        public Powerup(int x_, int y_)
        {
            x = x_;
            y = y_;

        }

        public void Move(int y_, int height_)
        {
            height = height_;
            y += speed;

            if (y > height - 12)
            {
                speed *= +1;
            }
        }

        public void PowerupCollision(Paddle p)
        {
            Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);
            Rectangle powerRec = new Rectangle(x, y, 12, 25);

            if (powerRec.IntersectsWith(paddleRec))
            {
                

            }
        }

    }
}
