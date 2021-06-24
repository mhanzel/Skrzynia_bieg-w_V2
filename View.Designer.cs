namespace Skrzynia_biegów_V2
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.AGaugeRange aGaugeRange7 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange8 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange9 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange10 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange11 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange12 = new System.Windows.Forms.AGaugeRange();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BarSzybkosc = new System.Windows.Forms.TrackBar();
            this.button4 = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonOFF = new System.Windows.Forms.RadioButton();
            this.RadioButtonOn = new System.Windows.Forms.RadioButton();
            this.BoxDownPraca = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BarPraca = new System.Windows.Forms.TrackBar();
            this.BoxDownObc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxDownUchyl = new System.Windows.Forms.Label();
            this.BarObc = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.BarUchyl = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.aGauge2 = new System.Windows.Forms.AGauge();
            this.label6 = new System.Windows.Forms.Label();
            this.BoxRPM = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxSec = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxMin = new System.Windows.Forms.Label();
            this.BoxDownSpeed = new System.Windows.Forms.TextBox();
            this.BoxDownGear = new System.Windows.Forms.TextBox();
            this.TimerTick = new System.Windows.Forms.Timer(this.components);
            this.TimerCzas = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarSzybkosc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarPraca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarObc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarUchyl)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.BarSzybkosc);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.ButtonStop);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.BoxDownPraca);
            this.panel1.Controls.Add(this.ButtonStart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BarPraca);
            this.panel1.Controls.Add(this.BoxDownObc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BoxDownUchyl);
            this.panel1.Controls.Add(this.BarObc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BarUchyl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 886);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(34, 803);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "Szybkość symulacji";
            // 
            // BarSzybkosc
            // 
            this.BarSzybkosc.LargeChange = 1;
            this.BarSzybkosc.Location = new System.Drawing.Point(37, 829);
            this.BarSzybkosc.Maximum = 2;
            this.BarSzybkosc.Minimum = -2;
            this.BarSzybkosc.Name = "BarSzybkosc";
            this.BarSzybkosc.Size = new System.Drawing.Size(104, 45);
            this.BarSzybkosc.TabIndex = 34;
            this.BarSzybkosc.Scroll += new System.EventHandler(this.BarSzybkosc_Scroll);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.WindowText;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(15, 741);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 57);
            this.button4.TabIndex = 33;
            this.button4.Text = "Wyświetl charakterystyki";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.BackColor = System.Drawing.SystemColors.WindowText;
            this.ButtonStop.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.ButtonStop.FlatAppearance.BorderSize = 0;
            this.ButtonStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ButtonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonStop.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonStop.Location = new System.Drawing.Point(0, 194);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(172, 37);
            this.ButtonStop.TabIndex = 1;
            this.ButtonStop.Text = "STOP";
            this.ButtonStop.UseVisualStyleBackColor = false;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonOFF);
            this.groupBox1.Controls.Add(this.RadioButtonOn);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(40, 634);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 77);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Praca skrzyni";
            // 
            // RadioButtonOFF
            // 
            this.RadioButtonOFF.AutoSize = true;
            this.RadioButtonOFF.ForeColor = System.Drawing.SystemColors.Window;
            this.RadioButtonOFF.Location = new System.Drawing.Point(7, 44);
            this.RadioButtonOFF.Name = "RadioButtonOFF";
            this.RadioButtonOFF.Size = new System.Drawing.Size(62, 17);
            this.RadioButtonOFF.TabIndex = 1;
            this.RadioButtonOFF.Text = "Wyłącz";
            this.RadioButtonOFF.UseVisualStyleBackColor = true;
            // 
            // RadioButtonOn
            // 
            this.RadioButtonOn.AutoSize = true;
            this.RadioButtonOn.Checked = true;
            this.RadioButtonOn.ForeColor = System.Drawing.SystemColors.Window;
            this.RadioButtonOn.Location = new System.Drawing.Point(7, 21);
            this.RadioButtonOn.Name = "RadioButtonOn";
            this.RadioButtonOn.Size = new System.Drawing.Size(57, 17);
            this.RadioButtonOn.TabIndex = 0;
            this.RadioButtonOn.TabStop = true;
            this.RadioButtonOn.Text = "Włącz";
            this.RadioButtonOn.UseVisualStyleBackColor = true;
            // 
            // BoxDownPraca
            // 
            this.BoxDownPraca.AutoSize = true;
            this.BoxDownPraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxDownPraca.ForeColor = System.Drawing.SystemColors.Window;
            this.BoxDownPraca.Location = new System.Drawing.Point(51, 590);
            this.BoxDownPraca.Name = "BoxDownPraca";
            this.BoxDownPraca.Size = new System.Drawing.Size(79, 24);
            this.BoxDownPraca.TabIndex = 20;
            this.BoxDownPraca.Text = "SPORT";
            this.BoxDownPraca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxDownPraca.UseMnemonic = false;
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.SystemColors.WindowText;
            this.ButtonStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.ButtonStart.FlatAppearance.BorderSize = 0;
            this.ButtonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonStart.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonStart.Location = new System.Drawing.Point(0, 140);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(175, 45);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "START";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(52, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tryb pracy";
            // 
            // BarPraca
            // 
            this.BarPraca.LargeChange = 1;
            this.BarPraca.Location = new System.Drawing.Point(37, 532);
            this.BarPraca.Maximum = 3;
            this.BarPraca.Minimum = 1;
            this.BarPraca.Name = "BarPraca";
            this.BarPraca.Size = new System.Drawing.Size(104, 45);
            this.BarPraca.TabIndex = 18;
            this.BarPraca.Value = 1;
            // 
            // BoxDownObc
            // 
            this.BoxDownObc.AutoSize = true;
            this.BoxDownObc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxDownObc.ForeColor = System.Drawing.SystemColors.Window;
            this.BoxDownObc.Location = new System.Drawing.Point(80, 457);
            this.BoxDownObc.Name = "BoxDownObc";
            this.BoxDownObc.Size = new System.Drawing.Size(21, 24);
            this.BoxDownObc.TabIndex = 17;
            this.BoxDownObc.Text = "0";
            this.BoxDownObc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxDownObc.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(9, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Regulacja obciążenia";
            // 
            // BoxDownUchyl
            // 
            this.BoxDownUchyl.AutoSize = true;
            this.BoxDownUchyl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxDownUchyl.ForeColor = System.Drawing.SystemColors.Window;
            this.BoxDownUchyl.Location = new System.Drawing.Point(80, 331);
            this.BoxDownUchyl.Name = "BoxDownUchyl";
            this.BoxDownUchyl.Size = new System.Drawing.Size(21, 24);
            this.BoxDownUchyl.TabIndex = 15;
            this.BoxDownUchyl.Text = "0";
            this.BoxDownUchyl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxDownUchyl.UseMnemonic = false;
            // 
            // BarObc
            // 
            this.BarObc.Location = new System.Drawing.Point(37, 399);
            this.BarObc.Maximum = 30;
            this.BarObc.Minimum = -30;
            this.BarObc.Name = "BarObc";
            this.BarObc.Size = new System.Drawing.Size(104, 45);
            this.BarObc.TabIndex = 4;
            this.BarObc.Scroll += new System.EventHandler(this.BarObc_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uchył przepustnicy";
            // 
            // BarUchyl
            // 
            this.BarUchyl.BackColor = System.Drawing.SystemColors.WindowText;
            this.BarUchyl.Location = new System.Drawing.Point(37, 283);
            this.BarUchyl.Maximum = 45;
            this.BarUchyl.Name = "BarUchyl";
            this.BarUchyl.Size = new System.Drawing.Size(104, 45);
            this.BarUchyl.TabIndex = 2;
            this.BarUchyl.Scroll += new System.EventHandler(this.BarUchyl_Scroll);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.aGauge1);
            this.panel2.Controls.Add(this.aGauge2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.BoxRPM);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.BoxSec);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BoxMin);
            this.panel2.Controls.Add(this.BoxDownSpeed);
            this.panel2.Controls.Add(this.BoxDownGear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(175, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 886);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel4.Controls.Add(this.button3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 863);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(942, 23);
            this.panel4.TabIndex = 40;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(877, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 22);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(448, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(275, 29);
            this.label10.TabIndex = 39;
            this.label10.Text = "Regulacja obciążenia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(36, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 29);
            this.label9.TabIndex = 38;
            this.label9.Text = "Bieg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(36, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 29);
            this.label8.TabIndex = 37;
            this.label8.Text = "Prędkość";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(50, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 29);
            this.label7.TabIndex = 36;
            this.label7.Text = "Czas symulacji";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(942, 120);
            this.panel3.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(439, 497);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.ShadowColor = System.Drawing.Color.Black;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(351, 134);
            this.chart1.TabIndex = 35;
            this.chart1.Text = "chart1";
            // 
            // aGauge1
            // 
            this.aGauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.aGauge1.BackColor = System.Drawing.SystemColors.Window;
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(110, 100);
            aGaugeRange7.Color = System.Drawing.Color.Empty;
            aGaugeRange7.EndValue = 0F;
            aGaugeRange7.InnerRadius = 1;
            aGaugeRange7.InRange = false;
            aGaugeRange7.Name = "GaugeRange1";
            aGaugeRange7.OuterRadius = 2;
            aGaugeRange7.StartValue = 0F;
            aGaugeRange8.Color = System.Drawing.Color.Empty;
            aGaugeRange8.EndValue = 0F;
            aGaugeRange8.InnerRadius = 1;
            aGaugeRange8.InRange = false;
            aGaugeRange8.Name = "GaugeRange2";
            aGaugeRange8.OuterRadius = 2;
            aGaugeRange8.StartValue = 0F;
            aGaugeRange9.Color = System.Drawing.Color.Empty;
            aGaugeRange9.EndValue = 0F;
            aGaugeRange9.InnerRadius = 1;
            aGaugeRange9.InRange = false;
            aGaugeRange9.Name = "GaugeRange3";
            aGaugeRange9.OuterRadius = 2;
            aGaugeRange9.StartValue = 0F;
            this.aGauge1.GaugeRanges.Add(aGaugeRange7);
            this.aGauge1.GaugeRanges.Add(aGaugeRange8);
            this.aGauge1.GaugeRanges.Add(aGaugeRange9);
            this.aGauge1.Location = new System.Drawing.Point(650, 243);
            this.aGauge1.MaxValue = 8000F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Yellow;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 1000F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(245, 193);
            this.aGauge1.TabIndex = 34;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            this.aGauge1.ValueInRangeChanged += new System.EventHandler<System.Windows.Forms.ValueInRangeChangedEventArgs>(this.aGauge1_ValueInRangeChanged);
            // 
            // aGauge2
            // 
            this.aGauge2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.aGauge2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge2.BaseArcRadius = 80;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 270;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Center = new System.Drawing.Point(110, 100);
            aGaugeRange10.Color = System.Drawing.Color.Empty;
            aGaugeRange10.EndValue = 0F;
            aGaugeRange10.InnerRadius = 1;
            aGaugeRange10.InRange = false;
            aGaugeRange10.Name = "GaugeRange1";
            aGaugeRange10.OuterRadius = 2;
            aGaugeRange10.StartValue = 0F;
            aGaugeRange11.Color = System.Drawing.Color.Empty;
            aGaugeRange11.EndValue = 0F;
            aGaugeRange11.InnerRadius = 1;
            aGaugeRange11.InRange = false;
            aGaugeRange11.Name = "GaugeRange2";
            aGaugeRange11.OuterRadius = 2;
            aGaugeRange11.StartValue = 0F;
            aGaugeRange12.Color = System.Drawing.Color.Empty;
            aGaugeRange12.EndValue = 0F;
            aGaugeRange12.InnerRadius = 1;
            aGaugeRange12.InRange = false;
            aGaugeRange12.Name = "GaugeRange3";
            aGaugeRange12.OuterRadius = 2;
            aGaugeRange12.StartValue = 0F;
            this.aGauge2.GaugeRanges.Add(aGaugeRange10);
            this.aGauge2.GaugeRanges.Add(aGaugeRange11);
            this.aGauge2.GaugeRanges.Add(aGaugeRange12);
            this.aGauge2.Location = new System.Drawing.Point(391, 244);
            this.aGauge2.MaxValue = 260F;
            this.aGauge2.MinValue = 0F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Yellow;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge2.NeedleRadius = 80;
            this.aGauge2.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesInterInnerRadius = 73;
            this.aGauge2.ScaleLinesInterOuterRadius = 80;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 70;
            this.aGauge2.ScaleLinesMajorOuterRadius = 80;
            this.aGauge2.ScaleLinesMajorStepValue = 20F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge2.ScaleLinesMinorInnerRadius = 75;
            this.aGauge2.ScaleLinesMinorOuterRadius = 80;
            this.aGauge2.ScaleLinesMinorTicks = 9;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 95;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 0;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(248, 179);
            this.aGauge2.TabIndex = 33;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 0F;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(209, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "RPM";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseMnemonic = false;
            // 
            // BoxRPM
            // 
            this.BoxRPM.AutoSize = true;
            this.BoxRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxRPM.Location = new System.Drawing.Point(178, 262);
            this.BoxRPM.Name = "BoxRPM";
            this.BoxRPM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BoxRPM.Size = new System.Drawing.Size(141, 58);
            this.BoxRPM.TabIndex = 31;
            this.BoxRPM.Text = "2000";
            this.BoxRPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxRPM.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(143, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "s";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseMnemonic = false;
            // 
            // BoxSec
            // 
            this.BoxSec.AutoSize = true;
            this.BoxSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxSec.Location = new System.Drawing.Point(116, 161);
            this.BoxSec.Name = "BoxSec";
            this.BoxSec.Size = new System.Drawing.Size(21, 24);
            this.BoxSec.TabIndex = 29;
            this.BoxSec.Text = "0";
            this.BoxSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxSec.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(82, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "m";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseMnemonic = false;
            // 
            // BoxMin
            // 
            this.BoxMin.AutoSize = true;
            this.BoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxMin.Location = new System.Drawing.Point(51, 161);
            this.BoxMin.Name = "BoxMin";
            this.BoxMin.Size = new System.Drawing.Size(21, 24);
            this.BoxMin.TabIndex = 26;
            this.BoxMin.Text = "0";
            this.BoxMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxMin.UseMnemonic = false;
            // 
            // BoxDownSpeed
            // 
            this.BoxDownSpeed.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoxDownSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxDownSpeed.Location = new System.Drawing.Point(55, 262);
            this.BoxDownSpeed.Name = "BoxDownSpeed";
            this.BoxDownSpeed.ReadOnly = true;
            this.BoxDownSpeed.Size = new System.Drawing.Size(92, 62);
            this.BoxDownSpeed.TabIndex = 10;
            this.BoxDownSpeed.Text = "000";
            // 
            // BoxDownGear
            // 
            this.BoxDownGear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoxDownGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxDownGear.Location = new System.Drawing.Point(55, 409);
            this.BoxDownGear.Name = "BoxDownGear";
            this.BoxDownGear.ReadOnly = true;
            this.BoxDownGear.Size = new System.Drawing.Size(42, 62);
            this.BoxDownGear.TabIndex = 8;
            this.BoxDownGear.Text = "N";
            // 
            // TimerTick
            // 
            this.TimerTick.Interval = 50;
            this.TimerTick.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerCzas
            // 
            this.TimerCzas.Tick += new System.EventHandler(this.TimerCzas_Tick_1);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 886);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "View";
            this.Text = "View";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarSzybkosc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarPraca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarObc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarUchyl)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.TrackBar BarUchyl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar BarObc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BoxDownUchyl;
        private System.Windows.Forms.Label BoxDownObc;
        private System.Windows.Forms.TrackBar BarPraca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BoxDownPraca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButtonOFF;
        private System.Windows.Forms.RadioButton RadioButtonOn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox BoxDownGear;
        private System.Windows.Forms.TextBox BoxDownSpeed;
        private System.Windows.Forms.Label BoxMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BoxSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BoxRPM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.AGauge aGauge2;
        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer TimerTick;
        private System.Windows.Forms.TrackBar BarSzybkosc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer TimerCzas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}