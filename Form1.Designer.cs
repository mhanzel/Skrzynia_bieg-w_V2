namespace Skrzynia_biegów_V2
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
            this.BarUchyl = new System.Windows.Forms.TrackBar();
            this.BoxUpUchyl = new System.Windows.Forms.TextBox();
            this.BoxUpObc = new System.Windows.Forms.TextBox();
            this.BarObc = new System.Windows.Forms.TrackBar();
            this.BoxUpPraca = new System.Windows.Forms.TextBox();
            this.BarPraca = new System.Windows.Forms.TrackBar();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BoxDownGear = new System.Windows.Forms.TextBox();
            this.BoxDownSpeed = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.TimerTick = new System.Windows.Forms.Timer(this.components);
            this.BoxDownUchyl = new System.Windows.Forms.Label();
            this.BoxDownObc = new System.Windows.Forms.Label();
            this.BoxDownPraca = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonOFF = new System.Windows.Forms.RadioButton();
            this.RadioButtonOn = new System.Windows.Forms.RadioButton();
            this.BoxDownSzybkosc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BarSzybkosc = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.BarUchyl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarObc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarPraca)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarSzybkosc)).BeginInit();
            this.SuspendLayout();
            // 
            // BarUchyl
            // 
            this.BarUchyl.Location = new System.Drawing.Point(665, 38);
            this.BarUchyl.Maximum = 45;
            this.BarUchyl.Name = "BarUchyl";
            this.BarUchyl.Size = new System.Drawing.Size(104, 45);
            this.BarUchyl.TabIndex = 0;
            this.BarUchyl.Scroll += new System.EventHandler(this.BarUchyl_Scroll);
            // 
            // BoxUpUchyl
            // 
            this.BoxUpUchyl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoxUpUchyl.Location = new System.Drawing.Point(665, 12);
            this.BoxUpUchyl.Name = "BoxUpUchyl";
            this.BoxUpUchyl.ReadOnly = true;
            this.BoxUpUchyl.Size = new System.Drawing.Size(123, 20);
            this.BoxUpUchyl.TabIndex = 1;
            this.BoxUpUchyl.Text = "Uchył przepustnicy";
            // 
            // BoxUpObc
            // 
            this.BoxUpObc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoxUpObc.Location = new System.Drawing.Point(665, 126);
            this.BoxUpObc.Name = "BoxUpObc";
            this.BoxUpObc.ReadOnly = true;
            this.BoxUpObc.Size = new System.Drawing.Size(123, 20);
            this.BoxUpObc.TabIndex = 3;
            this.BoxUpObc.Text = "Regulacja obciązenia";
            // 
            // BarObc
            // 
            this.BarObc.Location = new System.Drawing.Point(665, 152);
            this.BarObc.Maximum = 30;
            this.BarObc.Minimum = -30;
            this.BarObc.Name = "BarObc";
            this.BarObc.Size = new System.Drawing.Size(104, 45);
            this.BarObc.TabIndex = 2;
            this.BarObc.Scroll += new System.EventHandler(this.BarObc_Scroll);
            // 
            // BoxUpPraca
            // 
            this.BoxUpPraca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoxUpPraca.Location = new System.Drawing.Point(665, 238);
            this.BoxUpPraca.Name = "BoxUpPraca";
            this.BoxUpPraca.ReadOnly = true;
            this.BoxUpPraca.Size = new System.Drawing.Size(123, 20);
            this.BoxUpPraca.TabIndex = 5;
            this.BoxUpPraca.Text = "Tryb pracy";
            // 
            // BarPraca
            // 
            this.BarPraca.LargeChange = 1;
            this.BarPraca.Location = new System.Drawing.Point(665, 264);
            this.BarPraca.Maximum = 3;
            this.BarPraca.Minimum = 1;
            this.BarPraca.Name = "BarPraca";
            this.BarPraca.Size = new System.Drawing.Size(104, 45);
            this.BarPraca.TabIndex = 4;
            this.BarPraca.Value = 1;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(531, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox4.Size = new System.Drawing.Size(108, 23);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Bieg";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BoxDownGear
            // 
            this.BoxDownGear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoxDownGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxDownGear.Location = new System.Drawing.Point(565, 38);
            this.BoxDownGear.Name = "BoxDownGear";
            this.BoxDownGear.ReadOnly = true;
            this.BoxDownGear.Size = new System.Drawing.Size(42, 62);
            this.BoxDownGear.TabIndex = 7;
            this.BoxDownGear.Text = "N";
            // 
            // BoxDownSpeed
            // 
            this.BoxDownSpeed.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoxDownSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxDownSpeed.Location = new System.Drawing.Point(531, 152);
            this.BoxDownSpeed.Name = "BoxDownSpeed";
            this.BoxDownSpeed.ReadOnly = true;
            this.BoxDownSpeed.Size = new System.Drawing.Size(100, 62);
            this.BoxDownSpeed.TabIndex = 9;
            this.BoxDownSpeed.Text = "000";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox7.Location = new System.Drawing.Point(531, 126);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(108, 23);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "Prędkość";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimerTick
            // 
            this.TimerTick.Interval = 50;
            this.TimerTick.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BoxDownUchyl
            // 
            this.BoxDownUchyl.AutoSize = true;
            this.BoxDownUchyl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxDownUchyl.Location = new System.Drawing.Point(708, 76);
            this.BoxDownUchyl.Name = "BoxDownUchyl";
            this.BoxDownUchyl.Size = new System.Drawing.Size(21, 24);
            this.BoxDownUchyl.TabIndex = 14;
            this.BoxDownUchyl.Text = "0";
            this.BoxDownUchyl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxDownUchyl.UseMnemonic = false;
            // 
            // BoxDownObc
            // 
            this.BoxDownObc.AutoSize = true;
            this.BoxDownObc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxDownObc.Location = new System.Drawing.Point(708, 190);
            this.BoxDownObc.Name = "BoxDownObc";
            this.BoxDownObc.Size = new System.Drawing.Size(21, 24);
            this.BoxDownObc.TabIndex = 15;
            this.BoxDownObc.Text = "0";
            this.BoxDownObc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxDownObc.UseMnemonic = false;
            // 
            // BoxDownPraca
            // 
            this.BoxDownPraca.AutoSize = true;
            this.BoxDownPraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxDownPraca.Location = new System.Drawing.Point(679, 299);
            this.BoxDownPraca.Name = "BoxDownPraca";
            this.BoxDownPraca.Size = new System.Drawing.Size(79, 24);
            this.BoxDownPraca.TabIndex = 16;
            this.BoxDownPraca.Text = "SPORT";
            this.BoxDownPraca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxDownPraca.UseMnemonic = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonOFF);
            this.groupBox1.Controls.Add(this.RadioButtonOn);
            this.groupBox1.Location = new System.Drawing.Point(668, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 77);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Praca skrzyni";
            // 
            // RadioButtonOFF
            // 
            this.RadioButtonOFF.AutoSize = true;
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
            this.RadioButtonOn.Location = new System.Drawing.Point(7, 18);
            this.RadioButtonOn.Name = "RadioButtonOn";
            this.RadioButtonOn.Size = new System.Drawing.Size(57, 17);
            this.RadioButtonOn.TabIndex = 0;
            this.RadioButtonOn.TabStop = true;
            this.RadioButtonOn.Text = "Włącz";
            this.RadioButtonOn.UseVisualStyleBackColor = true;
            // 
            // BoxDownSzybkosc
            // 
            this.BoxDownSzybkosc.AutoSize = true;
            this.BoxDownSzybkosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoxDownSzybkosc.Location = new System.Drawing.Point(425, 79);
            this.BoxDownSzybkosc.Name = "BoxDownSzybkosc";
            this.BoxDownSzybkosc.Size = new System.Drawing.Size(32, 24);
            this.BoxDownSzybkosc.TabIndex = 20;
            this.BoxDownSzybkosc.Text = "1x";
            this.BoxDownSzybkosc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxDownSzybkosc.UseMnemonic = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(382, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Szybkość symulacji";
            // 
            // BarSzybkosc
            // 
            this.BarSzybkosc.LargeChange = 1;
            this.BarSzybkosc.Location = new System.Drawing.Point(382, 41);
            this.BarSzybkosc.Maximum = 2;
            this.BarSzybkosc.Minimum = -2;
            this.BarSzybkosc.Name = "BarSzybkosc";
            this.BarSzybkosc.Size = new System.Drawing.Size(104, 45);
            this.BarSzybkosc.TabIndex = 18;
            this.BarSzybkosc.Scroll += new System.EventHandler(this.BarSzybkosc_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoxDownSzybkosc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BarSzybkosc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BoxDownPraca);
            this.Controls.Add(this.BoxDownObc);
            this.Controls.Add(this.BoxDownUchyl);
            this.Controls.Add(this.BoxDownSpeed);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.BoxDownGear);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.BoxUpPraca);
            this.Controls.Add(this.BarPraca);
            this.Controls.Add(this.BoxUpObc);
            this.Controls.Add(this.BarObc);
            this.Controls.Add(this.BoxUpUchyl);
            this.Controls.Add(this.BarUchyl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarUchyl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarObc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarPraca)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarSzybkosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar BarUchyl;
        private System.Windows.Forms.TextBox BoxUpUchyl;
        private System.Windows.Forms.TextBox BoxUpObc;
        private System.Windows.Forms.TrackBar BarObc;
        private System.Windows.Forms.TextBox BoxUpPraca;
        private System.Windows.Forms.TrackBar BarPraca;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox BoxDownGear;
        private System.Windows.Forms.TextBox BoxDownSpeed;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Timer TimerTick;
        private System.Windows.Forms.Label BoxDownUchyl;
        private System.Windows.Forms.Label BoxDownObc;
        private System.Windows.Forms.Label BoxDownPraca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButtonOFF;
        private System.Windows.Forms.RadioButton RadioButtonOn;
        private System.Windows.Forms.Label BoxDownSzybkosc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar BarSzybkosc;
    }
}

