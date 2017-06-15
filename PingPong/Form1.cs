using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public int speed_left = 4;  //Speed of the ball
        public int speed_top = 4;
        public int point = 0;         // Scored points
        public int level = 0;         // Level

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;   //Remove any border
            this.TopMost = true;                           //Bring the form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;      // Make it fullscreen


            Racket.Top = playground.Bottom - (playground.Bottom / 10); // Set the position of the racket

            gameover_lbl.Left = (playground.Width / 2) - (gameover_lbl.Width / 2);   // Position to center
            gameover_lbl.Top = (playground.Height / 2) - (gameover_lbl.Height / 2);
            gameover_lbl.Visible = false;     //Hide
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Racket.Left = Cursor.Position.X - (Racket.Width / 2);  // Set the center of the racket to the position of the cursor

            Ball.Left += speed_left;   //Move the ball
            Ball.Top += speed_top;

            if (Ball.Bounds.IntersectsWith(Racket.Bounds))
            //if (Ball.Bottom >= Racket.Top && Ball.Bottom <= Racket.Bottom && Ball.Left >= Racket.Left && Ball.Right <= Racket.Right)  //Racket collision
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;  //Change direction
                point += 1;
                points_lbl.Text = point.ToString();
                level += 1;
                levelSizelbl.Text = level.ToString();
                progressBar.Value += 5;

            }

            if (Ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if (Ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if (Ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }

            if (Ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;  //Ball is out -> Stop the game
                gameover_lbl.Visible = true;
            }


        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Application.Exit(); } // press escape to quit
            if (e.KeyCode == Keys.F1)
            {
                Ball.Top = 50;
                Ball.Left = 50;
                speed_left = 4;
                point = 0;
                points_lbl.Text = "0";
                timer1.Enabled = true;
                gameover_lbl.Visible = false;
            }






        }
    }
}

