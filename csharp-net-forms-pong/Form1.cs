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
        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void CheckCollision(PictureBox PicOne, PictureBox PicTwo, int offset)
        {

        }

        private void GameOver(string message)
        {

        }
    }
}
