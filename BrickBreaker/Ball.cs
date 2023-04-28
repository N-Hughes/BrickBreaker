using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.XPath;

namespace BrickBreaker
{
    public class Ball
    {
        public bool canMove;
        public int x, y, size;
        public Color colour;
        public double xSpeed, ySpeed;
        public static Random rand = new Random();

        public Ball(int _x, int _y, double _xSpeed, double _ySpeed, int _ballSize)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            size = _ballSize;

        }

        public void Move()
        {
            if (canMove == false) { return; }
            x = x + Convert.ToInt32(xSpeed);
            y = y + Convert.ToInt32(ySpeed);
        }

        public bool BlockCollision(Block b)
        {
            Rectangle blockRec = new Rectangle(b.x, b.y, b.width, b.height);
            Rectangle ballRec = new Rectangle(x, y, size, size);

            if (ballRec.IntersectsWith(blockRec))
            {
                if (x + (size / 2) <= b.x || x + (size / 2)>= b.x + b.width)
                {
                    xSpeed *= -1;
                    if(xSpeed > 0)
                    {
                        b.x = b.x - size;
                    }
                    else if (xSpeed < 0)
                    {
                        b.x = b.x + size;
                    }
                }
                else
                {
                ySpeed *= -1;
                     if (ySpeed > 0)
                    {
                        b.y = b.y + size;
                    }
                    else if(ySpeed < 0)
                    {
                        b.y = b.y - size;
                    }
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
                    xSpeed = Math.Abs(xSpeed);
                    ySpeed *= -1;
                    y = p.y - size;
                }
                else if (p.x + (p.width / 2) <= x) //hits right
                {
                    xSpeed = -Math.Abs(xSpeed);
                    ySpeed *= -1;
                    y = p.y - size;
                }
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

    }
}
