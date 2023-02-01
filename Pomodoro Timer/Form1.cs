using Newtonsoft.Json;
using Pomodoro_Timer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Pomodoro_Timer
{
    public partial class Form1 : Form
    {
        private static DateTime endTime;
        private System.Timers.Timer myTimer;
        private IEnumerator<int> timeEnumerator;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Menu = new MainMenu();
            this.Menu.MenuItems.Add("Settings", new EventHandler(OpenSettingsForm));

            //MenuItem item2 = new MenuItem("File");
            //this.Menu.MenuItems.Add(item2);
            //item2.MenuItems.Add("Save", new EventHandler(Save_Click));
            //item2.MenuItems.Add("Open", new EventHandler(Open_Click));
        }

        private void OpenSettingsForm(object sender, EventArgs e)
        {
            var form_s = new SettingsForm();
            form_s.Show();
        }


        public void decrease_timer_val(object source, ElapsedEventArgs e)
        {
            TimeSpan tmpTime = endTime - DateTime.Now;

            if (tmpTime.TotalSeconds < 0)
            {
                try
                {
                    timeEnumerator.MoveNext();
                    endTime = DateTime.Now.AddMinutes(timeEnumerator.Current);
                }
                catch (Exception)
                {
                    myTimer.Stop();

                }
            }

            if (this.timer_label.InvokeRequired)
            {
                this.timer_label.BeginInvoke((MethodInvoker)delegate () {
                    timer_label.Text = tmpTime.ToString("mm':'ss");
                });
            }
        }


        public IEnumerable<int> GetTimeFromJson()
        {
            var model = GetTimeDataModel();
            foreach (var item in model.StudyTime)
            {
                yield return item;
            }
        }
        public TimeDataModel GetTimeDataModel()
        {
            string path = @"C:\Users\pkubo\Desktop\Pomodoro-Timer\Pomodoro Timer\DataFiles\lofi35_25_5_TimeData.json";
            string json = System.IO.File.ReadAllText(path);

            var timeDataModel = JsonConvert.DeserializeObject<TimeDataModel>(json);
            return timeDataModel;
        }

        private void playMusic()
        {
            //string pathh = @"C:\Users\pkubo\Desktop\Pomodoro-Timer\Pomodoro Timer\DataFiles\Desk-bell-small-sound-effect.mp3";
            string pathh = @"C:\Users\pkubo\Desktop\Pomodoro-Timer\Pomodoro Timer\DataFiles\lofi35_25_5.mp4";
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = pathh;
            wplayer.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeEnumerator = GetTimeFromJson().GetEnumerator();
            timeEnumerator.MoveNext();
            endTime = DateTime.Now.AddMinutes(timeEnumerator.Current);

            myTimer = new System.Timers.Timer();
            myTimer.Elapsed += new ElapsedEventHandler(decrease_timer_val);
            myTimer.Interval = 1000; // 1000 ms is one second
            myTimer.Start();

            Thread thread = new Thread(playMusic);
            thread.Start();
        }

        private void timer_label_Paint(object sender, PaintEventArgs e)
        {
            Color OutlineForeColor = Color.Black;
            float OutlineWidth = 2;

            
            //e.Graphics.FillRectangle(new SolidBrush(Color.White), ClientRectangle);
            using (GraphicsPath gp = new GraphicsPath())
            {
                using (Pen outline = new Pen(OutlineForeColor, OutlineWidth){ LineJoin = LineJoin.Round })
                {
                    using (StringFormat sf = new StringFormat())
                    {
                        using (Brush foreBrush = new SolidBrush(ForeColor))
                        {
                            Matrix matrix = new Matrix();
                            matrix.Translate(2, 0);

                            gp.AddString(
                                timer_label.Text, 
                                timer_label.Font.FontFamily, 
                                (int)timer_label.Font.Style, 
                                timer_label.Font.Size, 
                                timer_label.ClientRectangle, 
                                sf
                            );
                            e.Graphics.ScaleTransform(1.3f, 1.35f);
                            //e.Graphics.ScaleTransform(12, 12);
                            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

                            gp.Transform(matrix);

                            e.Graphics.DrawPath(outline, gp);
                            //e.Graphics.FillPath(foreBrush, gp);

                        }
                    }
                }
            }
            
        }
    }
}
