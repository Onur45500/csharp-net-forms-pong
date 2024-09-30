using Microsoft.VisualBasic.Devices;
using System.Numerics;

namespace csharp_net_forms_pong
{
    public partial class Form1 : Form
    {
        int BallXspeed = 4;
        int BallYspeed = 4;
        int speed = 2;
        Random rand = new Random();
        bool goDown, goUp;
        int Computer_speed_change = 50;
        int PlayerScore = 0;
        int ComputerScore = 0;
        int PlayerSpeed = 8;
        int[] i = { 5, 6, 8, 9 };
        int[] j = { 10, 9, 8, 11, 12 };

        public Form1()
        {
            InitializeComponent();

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            Ball.Top -= BallYspeed;
            Ball.Left -= BallXspeed;
            this.Text = "Player Score: " + PlayerScore + " -- Computer Score: " + ComputerScore;
            if (Ball.Top < 0 || Ball.Bottom > this.ClientSize.Height)
            {
                BallYspeed = -BallYspeed;
            }
            if (Ball.Left < -2)
            {
                Ball.Left = 300;
                BallXspeed = -BallXspeed;
                ComputerScore++;
            }
            if (Ball.Right > this.ClientSize.Width + 2)
            {
                Ball.Left = 300;
                BallXspeed = -BallXspeed;
                PlayerScore++;
            }
            if (Computer.Top <= 1)
            {
                Computer.Top = 0;
            }
            else if (Computer.Bottom >= this.ClientSize.Height)
            {
                Computer.Top = this.ClientSize.Height - Computer.Height;
            }
            if (Ball.Top < Computer.Top + (Computer.Height / 2) && Ball.Left > 300)
            {
                Computer.Top -= speed;
            }
            if (Ball.Top > Computer.Top + (Computer.Height / 2) && Ball.Left > 300)
            {
                Computer.Top += speed;
            }
            Computer_speed_change -= 1;
            if (Computer_speed_change < 0)
            {
                speed = i[rand.Next(i.Length)];
                Computer_speed_change = 50;
            }
            if (goDown && Player.Top + Player.Height < this.ClientSize.Height)
            {
                Player.Top += PlayerSpeed;
            }
            if (goUp && Player.Top > 0)
            {
                Player.Top -= PlayerSpeed;
            }
            CheckCollision(Ball, Player, Player.Right + 5);
            CheckCollision(Ball, Computer, Computer.Left - 35);
            if (ComputerScore > 5)
            {
                GameOver("Sorry you lost the game");
            }
            else if (PlayerScore > 5)
            {
                GameOver("You Won this game");
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }

        private void CheckCollision(PictureBox PicOne, PictureBox PicTwo, int offset)
        {
            if (PicOne.Bounds.IntersectsWith(PicTwo.Bounds))
            {
                PicOne.Left = offset;
                int x = j[rand.Next(j.Length)];
                int y = j[rand.Next(j.Length)];
                if (BallXspeed < 0)
                {
                    BallXspeed = x;
                }
                else
                {
                    BallXspeed = -x;
                }
                if (BallYspeed < 0)
                {
                    BallYspeed = -y;
                }
                else
                {
                    BallYspeed = y;
                }
            }
        }

        private void GameOver(string message)
        {
            GameTimer.Stop();
            MessageBox.Show(message, "Moo Says: ");
            ComputerScore = 0;
            PlayerScore = 0;
            BallXspeed = BallYspeed = 4;
            Computer_speed_change = 50;
            GameTimer.Start();
        }

        private void Computer_Click(object sender, EventArgs e)
        {

        }

        private void Ball_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
