namespace csharp_net_forms_pong
{
    public partial class Form1 : Form
    {
        int ballXSpeed = 4;
        int ballYSpeed = 4;
        int speed = 2;
        Random rand = new Random();
        bool goDown, goUp;
        int computerSpeedChange = 50;
        int playerScore = 0;
        int computerScore = 0;
        int playerSpeed = 8;
        int[] i = { 5, 6, 7, 8, 9 };
        int[] l = { 9, 10, 11, 12, 13 };

        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            Ball.Top -= ballYSpeed;
            Ball.Left -= ballXSpeed;

            this.Text = "Player score: " + playerScore + " -- Computer Score: " + computerScore;

            if(Ball.Top < 0 || Ball.Bottom > this.ClientSize.Height)
            {
                ballYSpeed = -ballYSpeed;
            }
            if(Ball.Left < -2)
            {
                Ball.Left = 300;
                ballXSpeed = -ballXSpeed;
                computerScore++;
            }
            if(Ball.Right > this.ClientSize.Width + 2)
            {
                Ball.Left = 300;
                ballXSpeed = -ballXSpeed;
                playerScore++;
            }
            if(Computer.Top <= 1)
            {
                Computer.Top = 0;
            }
            else if(Computer.Bottom >= this.ClientSize.Height)
            {
                Computer.Top = this.ClientSize.Height - Computer.Height;
            }
            if(Ball.Top < Computer.Top + (Computer.Height/2) && Ball.Left > 300)
            {
                Computer.Top -= speed;
            }
            if (Ball.Top > Computer.Top + (Computer.Height / 2) && Ball.Left > 300)
            {
                Computer.Top += speed;
            }

            computerSpeedChange -= 1;

            if(computerSpeedChange < 0)
            {
                speed = i[rand.Next(i.Length)];
                computerSpeedChange = 50;
            }

            if(goDown && Player.Top + Player.Height < this.ClientSize.Height)
            {
                Player.Top += playerSpeed;
            }

            if(goUp && Player.Top > 0)
            {
                Player.Top -= playerSpeed;
            }


            CheckCollision(Ball, Player, Player.Right + 5);
            CheckCollision(Ball, Computer, Computer.Left - 35);

            if(computerScore > 5)
            {
                GameOver("Sorry you lost the game");
            }
            else if(playerScore > 5)
            {
                GameOver("You won this gmae");
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
            if(PicOne.Bounds.IntersectsWith(PicTwo.Bounds))
            {
                PicOne.Left = offset;

                int x = i[rand.Next(i.Length)];
                int y = i[rand.Next(i.Length)];

                if(ballXSpeed < 0)
                {
                    ballXSpeed = x;
                }
                else
                {
                    ballXSpeed = -x;
                }

                if(ballYSpeed < 0)
                {
                    ballYSpeed = -y;
                }
                else
                {
                    ballYSpeed = y;
                }
            }
        }

        private void GameOver(string message)
        {
            GameTimer.Stop();
            MessageBox.Show(message, "");
            computerScore = 0;
            playerScore = 0;
            ballXSpeed = ballYSpeed = 4;
            computerSpeedChange = 50;
            GameTimer.Start();
        }
    }
}
