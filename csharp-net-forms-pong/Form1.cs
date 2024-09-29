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

                int x = j[rand.Next(j.Length)];
                int y = j[rand.Next(j.Length)];

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

        }
    }
}
