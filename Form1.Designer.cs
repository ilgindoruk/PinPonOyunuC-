namespace PinPonOyunuC_
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Player = new PictureBox();
            computer = new PictureBox();
            ball = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(-4, -32);
            label1.Name = "label1";
            label1.Size = new Size(24, 553);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(1080, -32);
            label2.Name = "label2";
            label2.Size = new Size(24, 566);
            label2.TabIndex = 0;
            label2.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-4, -3);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // Player
            // 
            Player.Image = Properties.Resources.player;
            Player.Location = new Point(12, 183);
            Player.Name = "Player";
            Player.Size = new Size(30, 129);
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.TabIndex = 2;
            Player.TabStop = false;
            // 
            // computer
            // 
            computer.Image = Properties.Resources.computer;
            computer.Location = new Point(1063, 183);
            computer.Name = "computer";
            computer.Size = new Size(30, 129);
            computer.SizeMode = PictureBoxSizeMode.StretchImage;
            computer.TabIndex = 2;
            computer.TabStop = false;
            // 
            // ball
            // 
            ball.Image = Properties.Resources.ball;
            ball.Location = new Point(528, 232);
            ball.Name = "ball";
            ball.Size = new Size(30, 30);
            ball.SizeMode = PictureBoxSizeMode.StretchImage;
            ball.TabIndex = 2;
            ball.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1105, 530);
            Controls.Add(computer);
            Controls.Add(ball);
            Controls.Add(Player);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Player 0 -- Computer 0";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox Player;
        private PictureBox computer;
        private PictureBox ball;
        private System.Windows.Forms.Timer GameTimer;
    }
}