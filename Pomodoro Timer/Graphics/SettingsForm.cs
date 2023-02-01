using Newtonsoft.Json;
using Pomodoro_Timer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pomodoro_Timer
{
    public partial class SettingsForm : Form
    {
        private string path = @"C:\Users\pkubo\Desktop\Pomodoro-Timer\Pomodoro Timer\DataFiles\lofi35_25_5_TimeData.json";

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < int.Parse(textBox3.Text); i++)
            {
                list.Add(int.Parse(textBox1.Text));
                list.Add(int.Parse(textBox2.Text));
            }

            TimeDataModel model = new TimeDataModel()
            {
                StudyTime = list
            };
            string json = JsonConvert.SerializeObject(model);
            System.IO.File.WriteAllText(path, json);

            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            string json = System.IO.File.ReadAllText(path);

            TimeDataModel model = JsonConvert.DeserializeObject<TimeDataModel>(json);
            textBox1.Text = model.StudyTime[0].ToString();
            textBox2.Text = model.StudyTime[1].ToString();
            textBox3.Text = (model.StudyTime.Count/2).ToString();
        }
    }
}
