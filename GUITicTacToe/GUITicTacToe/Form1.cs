using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITicTacToe
{
    public partial class Form1 : Form
    {
        public bool pic = true;
        BoardChecker bc = new BoardChecker();
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "X";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //every button_click is doing the same thing
        //it gives it the appopriate image depending on who is the person going, then assigns the X and O to the correct array spot
        //then checks if anyone wins with the most recent move, and if so outputs they won or tied
        private void button1_Click (object sender, EventArgs e)
        {
            if (pic == true && button1.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.cat, button1.Width, button1.Height);
                button1.Text = "";
                button1.Image = bmp;
                button1.Update();
                pic = false;
                textBox1.Text = "O";
                bc.Accumulate(0, "X");
                button1.Update();
            }
            else if (pic != true && button1.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo, button1.Width, button1.Height);
                button1.Text = "";
                button1.Image = bmp;
                button1.Update();
                pic = true;
                textBox1.Text = "X";
                bc.Accumulate(0, "O");
                button1.Update();
            }

            if (bc.Xwin())
            {
                textBox2.Text = "X Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Owin())
            {
                textBox2.Text = "O Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Tie())
            {
                textBox2.Text = "Tie!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pic == true && button2.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.cat, button1.Width, button1.Height);
                button2.Text = "";
                button2.Image = bmp;
                button2.Update();
                pic = false;
                textBox1.Text = "O";
                bc.Accumulate(1, "X");
                button2.Update();
            }
            else if (pic != true && button2.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo, button1.Width, button1.Height);
                button2.Text = "";
                button2.Image = bmp;
                button2.Update();
                pic = true;
                textBox1.Text = "X";
                bc.Accumulate(1, "O");
                button2.Update();
            }

            if (bc.Xwin())
            {
                textBox2.Text = "X Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Owin())
            {
                textBox2.Text = "O Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Tie())
            {
                textBox2.Text = "Tie!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pic == true && button3.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.cat, button1.Width, button1.Height);
                button3.Text = "";
                button3.Image = bmp;
                button3.Update();
                pic = false;
                textBox1.Text = "O";
                bc.Accumulate(2, "X");
                button3.Update();
            }
            else if (pic != true && button3.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo, button1.Width, button1.Height);
                button3.Text = "";
                button3.Image = bmp;
                button3.Update();
                pic = true;
                textBox1.Text = "X";
                bc.Accumulate(2, "O");
                button3.Update();
            }
            if (bc.Xwin())
            {
                textBox2.Text = "X Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Owin())
            {
                textBox2.Text = "O Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Tie())
            {
                textBox2.Text = "Tie!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pic == true && button4.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.cat, button1.Width, button1.Height);
                button4.Text = "";
                button4.Image = bmp;
                button4.Update();
                pic = false;
                textBox1.Text = "O";
                bc.Accumulate(3, "X");
                button4.Update();
            }
            else if (pic != true && button4.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo, button1.Width, button1.Height);
                button4.Text = "";
                button4.Image = bmp;
                button4.Update();
                pic = true;
                textBox1.Text = "X";
                bc.Accumulate(3, "O");
                button4.Update();
            }
            if (bc.Xwin())
            {
                textBox2.Text = "X Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Owin())
            {
                textBox2.Text = "O Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Tie())
            {
                textBox2.Text = "Tie!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pic == true && button5.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.cat, button1.Width, button1.Height);
                button5.Text = "";
                button5.Image = bmp;
                button5.Update();
                pic = false;
                textBox1.Text = "O";
                bc.Accumulate(4, "X");
                button5.Update();
            }
            else if (pic != true && button5.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo, button1.Width, button1.Height);
                button5.Text = "";
                button5.Image = bmp;
                button5.Update();
                pic = true;
                textBox1.Text = "X";
                bc.Accumulate(4, "O");
                button5.Update();
            }
            if (bc.Xwin())
            {
                textBox2.Text = "X Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Owin())
            {
                textBox2.Text = "O Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Tie())
            {
                textBox2.Text = "Tie!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pic == true && button6.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.cat, button1.Width, button1.Height);
                button6.Text = "";
                button6.Image = bmp;
                button6.Update();
                pic = false;
                textBox1.Text = "O";
                bc.Accumulate(5, "X");
                button6.Update();
            }
            else if (pic != true && button6.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo, button1.Width, button1.Height);
                button6.Text = "";
                button6.Image = bmp;
                button6.Update();
                pic = true;
                textBox1.Text = "X";
                bc.Accumulate(5, "O");
                button6.Update();
            }
            if (bc.Xwin())
            {
                textBox2.Text = "X Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Owin())
            {
                textBox2.Text = "O Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Tie())
            {
                textBox2.Text = "Tie!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pic == true && button7.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.cat, button1.Width, button1.Height);
                button7.Text = "";
                button7.Image = bmp;
                button7.Update();
                pic = false;
                textBox1.Text = "O";
                bc.Accumulate(6, "X");
                button7.Update();
            }
            else if (pic != true && button7.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo, button1.Width, button1.Height);
                button7.Text = "";
                button7.Image = bmp;
                button7.Update();
                pic = true;
                textBox1.Text = "X";
                bc.Accumulate(6, "O");
                button7.Update();
            }
            if (bc.Xwin())
            {
                textBox2.Text = "X Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Owin())
            {
                textBox2.Text = "O Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Tie())
            {
                textBox2.Text = "Tie!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (pic == true && button8.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.cat, button1.Width, button1.Height);
                button8.Text = "";
                button8.Image = bmp;
                button8.Update();
                pic = false;
                textBox1.Text = "O";
                bc.Accumulate(7, "X");
                button8.Update();
            }
            else if (pic != true && button8.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo, button1.Width, button1.Height);
                button8.Text = "";
                button8.Image = bmp;
                button8.Update();
                pic = true;
                textBox1.Text = "X";
                bc.Accumulate(7, "O");
                button8.Update();
            }
            if (bc.Xwin())
            {
                textBox2.Text = "X Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Owin())
            {
                textBox2.Text = "O Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Tie())
            {
                textBox2.Text = "Tie!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (pic == true && button9.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.cat, button1.Width, button1.Height);
                button9.Text = "";
                button9.Image = bmp;
                button9.Update();
                pic = false;
                textBox1.Text = "O";
                bc.Accumulate(8, "X");
                button9.Update();
            }
            else if (pic != true && button9.Image == null)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo, button1.Width, button1.Height);
                button9.Text = "";
                button9.Image = bmp;
                button9.Update();
                pic = true;
                textBox1.Text = "X";
                bc.Accumulate(8, "O");
                button9.Update();
            }
            if (bc.Xwin())
            {
                textBox2.Text = "X Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Owin())
            {
                textBox2.Text = "O Wins!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
            else if (bc.Tie())
            {
                textBox2.Text = "Tie!";
                textBox3.Text = "Result: " + Environment.NewLine + "X Winning: " + bc.xAvg + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
            }
        }

        //clears everything
        private void button10_Click(object sender, EventArgs e)
        {
            button1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image = null;
            button8.Image = null;
            button9.Image = null;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "Records:";
            bc.numGames = 0;
            bc.oAvg = 0;
            bc.oWins = 0;
            bc.xAvg = 0;
            bc.xWins = 0;

            bc.Clear();
        }

        //makes it so that when play again is clicked it resets the board but keeps the score
        private void button11_Click(object sender, EventArgs e)
        {
            button1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image = null;
            button8.Image = null;
            button9.Image = null;
            textBox1.Text = "";
            textBox2.Text = "";
            bc.Clear();
        }
    }
}
