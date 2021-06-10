using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skrzynia_biegów_V2
{
    public partial class Form1 : Form
    {
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
        public void Start()
        {
            BoxDownObc.Text = BarObc.Value.ToString() + "%";
            BoxDownUchyl.Text = BarUchyl.Value.ToString() + "°";
            ControlGear();
            ControlChart();
        }
        public void loop()
        {
            ControlChart();
            ControlGear();
        }
        public void ControlChart()
        {

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
