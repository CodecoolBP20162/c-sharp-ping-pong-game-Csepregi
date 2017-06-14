namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playground = new System.Windows.Forms.Panel();
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.points_lbl = new System.Windows.Forms.Label();
            this.scorelb = new System.Windows.Forms.Label();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.gameover_lbl);
            this.playground.Controls.Add(this.points_lbl);
            this.playground.Controls.Add(this.scorelb);
            this.playground.Controls.Add(this.Ball);
            this.playground.Controls.Add(this.Racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(695, 322);
            this.playground.TabIndex = 0;
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameover_lbl.AutoSize = true;
            this.gameover_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameover_lbl.Location = new System.Drawing.Point(223, 13);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(289, 275);
            this.gameover_lbl.TabIndex = 5;
            this.gameover_lbl.Text = "Game Over\r\n\r\n\r\nF1 - Restart\r\nExc - Exit";
            this.gameover_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // points_lbl
            // 
            this.points_lbl.AutoSize = true;
            this.points_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.points_lbl.Location = new System.Drawing.Point(71, 10);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(14, 15);
            this.points_lbl.TabIndex = 4;
            this.points_lbl.Text = "0";
            // 
            // scorelb
            // 
            this.scorelb.AutoSize = true;
            this.scorelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scorelb.Location = new System.Drawing.Point(12, 9);
            this.scorelb.Name = "scorelb";
            this.scorelb.Size = new System.Drawing.Size(53, 16);
            this.scorelb.TabIndex = 3;
            this.scorelb.Text = "Score:";
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Ball.ErrorImage = null;
            this.Ball.Image = global::PingPong.Properties.Resources.Tennis_Ball;
            this.Ball.InitialImage = null;
            this.Ball.Location = new System.Drawing.Point(171, 84);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(30, 30);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // Racket
            // 
            this.Racket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Racket.Location = new System.Drawing.Point(111, 291);
            this.Racket.Name = "Racket";
            this.Racket.Size = new System.Drawing.Size(170, 19);
            this.Racket.TabIndex = 1;
            this.Racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 322);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Racket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label points_lbl;
        private System.Windows.Forms.Label scorelb;
        private System.Windows.Forms.Label gameover_lbl;
    }
}

