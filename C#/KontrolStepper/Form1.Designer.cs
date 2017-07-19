namespace KontrolStepper
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Button4 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.rbMicro = new System.Windows.Forms.RadioButton();
            this.Button3 = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.rbCCW = new System.Windows.Forms.RadioButton();
            this.rbCW = new System.Windows.Forms.RadioButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHalf = new System.Windows.Forms.RadioButton();
            this.rbFull = new System.Windows.Forms.RadioButton();
            this.rbDiscont = new System.Windows.Forms.RadioButton();
            this.rbCont = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.sudutBox = new System.Windows.Forms.TextBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this._data = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.phsGrf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phsGrf)).BeginInit();
            this.SuspendLayout();
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(176, 355);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(88, 49);
            this.Button4.TabIndex = 20;
            this.Button4.Text = "STOP";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(21, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 13);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Serial Port";
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(105, 64);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 17;
            this.Button2.Text = "Connect";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Enabled = false;
            this.Button1.Location = new System.Drawing.Point(24, 64);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 16;
            this.Button1.Text = "Disconnect";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(24, 37);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(156, 21);
            this.cboPorts.TabIndex = 15;
            this.cboPorts.DropDown += new System.EventHandler(this.cboPorts_DropDown);
            // 
            // rbMicro
            // 
            this.rbMicro.AutoSize = true;
            this.rbMicro.Location = new System.Drawing.Point(7, 67);
            this.rbMicro.Name = "rbMicro";
            this.rbMicro.Size = new System.Drawing.Size(76, 17);
            this.rbMicro.TabIndex = 2;
            this.rbMicro.Text = "Micro Step";
            this.rbMicro.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(76, 355);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(84, 49);
            this.Button3.TabIndex = 19;
            this.Button3.Text = "RUN";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.GroupBox3);
            this.GroupBox2.Controls.Add(this.GroupBox1);
            this.GroupBox2.Location = new System.Drawing.Point(21, 222);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(301, 127);
            this.GroupBox2.TabIndex = 13;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Motor Setting";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.rbCCW);
            this.GroupBox3.Controls.Add(this.rbCW);
            this.GroupBox3.Location = new System.Drawing.Point(155, 19);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(137, 100);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Direction";
            // 
            // rbCCW
            // 
            this.rbCCW.AutoSize = true;
            this.rbCCW.Location = new System.Drawing.Point(6, 54);
            this.rbCCW.Name = "rbCCW";
            this.rbCCW.Size = new System.Drawing.Size(116, 17);
            this.rbCCW.TabIndex = 1;
            this.rbCCW.Text = "Counter ClockWise";
            this.rbCCW.UseVisualStyleBackColor = true;
            // 
            // rbCW
            // 
            this.rbCW.AutoSize = true;
            this.rbCW.Checked = true;
            this.rbCW.Location = new System.Drawing.Point(6, 20);
            this.rbCW.Name = "rbCW";
            this.rbCW.Size = new System.Drawing.Size(79, 17);
            this.rbCW.TabIndex = 0;
            this.rbCW.TabStop = true;
            this.rbCW.Text = "Clock Wise";
            this.rbCW.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.rbMicro);
            this.GroupBox1.Controls.Add(this.rbHalf);
            this.GroupBox1.Controls.Add(this.rbFull);
            this.GroupBox1.Location = new System.Drawing.Point(14, 19);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(125, 100);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Mode";
            // 
            // rbHalf
            // 
            this.rbHalf.AutoSize = true;
            this.rbHalf.Location = new System.Drawing.Point(7, 44);
            this.rbHalf.Name = "rbHalf";
            this.rbHalf.Size = new System.Drawing.Size(69, 17);
            this.rbHalf.TabIndex = 1;
            this.rbHalf.Text = "Half Step";
            this.rbHalf.UseVisualStyleBackColor = true;
            // 
            // rbFull
            // 
            this.rbFull.AutoSize = true;
            this.rbFull.Checked = true;
            this.rbFull.Location = new System.Drawing.Point(7, 20);
            this.rbFull.Name = "rbFull";
            this.rbFull.Size = new System.Drawing.Size(66, 17);
            this.rbFull.TabIndex = 0;
            this.rbFull.TabStop = true;
            this.rbFull.Text = "Full Step";
            this.rbFull.UseVisualStyleBackColor = true;
            // 
            // rbDiscont
            // 
            this.rbDiscont.AutoSize = true;
            this.rbDiscont.Location = new System.Drawing.Point(14, 42);
            this.rbDiscont.Name = "rbDiscont";
            this.rbDiscont.Size = new System.Drawing.Size(92, 17);
            this.rbDiscont.TabIndex = 4;
            this.rbDiscont.Text = "Discontinuous";
            this.rbDiscont.UseVisualStyleBackColor = true;
            this.rbDiscont.CheckedChanged += new System.EventHandler(this.rbDiscont_CheckedChanged);
            // 
            // rbCont
            // 
            this.rbCont.AutoSize = true;
            this.rbCont.Checked = true;
            this.rbCont.Location = new System.Drawing.Point(14, 19);
            this.rbCont.Name = "rbCont";
            this.rbCont.Size = new System.Drawing.Size(78, 17);
            this.rbCont.TabIndex = 3;
            this.rbCont.TabStop = true;
            this.rbCont.Text = "Continuous";
            this.rbCont.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(30, 74);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Degrees";
            // 
            // sudutBox
            // 
            this.sudutBox.Enabled = false;
            this.sudutBox.Location = new System.Drawing.Point(83, 71);
            this.sudutBox.Name = "sudutBox";
            this.sudutBox.Size = new System.Drawing.Size(100, 20);
            this.sudutBox.TabIndex = 5;
            this.sudutBox.Text = "0";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Label1);
            this.GroupBox4.Controls.Add(this.sudutBox);
            this.GroupBox4.Controls.Add(this.rbDiscont);
            this.GroupBox4.Controls.Add(this.rbCont);
            this.GroupBox4.Location = new System.Drawing.Point(21, 102);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(301, 114);
            this.GroupBox4.TabIndex = 14;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Rotation";
            // 
            // _data
            // 
            this._data.ReceivedBytesThreshold = 13;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // phsGrf
            // 
            chartArea1.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds;
            chartArea1.Name = "ChartArea1";
            this.phsGrf.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.phsGrf.Legends.Add(legend1);
            this.phsGrf.Location = new System.Drawing.Point(367, 18);
            this.phsGrf.Name = "phsGrf";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "pA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Legend = "Legend1";
            series2.Name = "pB";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.phsGrf.Series.Add(series1);
            this.phsGrf.Series.Add(series2);
            this.phsGrf.Size = new System.Drawing.Size(462, 331);
            this.phsGrf.TabIndex = 26;
            this.phsGrf.Text = "Phase";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 422);
            this.Controls.Add(this.phsGrf);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox4);
            this.Name = "Form1";
            this.Text = "Kontrol Stepper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phsGrf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.ComboBox cboPorts;
        internal System.Windows.Forms.RadioButton rbMicro;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.RadioButton rbCCW;
        internal System.Windows.Forms.RadioButton rbCW;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton rbHalf;
        internal System.Windows.Forms.RadioButton rbFull;
        internal System.Windows.Forms.RadioButton rbDiscont;
        internal System.Windows.Forms.RadioButton rbCont;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox sudutBox;
        internal System.Windows.Forms.GroupBox GroupBox4;
        private System.IO.Ports.SerialPort _data;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataVisualization.Charting.Chart phsGrf;
    }
}

