using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.XPath;

namespace BrickBreaker
{
    public class Ball
    {
        public bool canMove;
        public int x, y, size, prevX, prevY;
        public Color colour;
        public int xSpeed, ySpeed;
        public static Random rand = new Random();
        public int startXSpeed, startYSpeed;


        public Ball(int _x, int _y, int _xSpeed, int _ySpeed, int _ballSize)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            size = _ballSize;
            startXSpeed = xSpeed;
            startYSpeed = ySpeed;



        }

        public void Move()
        {
            if (canMove == false) { return; }
            x += xSpeed;
            y += ySpeed;

            prevX = x;
            prevY = y;

        }

        public bool BlockCollision(Block b)
        {
            Rectangle blockRec = new Rectangle(b.x, b.y, b.width, b.height);
            Rectangle ballRec = new Rectangle(x, y, size, size);

            if (ballRec.IntersectsWith(blockRec))
            {
                if (x + (size / 2) <= b.x || x + (size / 2) >= b.x + b.width)
                {
                    xSpeed *= -1;
                    x = prevX;
                    y = prevY;
                }
                else
                {
                    ySpeed *= -1;
                    y = prevY;
                    x = prevX;

                }

            }

            return blockRec.IntersectsWith(ballRec);
        }

        public bool PaddleCollision(Paddle p)
        {
            Rectangle ballRec = new Rectangle(x, y, size, size);
            Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (ballRec.IntersectsWith(paddleRec))
            {
                if (p.x + (p.width / 2) >= x) // hits left
                {
                    xSpeed = -Math.Abs(xSpeed);
                    ySpeed *= -1;
                    y = p.y - size;
                }
                else if (p.x + (p.width / 2) <= x) //hits right
                {
                    xSpeed = Math.Abs(xSpeed);
                    ySpeed *= -1;
                    y = p.y - size;
                }
                BounceAngle();
            }

            return paddleRec.IntersectsWith(ballRec);
        }

        public void WallCollision(UserControl UC)
        {
            // Collision with left wall
            if (x <= 1)
            {
                xSpeed *= -1;
            }
            // Collision with right wall
            if (x >= (UC.Width - size))
            {
                xSpeed *= -1;
            }
            // Collision with top wall
            if (y <= 2)
            {
                ySpeed *= -1;
            }
        }

        public bool BottomCollision(UserControl UC)
        {
            Boolean didCollide = false;

            if (y >= UC.Height)
            {
                didCollide = true;
            }

            return didCollide;
        }

        public void BounceAngle()
        {
            int num = rand.Next(0, 3);
            switch (num)
            {
                case 0:
                    xSpeed = startXSpeed - 3;
                    break;
                case 1:
                    xSpeed = startXSpeed;
                    break;
                case 2:
                    xSpeed = startXSpeed + 3;
                    break;
            }
        }

    }
}
