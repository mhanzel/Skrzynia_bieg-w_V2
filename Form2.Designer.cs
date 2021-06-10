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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStop
            // 
            this.ButtonStop.BackColor = System.Drawing.SystemColors.InfoText;
            this.ButtonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonStop.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonStop.Location = new System.Drawing.Point(690, 51);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(98, 33);
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
            this.ButtonStart.Location = new System.Drawing.Point(690, 12);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(98, 33);
            this.ButtonStart.TabIndex = 19;
            this.ButtonStart.Text = "START";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(768, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "s";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(702, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "m";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            // 
            // BoxSec
            // 
            this.BoxSec.AutoSize = true;
            this.BoxSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxSec.Location = new System.Drawing.Point(741, 126);
            this.BoxSec.Name = "BoxSec";
            this.BoxSec.Size = new System.Drawing.Size(21, 24);
            this.BoxSec.TabIndex = 26;
            this.BoxSec.Text = "0";
            this.BoxSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxSec.UseMnemonic = false;
            // 
            // BoxMin
            // 
            this.BoxMin.AutoSize = true;
            this.BoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxMin.Location = new System.Drawing.Point(675, 126);
            this.BoxMin.Name = "BoxMin";
            this.BoxMin.Size = new System.Drawing.Size(21, 24);
            this.BoxMin.TabIndex = 25;
            this.BoxMin.Text = "0";
            this.BoxMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxMin.UseMnemonic = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(665, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(123, 20);
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
            this.chart1.Location = new System.Drawing.Point(12, 16);
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
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            // 
            // BoxRPM
            // 
            this.BoxRPM.AutoSize = true;
            this.BoxRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxRPM.Location = new System.Drawing.Point(432, 31);
            this.BoxRPM.Name = "BoxRPM";
            this.BoxRPM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BoxRPM.Size = new System.Drawing.Size(54, 24);
            this.BoxRPM.TabIndex = 30;
            this.BoxRPM.Text = "2000";
            this.BoxRPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxRPM.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(502, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "RPM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private System.Windows.Forms.Label BoxRPM;
        private System.Windows.Forms.Label label2;
    }
}