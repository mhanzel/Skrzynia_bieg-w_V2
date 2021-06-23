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
        public static int _time;
        public static int _sec = 0;
        public static int _min = 0;
        public static Chart chart2 = null;
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
            Form1.xchart2.Clear();
            Form1.ychart2.Clear();
            Form1.y2chart2.Clear();
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
            aGauge1.Value = 0;
            aGauge2.Value = 0;
           
        }

        private void TimerCzas_Tick_1(object sender, EventArgs e)
        {
            _time++;
            if (_time == 10)//zegar
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
            if (_time > 1)//loopa do wstawiania zmiennych
            {
                chart1.Series["Series1"].Points.DataBindXY(Form1.xchart, Form1.ychart);
                BoxRPM.Text = Form1.RPM.ToString();
                aGauge1.Value = Form1.RPM;
            }
        }
        private void aGauge1_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            chart2 = form3.chart2;
        }
    }
}
