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
        public static List<double> xchart2 = new List<double>(); // charakterystyka V(RPM) 
        public static List<double> ychart2 = new List<double>(); // charakterystyka V(RPM)
        public int _ticks;
        public static int RPM = 1000; // revolutions per minute
        public static double RPMV; // prędkość wybranego koła zębatego w skrzyni biegów
        public static int Gear = 0;
        public static int KPH = 0;// kilometers per hour
        public static double GR = 1.5; // Gear ratio
        public static int MinRPM = 1000;
        public static double Diameter = 40;// w cm
        public static double _change = 0;
        public static int speed = 1;
        public static int MaxSpeed = 260;
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
        public void loop()//pętla wykonywana po tickerze
        {
            ControlChart();
            ControlGear();
            _CheckSpeed();
            AddPointsToVchart();
            if (Form2.chart2 != null)
                Form2.chart2.Series["Series1"].Points.DataBindXY(xchart2, ychart2);
        }

        public void _CheckSpeed()//sprawdza prędkość
        {
            if (BoxDownGear.Text == "N") RPMV = 0;
            else RPMV = Convert.ToDouble(RPM / (20 / Math.Pow(GR, Gear - 1)) / 60 );//ilość obrotów na sekunde i w zależności od biegu
            double obwod = (2 * Math.PI* Diameter/2)/100;//obwód koła w metrach
            speed = Convert.ToInt32( RPMV*obwod*3.6);//prędkość policzona poprzez obrót koła i przeliczona na km/h
            BoxDownSpeed.Text = speed.ToString();

        }

        public void ControlChart()//sprawdza charakterystykę
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

        public void AddPointsToVchart()
        {
            xchart2.Add(double.Parse(BoxDownSpeed.Text));
            ychart2.Add(RPM);
        }

        public void ControlGear()//Sprawdza biegi
        {
            if (Form2.Praca == true)//wykowywana jednorazowo po rozpoczeciu symulacji lub pod koniec
            {
                if (BoxDownGear.Text == "N") { Gear = 1; RPM = 1000; }
                BoxDownGear.Text = Gear.ToString();
            }
            else
            {
                BoxDownGear.Text = "N"; RPM = 1000;
            }
            Engine();
            if (RadioButtonOn.Checked == true)//Jeżeli skyrznia biegów jest wykorzystywana 
            {
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
                                RPM = Convert.ToInt32(RPM / GR);
                            }
                            else if (CheckEko() == -1)
                            {
                                --Gear;
                                RPM = Convert.ToInt32(RPM * GR);
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Praca w trybie normalnym");
                        BoxDownPraca.Text = "Normal";
                        if (Form2.Praca == true)
                        {
                            if (CheckNormal() == 1)
                            {
                                ++Gear;
                                RPM = Convert.ToInt32(RPM / GR);
                            }
                            else if (CheckNormal() == -1)
                            {
                                --Gear;
                                RPM = Convert.ToInt32(RPM * GR);
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Praca w trybie sport");
                        BoxDownPraca.Text = "Sport";
                        if (Form2.Praca == true)
                        {
                            if (CheckSport() == 1)
                            {
                                ++Gear;
                                RPM = Convert.ToInt32(RPM / GR);
                            }
                            else if (CheckSport() == -1)
                            {
                                --Gear;
                                RPM = Convert.ToInt32(RPM * GR);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Błąd pracy skrzyni biegów");
                        break;
                }
            }
        }
        public void Engine()//praca silnika
        {
            //funkcja silnika
            _change= 1500 * (1 + (0.05 * BarUchyl.Value)) - 1650 -(RPM*RPM*0.505/10000) - (BarObc.Value*10);
            if (_change < 0)//zaimplementowanie momentu bezwładności
            {
                _change = _change * (Convert.ToDouble(MinRPM) / Convert.ToDouble(RPM)) * 1.5;
            }
            else
            {
                _change = _change / (Convert.ToDouble(MinRPM) / Convert.ToDouble(RPM)) / 15;
            }
            RPM = RPM + Convert.ToInt32(_change);//zmiana obrotów
            if (RPM < MinRPM) RPM = MinRPM;//aby silnik nie malał do 0 stałe trzymanie 1000 RPM
            
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
        private void timer1_Tick(object sender, EventArgs e)//zapewnia pętle
        {
            _ticks++;
            if (_ticks >= 5)
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
        
        private void BarSzybkosc_Scroll(object sender, EventArgs e)//szybkość symulacji
        {
            if (BarSzybkosc.Value < 0)
            {
                BoxDownSzybkosc.Text = "1/" + (-1*BarSzybkosc.Value * 2).ToString()+"x";
                TimerTick.Interval = 50 * (-1 * BarSzybkosc.Value * 2);
            }
            else if (BarSzybkosc.Value > 0)
            {
                BoxDownSzybkosc.Text = (BarSzybkosc.Value * 2).ToString()+"x";
                TimerTick.Interval = 50 / BarSzybkosc.Value * 2;
            }
            else if (BarSzybkosc.Value == 0)
            {
                BoxDownSzybkosc.Text = "1x";
                TimerTick.Interval = 50;

            }
        }
    }
    
}