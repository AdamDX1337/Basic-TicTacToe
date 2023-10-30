using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int type = 1; //1 = X, 2 = O;

        //Win Counters
        int winX = 0;
        int winO = 0;
        int winDraw = 0;
        int count = 0;


        bool auto = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                
            }
            else if(type == 1)
            {
                type = 2;
                button1.Text = "X";
                count++;
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text != "")
            {

            }
            else if (type == 1)
            {
                type = 2;
                button2.Text = "X";
                count++;
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text != "")
            {

            }
            else if (type == 1)
            {
                type = 2;
                button3.Text = "X";
                count++;
            }
        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text != "")
            {

            }
            else if (type == 1)
            {
                type = 2;
                button4.Text = "X";
                count++;
            }
        }

        public void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text != "")
            {

            }
            else if (type == 1)
            {
                type = 2;
                button5.Text = "X";
                count++;
            }
        }

        public void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text != "")
            {

            }
            else if (type == 1)
            {
                type = 2;
                button6.Text = "X";
                count++;
            }
        }

        public void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text != "")
            {

            }
            else if (type == 1)
            {
                type = 2;
                button7.Text = "X";
                count++;
            }

        }

        public void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text != "")
            {

            }
            else if (type == 1)
            {
                type = 2;
                button8.Text = "X";
                count++;
            }

        }

        public void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text != "")
            {

            }
            else if (type == 1)
            {
                type = 2;
                button9.Text = "X";
                count++;
            }

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckWinner.CheckWin("O", button1, button2, button3, button4, button5, button6, button7, button8, button9))
            {
                type = 0;
                listBox1.Items.Add("Win: O");
                ClearButtons();
                winO++;
                label2.Text = $"O Wins: {winO}";
            }
            else if (CheckWinner.CheckWin("X", button1, button2, button3, button4, button5, button6, button7, button8, button9))
            {
                type = 0;
                listBox1.Items.Add("Win: X");
                ClearButtons();
                winX++;
                label3.Text = $"X Wins: {winX}";
            }
            else if (!CheckWinner.CheckWin("X", button1, button2, button3, button4, button5, button6, button7, button8, button9)
                && !CheckWinner.CheckWin("O", button1, button2, button3, button4, button5, button6, button7, button8, button9)
                && count == 5)
            {
                type = 0;
                listBox1.Items.Add("Draw");
                ClearButtons();
                winDraw++;
                label4.Text = $"Draws: {winDraw}";
            }


            if (type == 2)
            {
                if (count <= 1)
                {
                    type = Movement.MakeMove(button1, button2, button3, button4, button5, button6, button7, button8, button9);
                }
                else if (count >= 2)
                {
                    type = Movement.MakeEducatedMove(button1,button2,button3,button4,button5,button6,button7,button8,button9);
                }
            }




            if (auto)
            {
                if (type == 1)
                {
                    if (count <= 1)
                    {
                        type = MovementX.MakeMoveX(button1, button2, button3, button4, button5, button6, button7, button8, button9);
                        count++;
                    }
                    else if (count >= 2)
                    {
                        type = MovementX.MakeEducatedMoveX(button1, button2, button3, button4, button5, button6, button7, button8, button9);
                        count++;
                    }
                }
            }
            


            


        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ClearButtons();
            winDraw = 0;
            winX = 0;
            winO = 0;
            label4.Text = $"Draws: {winDraw}";
            label3.Text = $"X Wins: {winX}";
            label2.Text = $"O Wins: {winO}";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void ClearButtons()
        {
            type = 1;
            count = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            auto = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            auto = false;
        }
    }
}
