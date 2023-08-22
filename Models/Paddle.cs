using System.Drawing;
using System.Windows.Forms;

namespace Tennis.Models
{
    class Paddle : PictureBox
    {
        public Paddle()
        {
            this.Height = 100;
            this.Width = 10;
        }

        public string PlayerName { get; set; } = "Player";
        public int Speed { get; set; } = 10;

        public void Display(Graphics g)
        {
            g.FillRectangle(new SolidBrush(this.BackColor), new Rectangle(Location.X, Location.Y, this.Width, this.Height));
        }
    }
}
