using System.Drawing;
using System.Windows.Forms;

namespace Tennis.Models
{
    class Ball : PictureBox
    {
        public Ball()
        {
            this.Height = this.Width = 30;
        }

        public int Speed { get; set; } = 2;
        internal BallDirection Direction { get; set; } = BallDirection.UP_RIGHT;

        public void MoveBall()
        {
            if (Direction == BallDirection.UP_RIGHT)
            {
                Point p = this.Location;
                p.X += Speed;
                p.Y -= Speed;
                this.Location = p;
            }
            else if (Direction == BallDirection.UP_LEFT)
            {
                Point p = this.Location;
                p.X -= Speed;
                p.Y -= Speed;
                this.Location = p;


            }
            else if (Direction == BallDirection.DOWN_RIGHT)
            {
                Point p = this.Location;
                p.X += Speed;
                p.Y += Speed;
                this.Location = p;


            }
            else if (Direction == BallDirection.DOWN_LEFT)
            {
                Point p = this.Location;
                p.X -= Speed;
                p.Y += Speed;
                this.Location = p;
            }
        }
        public void Display(Graphics g)
        {
            g.FillEllipse(new SolidBrush(this.BackColor), new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height));
        }
    }
    public enum BallDirection { DOWN_LEFT, DOWN_RIGHT, UP_LEFT, UP_RIGHT }
}
