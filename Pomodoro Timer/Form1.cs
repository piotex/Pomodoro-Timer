using Pomodoro_Timer.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Pomodoro_Timer
{
    public partial class Form1 : Form
    {
        PomodoroProgressBar bar;
        private static DateTime endTime;
        System.Timers.Timer myTimer;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bar = new PomodoroProgressBar();
            bar.Location = new System.Drawing.Point(24, 175);
            bar.Size = new System.Drawing.Size(275, 20);
            bar.TabIndex = 1;
            bar.Value = 30;
            main_panel.Controls.Add(bar);
        }

        private void button_studyTime_Click(object sender, EventArgs e)
        {
            myTimer = new System.Timers.Timer();
            myTimer.Elapsed += new ElapsedEventHandler(decrease_timer_val);
            myTimer.Interval = 1300; // 1000 ms is one second
            myTimer.Start();

            int min_to_work = int.Parse(textBox_studyTime.Text);
            endTime = DateTime.Now.AddMinutes(min_to_work);
            bar.Value= 0;
            bar.Maximum = min_to_work * 60;
        }
        private void button_breakTime_Click(object sender, EventArgs e)
        {
            myTimer = new System.Timers.Timer();
            myTimer.Elapsed += new ElapsedEventHandler(decrease_timer_val);
            myTimer.Interval = 1300; // 1000 ms is one second
            myTimer.Start();

            int min_to_work = int.Parse(textBox_breakTime.Text);
            endTime = DateTime.Now.AddMinutes(min_to_work);
            bar.Value = 0;
            bar.Maximum = min_to_work * 60;
        }

        public void decrease_timer_val(object source, ElapsedEventArgs e)
        {
            TimeSpan tmpTime = endTime - DateTime.Now;

            if (tmpTime.TotalSeconds < 0)
            {
                myTimer.Stop();
                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                wplayer.URL = @"C:\Users\pkubo\Desktop\Pomodoro-Timer\Pomodoro Timer\Desk-bell-small-sound-effect.mp3";
                wplayer.controls.play();
            }

            if (this.timer_label.InvokeRequired)
            {
                this.timer_label.BeginInvoke((MethodInvoker)delegate () {
                    timer_label.Text = tmpTime.ToString("mm':'ss");
                });
                this.bar.BeginInvoke((MethodInvoker)delegate () {
                    bar.Value += 1;
                });
            }
        }


        private void timer_label_Click(object sender, EventArgs e)
        {

        }
    }
}
