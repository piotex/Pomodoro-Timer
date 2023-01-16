using Pomodoro_Timer.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PomodoroProgressBar bar;
        private void Form1_Load(object sender, EventArgs e)
        {
            bar = new PomodoroProgressBar();
            bar.Location = new System.Drawing.Point(24, 230);
            bar.Size = new System.Drawing.Size(385, 20);
            bar.TabIndex = 1;
            bar.Value = 30;
            main_panel.Controls.Add(bar);
        }

        private void timer_label_Click(object sender, EventArgs e)
        {

        }


        private int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            counter ++;
            int mod_max = 5;
            if (counter % mod_max == 0)
                bar.Value = 0;
            if (counter % mod_max == 1)
                bar.Value = 30;
            if (counter % mod_max == 2)
                bar.Value = 50;
            if (counter % mod_max == 3)
                bar.Value = 70;
            if (counter % mod_max == 4)
                bar.Value = 100;
        }
    }
}
