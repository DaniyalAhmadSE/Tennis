using System;
using System.Drawing;
using System.Windows.Forms;
using Tennis.Models;

namespace Tennis
{
    public partial class PlayArea : Form
    {
        public PlayArea()
        {
            InitializeComponent();
            BallInitLocation = Ball_Tennis.Location;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        public int Points { get; set; } = 0;
        public bool LeftToRight { get; set; } = true;
        public bool Started { get; set; } = false;
        public Point BallInitLocation { get; set; }

        private void Timer_MovementUpdater_Tick(object sender, EventArgs e)
        {
            Ball_Tennis.MoveBall();
            CheckWallCollison();
            CheckPaddleCollision(Paddle_Player1);
            CheckPaddleCollision(Paddle_Player2);
        }

        private void CheckPaddleCollision(Paddle player)
        {
            if (Ball_Tennis.Bounds.IntersectsWith(player.Bounds))
            {
                switch (Ball_Tennis.Direction)
                {
                    case BallDirection.DOWN_LEFT:
                        Ball_Tennis.Direction = BallDirection.DOWN_RIGHT;
                        break;
                    case BallDirection.DOWN_RIGHT:
                        Ball_Tennis.Direction = BallDirection.DOWN_LEFT;
                        break;
                    case BallDirection.UP_LEFT:
                        Ball_Tennis.Direction = BallDirection.UP_RIGHT;
                        break;
                    case BallDirection.UP_RIGHT:
                        Ball_Tennis.Direction = BallDirection.UP_LEFT;
                        break;
                    default:
                        break;
                }
                Points++;
                Lbl_Collisions.Text = Points.ToString();
                LeftToRight = !LeftToRight;
            }
        }

        private void CheckWallCollison()
        {
            if (Ball_Tennis.Bounds.IntersectsWith(Pnl_TopWall.Bounds))
            {
                if (Ball_Tennis.Direction == BallDirection.UP_LEFT)
                    Ball_Tennis.Direction = BallDirection.DOWN_LEFT;
                else if (Ball_Tennis.Direction == BallDirection.UP_RIGHT)
                    Ball_Tennis.Direction = BallDirection.DOWN_RIGHT;

            }

            else if (Ball_Tennis.Bounds.IntersectsWith(Pnl_BottomWall.Bounds))
            {
                if (Ball_Tennis.Direction == BallDirection.DOWN_LEFT)
                    Ball_Tennis.Direction = BallDirection.UP_LEFT;
                else if (Ball_Tennis.Direction == BallDirection.DOWN_RIGHT)
                    Ball_Tennis.Direction = BallDirection.UP_RIGHT;

            }
            else if (Ball_Tennis.Bounds.IntersectsWith(Pnl_RightWall.Bounds))
            {
                StopGame();
                Lbl_Player1_Wins.Text = Paddle_Player1.PlayerName + " Wins";
                Lbl_Player1_Wins.Visible = true;
            }
            else if (Ball_Tennis.Bounds.IntersectsWith(Pnl_LeftWall.Bounds))
            {
                StopGame();
                Lbl_Player2_Wins.Text = Paddle_Player2.PlayerName + " Wins";
                Lbl_Player2_Wins.Visible = true;
            }
        }

        private void PlayArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                if (!Paddle_Player1.Bounds.IntersectsWith(Pnl_TopWall.Bounds))
                {
                    Point p = Paddle_Player1.Location;
                    p.Y -= Paddle_Player1.Speed;
                    Paddle_Player1.Location = p;
                }
            }
            else if (e.KeyCode == Keys.S)
            {
                if (!Paddle_Player1.Bounds.IntersectsWith(Pnl_BottomWall.Bounds))
                {
                    Point p = Paddle_Player1.Location;
                    p.Y += Paddle_Player1.Speed;
                    Paddle_Player1.Location = p;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (!Paddle_Player2.Bounds.IntersectsWith(Pnl_TopWall.Bounds))
                {
                    Point p = Paddle_Player2.Location;
                    p.Y -= Paddle_Player2.Speed;
                    Paddle_Player2.Location = p;

                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (!Paddle_Player2.Bounds.IntersectsWith(Pnl_BottomWall.Bounds))
                {
                    Point p = Paddle_Player2.Location;
                    p.Y += Paddle_Player2.Speed;
                    Paddle_Player2.Location = p;
                }
            }
        }

        private void StartGame()
        {
            Ball_Tennis.Speed = (Rdb_Easy.Checked) ? 2 : 4;
            Lbl_Player1_Wins.Visible = false;
            Lbl_Player2_Wins.Visible = false;
            Lbl_Difficulty.Visible = false;
            Rdb_Easy.Visible = false;
            Rdb_Hard.Visible = false;
            Btn_Start_Reset.Text = "Stop";
            this.ActiveControl = null;
            this.Activate();
            Started = true;
            Timer_MovementUpdater.Start();
        }

        private void StopGame()
        {
            Timer_MovementUpdater.Stop();
            Ball_Tennis.Location = BallInitLocation;
            Lbl_Difficulty.Visible = true;
            Rdb_Easy.Visible = true;
            Rdb_Hard.Visible = true;
            Btn_Start_Reset.Text = "Start";
            Points = 0;
            Lbl_Collisions.Text = "0";
            this.ActiveControl = Btn_Start_Reset;
            Started = false;
        }

        private void Btn_Start_Reset_Click(object sender, EventArgs e)
        {
            if (!Started)
                StartGame();
            else
                StopGame();
        }
    }
}
