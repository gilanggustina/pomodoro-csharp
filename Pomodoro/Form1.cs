using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class Form1 : Form
    {
        private bool isRunning = false;
        int second = 25 * 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            isRunning = false;
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    second = 25 * 60;
                    break;
                case 1:
                    second = 5 * 60;
                    break;
                case 2:
                    second = 15 * 60;
                    break;
            }
            buttonPomodoro.Text = "START";
            label1.Text = "25 : 00";

            button2.Text = "START";
            label2.Text = "05 : 00";

            button3.Text = "START";
            label3.Text = "15 : 00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                buttonPomodoro.Text = "START";
                isRunning = false;
                timer1.Enabled = false;
            }
            else
            {
                buttonPomodoro.Text = "PAUSE";
                isRunning = true;
                timer1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                button2.Text = "START";
                isRunning = false;
                timer1.Enabled = false;
            }
            else
            {
                button2.Text = "PAUSE";
                isRunning = true;
                timer1.Enabled = true;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                button3.Text = "START";
                isRunning = false;
                timer1.Enabled = false;
            }
            else
            {
                button3.Text = "PAUSE";
                isRunning = true;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second = second - 1;
            if (second < 1)
            {
                isRunning = false;
                timer1.Enabled = false;
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        buttonPomodoro.Text = "START";
                        label1.Text = "25 : 00";
                    break;
                    case 1:
                        button2.Text = "START";
                        label2.Text = "05 : 00";
                    break;
                    case 2:
                        button3.Text = "START";
                        label3.Text = "15 : 00";
                    break;
                }
            }
            int remainingMinutes = second / 60;
            int remainingSeconds = second - (remainingMinutes * 60);
            String minutes = remainingMinutes.ToString("D2") +" : "+remainingSeconds.ToString("D2");
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    label1.Text = minutes;
                    break;
                case 1:
                    label2.Text = minutes;
                    break;
                case 2:
                    label3.Text = minutes;
                    break;
            }
        }
    }
}
