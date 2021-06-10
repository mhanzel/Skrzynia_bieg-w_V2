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
    public partial class Form1 : Form
    {
        double[] xchart = new double[2];
        double[] ychart = new double[2];
        private int _ticks;
        private int _time;
        private int _sec=0;
        private int _min=0;
        public Form1()
        {
            InitializeComponent();
            Start();
            TimerTick.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void Start()//element wykonywany raz na starcie programu
        {
            BoxDownObc.Text = BarObc.Value.ToString() + "%";
            BoxDownUchyl.Text = BarUchyl.Value.ToString() + "°";
            ControlGear();
            ControlChart();
            chart1.ChartAreas[0].AxisX.Maximum = 11;
            chart1.ChartAreas[0].AxisX.Minimum = -1;
            chart1.ChartAreas[0].AxisY.Maximum = 21;
            chart1.ChartAreas[0].AxisY.Minimum = -1;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
            chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;

        }
        public void loop()
        {
            ControlChart();
            ControlGear();
        }
        public void ControlChart()
        {
            double x1 = 0;
            double x2 = 10;
            double x22 =10;//parametr dodatowy
            double y2 = (x2+x22)* BarObc.Value/100;
            xchart[0] = x1;//stale parametry x
            xchart[1] = x2;
            ychart[0] = x1;
            ychart[1] = y2;
            chart1.Series["Series1"].Points.DataBindXY(xchart, ychart);
        }
        public void ControlGear()
        {
            switch (BarPraca.Value)
            {
                case 1:
                    Console.WriteLine("Praca w trybie ekonomicznym");
                    BoxDownPraca.Text = "Eko";
                    break;
                case 2:
                    Console.WriteLine("Praca w trybie normalnym");
                    BoxDownPraca.Text ="Normal";
                    break;
                case 3:
                    Console.WriteLine("Praca w trybie sport");
                    BoxDownPraca.Text ="Sport";
                    break;
                default:
                    Console.WriteLine("Błąd pracy silnika");
                    break;
            }
        }
        public void Engine()
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            if (_ticks == 5)
            {
                loop();
                _ticks = 0;
            }
        }

        private void BarObc_Scroll(object sender, EventArgs e)
        {
            BoxDownObc.Text = BarObc.Value.ToString()+"%";
        }

        private void BarUchyl_Scroll(object sender, EventArgs e)
        {
            BoxDownUchyl.Text = BarUchyl.Value.ToString()+ "°";
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            TimerCzas.Start();
        }

        private void TimerCzas_Tick(object sender, EventArgs e)
        {
            _time++;
            if (_time==10)
            {
                ++_sec;
                BoxSec.Text=_sec.ToString();
                if (_sec == 61)
                {
                    ++_min;
                    BoxMin.Text = _min.ToString();
                    _sec = 0;
                    BoxSec.Text = _sec.ToString();
                }
                _time = 0;
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            TimerCzas.Stop();
            _sec = 0;
            _min = 0;
            BoxSec.Text = _sec.ToString();
            BoxMin.Text = _min.ToString();
        }
    }
    
}
