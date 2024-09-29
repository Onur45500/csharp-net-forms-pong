namespace csharp_net_forms_pong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Player = new PictureBox();
            Computer = new PictureBox();
            Ball = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.BackColor = SystemColors.ControlLight;
            Player.Location = new Point(28, 144);
            Player.Name = "Player";
            Player.Size = new Size(30, 120);
            Player.TabIndex = 0;
            Player.TabStop = false;
            Player.Click += pictureBox1_Click;
            // 
            // Computer
            // 
            Computer.BackColor = SystemColors.ControlLight;
            Computer.Location = new Point(746, 144);
            Computer.Name = "Computer";
            Computer.Size = new Size(30, 120);
            Computer.TabIndex = 1;
            Computer.TabStop = false;
            Computer.Click += Computer_Click;
            // 
            // Ball
            // 
            Ball.BackColor = SystemColors.ControlLight;
            Ball.Location = new Point(376, 181);
            Ball.Name = "Ball";
            Ball.Size = new Size(30, 30);
            Ball.TabIndex = 2;
            Ball.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(Ball);
            Controls.Add(Computer);
            Controls.Add(Player);
            Name = "Form1";
            Text = "Form1";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Player;
        private PictureBox Computer;
        private PictureBox Ball;
        private System.Windows.Forms.Timer GameTimer;
    }
}
