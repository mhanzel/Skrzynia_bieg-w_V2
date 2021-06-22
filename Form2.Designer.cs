namespace Skrzynia_biegów_V2
{
    partial class Form2
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
            System.Windows.Forms.AGaugeRange aGaugeRange4 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange5 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange6 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.aGauge2 = new System.Windows.Forms.AGauge();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxSec = new System.Windows.Forms.Label();
            this.BoxMin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TimerCzas = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BoxRPM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // aGauge1
            // 
            this.aGauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.aGauge1.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(110, 100);
            aGaugeRange4.Color = System.Drawing.Color.Empty;
            aGaugeRange4.EndValue = 0F;
            aGaugeRange4.InnerRadius = 1;
            aGaugeRange4.InRange = false;
            aGaugeRange4.Name = "GaugeRange1";
            aGaugeRange4.OuterRadius = 2;
            aGaugeRange4.StartValue = 0F;
            aGaugeRange5.Color = System.Drawing.Color.Empty;
            aGaugeRange5.EndValue = 0F;
            aGaugeRange5.InnerRadius = 1;
            aGaugeRange5.InRange = false;
            aGaugeRange5.Name = "GaugeRange2";
            aGaugeRange5.OuterRadius = 2;
            aGaugeRange5.StartValue = 0F;
            aGaugeRange6.Color = System.Drawing.Color.Empty;
            aGaugeRange6.EndValue = 0F;
            aGaugeRange6.InnerRadius = 1;
            aGaugeRange6.InRange = false;
            aGaugeRange6.Name = "GaugeRange3";
            aGaugeRange6.OuterRadius = 2;
            aGaugeRange6.StartValue = 0F;
            this.aGauge1.GaugeRanges.Add(aGaugeRange4);
            this.aGauge1.GaugeRanges.Add(aGaugeRange5);
            this.aGauge1.GaugeRanges.Add(aGaugeRange6);
            this.aGauge1.Location = new System.Drawing.Point(328, 233);
            this.aGauge1.Margin = new System.Windows.Forms.Padding(4);
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
            this.aGauge1.Size = new System.Drawing.Size(315, 249);
            this.aGauge1.TabIndex = 0;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            this.aGauge1.ValueInRangeChanged += new System.EventHandler<System.Windows.Forms.ValueInRangeChangedEventArgs>(this.aGauge1_ValueInRangeChanged);
            // 
            // aGauge2
            // 
            this.aGauge2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.aGauge2.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge2.BaseArcRadius = 80;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 270;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Center = new System.Drawing.Point(110, 100);
            this.aGauge2.Location = new System.Drawing.Point(16, 233);
            this.aGauge2.Margin = new System.Windows.Forms.Padding(4);
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
            this.aGauge2.Size = new System.Drawing.Size(315, 249);
            this.aGauge2.TabIndex = 0;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 0F;
            this.aGauge2.ValueInRangeChanged += new System.EventHandler<System.Windows.Forms.ValueInRangeChangedEventArgs>(this.aGauge1_ValueInRangeChanged);
            // 
            // ButtonStop
            // 
            this.ButtonStop.BackColor = System.Drawing.SystemColors.InfoText;
            this.ButtonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonStop.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonStop.Location = new System.Drawing.Point(920, 63);
            this.ButtonStop.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(131, 41);
            this.ButtonStop.TabIndex = 20;
            this.ButtonStop.Text = "STOP";
            this.ButtonStop.UseVisualStyleBackColor = false;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click_1);
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.SystemColors.InfoText;
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonStart.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonStart.Location = new System.Drawing.Point(920, 15);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(131, 41);
            this.ButtonStart.TabIndex = 19;
            this.ButtonStart.Text = "START";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(1024, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "s";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(936, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "m";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            // 
            // BoxSec
            // 
            this.BoxSec.AutoSize = true;
            this.BoxSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxSec.Location = new System.Drawing.Point(988, 155);
            this.BoxSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BoxSec.Name = "BoxSec";
            this.BoxSec.Size = new System.Drawing.Size(27, 29);
            this.BoxSec.TabIndex = 26;
            this.BoxSec.Text = "0";
            this.BoxSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxSec.UseMnemonic = false;
            // 
            // BoxMin
            // 
            this.BoxMin.AutoSize = true;
            this.BoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxMin.Location = new System.Drawing.Point(900, 155);
            this.BoxMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BoxMin.Name = "BoxMin";
            this.BoxMin.Size = new System.Drawing.Size(27, 29);
            this.BoxMin.TabIndex = 25;
            this.BoxMin.Text = "0";
            this.BoxMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxMin.UseMnemonic = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(887, 111);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Czas symulacji";
            // 
            // TimerCzas
            // 
            this.TimerCzas.Tick += new System.EventHandler(this.TimerCzas_Tick_1);
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
            this.chart1.Location = new System.Drawing.Point(16, 20);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
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
            this.chart1.Size = new System.Drawing.Size(468, 165);
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            // 
            // BoxRPM
            // 
            this.BoxRPM.AutoSize = true;
            this.BoxRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxRPM.Location = new System.Drawing.Point(576, 38);
            this.BoxRPM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BoxRPM.Name = "BoxRPM";
            this.BoxRPM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BoxRPM.Size = new System.Drawing.Size(69, 29);
            this.BoxRPM.TabIndex = 30;
            this.BoxRPM.Text = "2000";
            this.BoxRPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxRPM.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(669, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "RPM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(887, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 48);
            this.button1.TabIndex = 32;
            this.button1.Text = "Wyświetl charakterystyki";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxRPM);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxSec);
            this.Controls.Add(this.BoxMin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.aGauge2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BoxSec;
        private System.Windows.Forms.Label BoxMin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer TimerCzas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        //
        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.AGauge aGauge2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label BoxRPM;
    }
}