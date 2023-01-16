namespace Pomodoro_Timer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_studyTime = new System.Windows.Forms.Button();
            this.textBox_studyTime = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer_label = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_breakTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_breakTime = new System.Windows.Forms.Button();
            this.main_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_studyTime
            // 
            this.button_studyTime.Location = new System.Drawing.Point(166, 0);
            this.button_studyTime.Name = "button_studyTime";
            this.button_studyTime.Size = new System.Drawing.Size(75, 23);
            this.button_studyTime.TabIndex = 0;
            this.button_studyTime.Text = "Start Study";
            this.button_studyTime.UseVisualStyleBackColor = true;
            this.button_studyTime.Click += new System.EventHandler(this.button_studyTime_Click);
            // 
            // textBox_studyTime
            // 
            this.textBox_studyTime.Location = new System.Drawing.Point(95, 0);
            this.textBox_studyTime.Name = "textBox_studyTime";
            this.textBox_studyTime.Size = new System.Drawing.Size(65, 20);
            this.textBox_studyTime.TabIndex = 2;
            this.textBox_studyTime.Text = "50";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer_label
            // 
            this.timer_label.BackColor = System.Drawing.Color.Transparent;
            this.timer_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timer_label.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.ForeColor = System.Drawing.Color.White;
            this.timer_label.Location = new System.Drawing.Point(0, 0);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(376, 175);
            this.timer_label.TabIndex = 0;
            this.timer_label.Text = "16:01";
            this.timer_label.Click += new System.EventHandler(this.timer_label_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.Green;
            this.main_panel.Controls.Add(this.timer_label);
            this.main_panel.Location = new System.Drawing.Point(12, 12);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(347, 411);
            this.main_panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Study Time:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_studyTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_studyTime);
            this.panel1.Location = new System.Drawing.Point(12, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 33);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_breakTime);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_breakTime);
            this.panel2.Location = new System.Drawing.Point(12, 468);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 33);
            this.panel2.TabIndex = 5;
            // 
            // textBox_breakTime
            // 
            this.textBox_breakTime.Location = new System.Drawing.Point(95, 0);
            this.textBox_breakTime.Name = "textBox_breakTime";
            this.textBox_breakTime.Size = new System.Drawing.Size(65, 20);
            this.textBox_breakTime.TabIndex = 2;
            this.textBox_breakTime.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Break Time:";
            // 
            // button_breakTime
            // 
            this.button_breakTime.Location = new System.Drawing.Point(166, 0);
            this.button_breakTime.Name = "button_breakTime";
            this.button_breakTime.Size = new System.Drawing.Size(75, 23);
            this.button_breakTime.TabIndex = 0;
            this.button_breakTime.Text = "Start Break";
            this.button_breakTime.UseVisualStyleBackColor = true;
            this.button_breakTime.Click += new System.EventHandler(this.button_breakTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_studyTime;
        private System.Windows.Forms.TextBox textBox_studyTime;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_breakTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_breakTime;
    }
}

