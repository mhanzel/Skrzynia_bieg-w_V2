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
        public static double[] xchart = new double[2];
        public static double[] ychart = new double[2];
        public int _ticks;
        public static int RPM = 0; // revolutions per minute
        public static int Gear = 0;
        public static int KPH = 0;// kilometers per hour
        public static int GR = 2; // Gear ratio
        public Form f2;
        public Form1()
        {
            InitializeComponent();
            Start();
            TimerTick.Start();
            f2 = new Form2();
            f2.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void Start()//element wykonywany raz na starcie programu
        {
            if (BarObc.Value == 50) { BoxDownObc.Text = "0" + "°"; }
            else if (BarObc.Value != 50) { BoxDownObc.Text = (BarObc.Value).ToString() + "°"; }
            BoxDownUchyl.Text = BarUchyl.Value.ToString() + "°";
            ControlGear();
            ControlChart();
            
        }
        public void loop()
        {
            ControlChart();
            ControlGear();
            f2.Update();
        }
        public void ControlChart()
        {
            double x1 = 0;
            double x2 = 10;
            double y2 = 0;
            if(BarObc.Value != 50) { y2 = (x2 * (BarObc.Value))/10; }
            xchart[0] = x1;//stale parametry x
            xchart[1] = x2;
            ychart[0] = x1;
            ychart[1] = y2;
        }
        public void ControlGear()
        {
            if (Form2.Praca == true)
            {
                if (BoxGear.Text == "N"){Gear = 1; RPM = 2100;}
                BoxGear.Text = Gear.ToString();
            }
            else
            {
                BoxGear.Text = "N"; RPM = 0;
            }
                switch (BarPraca.Value)
            {
                
                case 1:
                    Console.WriteLine("Praca w trybie ekonomicznym");
                    BoxDownPraca.Text = "Eko";
                    if (Form2.Praca == true)
                    {
                        
                        if (CheckEko() == 1)
                        {
                            ++Gear;
                            RPM = RPM / GR;
                        }
                        else if (CheckEko() == -1)
                        {
                            --Gear;
                            RPM = RPM * GR;
                        }
                        Engine();
                    }
                    break;
                case 2:
                    Console.WriteLine("Praca w trybie normalnym");
                    BoxDownPraca.Text ="Normal";
                    if (Form2.Praca == true)
                    {
                        if (CheckNormal() == 1)
                        {
                            ++Gear;
                            RPM = RPM / GR;
                        }
                        else if (CheckNormal() == -1)
                        {
                            --Gear;
                            RPM = RPM * GR;
                        }
                        Engine();
                    }
                    break;
                case 3:
                    Console.WriteLine("Praca w trybie sport");
                    BoxDownPraca.Text ="Sport";
                    if (Form2.Praca == true)
                    {
                        if (CheckSport() == 1)
                        {
                            ++Gear;
                            RPM = RPM / GR;
                        }
                        else if (CheckSport() == -1)
                        {
                            --Gear;
                            RPM = RPM * GR;
                        }
                        Engine();
                    }
                    break;
                default:
                    Console.WriteLine("Błąd pracy silnika");
                    break;
            }
        }
        public void Engine()
        {
            if (BarUchyl.Value > 20 && BarUchyl.Value < 45) RPM+= 100;
            else if(BarUchyl.Value < 20 && BarUchyl.Value > 0) { RPM-= 100; }
            else if (BarUchyl.Value == 45) { RPM += 500; }
            else if (BarUchyl.Value == 0) { RPM -= 500; }
            if (RPM < 1500) RPM = 1500;
            if (RPM > 8000) RPM = 8000;
        }
        public int CheckEko()//jeżeli trzeba zmienić bieg na wyższy wstaw 1 jeżeli nie 0 jeżeli na niższy to -1
        {
            if (RPM < 2000 && Gear > 1) return -1;
            if (RPM > 4000 && Gear < 6) return 1;
            return 0;
        }
        public int CheckNormal()//jeżeli trzeba zmienić bieg na wyższy wstaw 1 jeżeli nie 0 jeżeli na niższy to -1
        {
            if (RPM < 2000 && Gear > 1) return -1;
            if (RPM > 5000 && Gear < 6) return 1;
            return 0; 
        }
        public int CheckSport()//jeżeli trzeba zmienić bieg na wyższy wstaw 1 jeżeli nie 0 jeżeli na niższy to -1
        {
            if (RPM < 2000 && Gear > 1) return -1;
            if (RPM > 6000 && Gear < 6) return 1;
            return 0; 
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
            if (BarObc.Value == 50) { BoxDownObc.Text = "0" + "°"; }
            else if (BarObc.Value != 50) { BoxDownObc.Text = (BarObc.Value).ToString() + "°"; }
            //else if (BarObc.Value < 50) { BoxDownObc.Text = (BarObc.Value-50).ToString() + "°"; }
        }

        private void BarUchyl_Scroll(object sender, EventArgs e)
        {
            BoxDownUchyl.Text = BarUchyl.Value.ToString()+ "°";
        }
    }
    
}
