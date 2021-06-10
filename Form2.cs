using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Skrzynia_biegów_V2
{
    
    public partial class Form2 : Form
    {
        public static Boolean Praca = false;
        public int _time;
        public int _sec = 0;
        public int _min = 0;
        public Form2()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisX.Maximum = 11;
            chart1.ChartAreas[0].AxisX.Minimum = -1;
            chart1.ChartAreas[0].AxisY.Maximum = 31;
            chart1.ChartAreas[0].AxisY.Minimum = -31;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
            chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            chart1.Series["Series1"].Points.DataBindXY(Form1.xchart, Form1.ychart);
            BoxRPM.Text = "0";
        }
        
        
        private void ButtonStart_Click_1(object sender, EventArgs e)
        {
            TimerCzas.Start();
            Praca = true;
        }

        private void ButtonStop_Click_1(object sender, EventArgs e)
        {
            TimerCzas.Stop();
            _sec = 0;
            _min = 0;
            BoxSec.Text = _sec.ToString();
            BoxMin.Text = _min.ToString();
            Praca = false;
            BoxRPM.Text = "0";

        }

        private void TimerCzas_Tick_1(object sender, EventArgs e)
        {
            _time++;
            if (_time == 10)
            {
                ++_sec;
                BoxSec.Text = _sec.ToString();
                if (_sec == 61)
                {
                    ++_min;
                    BoxMin.Text = _min.ToString();
                    _sec = 0;
                    BoxSec.Text = _sec.ToString();
                }
                _time = 0;
            }
            if (_time > 2)
            {
                chart1.Series["Series1"].Points.DataBindXY(Form1.xchart, Form1.ychart);
                BoxRPM.Text = Form1.RPM.ToString();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
