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

    public partial class View : Form
    {
        //f1
        public static double[] xchart = new double[2];
        public static double[] ychart = new double[2];
        public static List<double> xchart2 = new List<double>(); // charakterystyka V(RPM) 
        public static List<double> ychart2 = new List<double>(); // charakterystyka V(RPM)
        public static List<double> y2chart2 = new List<double>(); // charakterystyka V(RPM)
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

        public static Boolean Praca = false;
        public static int _time;
        public static int _sec = 0;
        public static int _min = 0;
        public static Chart chart2 = null;
        public View()
        {
            InitializeComponent();
            Start();
            TimerTick.Start();
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
            {
                Form2.chart2.Series["RPM"].Points.DataBindXY(xchart2, ychart2);
                Form2.chart2.Series["V"].Points.DataBindXY(xchart2, y2chart2);
            }
        }

        public void _CheckSpeed()//sprawdza prędkość
        {
            if (BoxDownGear.Text == "N") RPMV = 0;
            else RPMV = Convert.ToDouble(RPM / (15 / Math.Pow(GR, Gear - 1)) / 60);//ilość obrotów na sekunde i w zależności od biegu
            double obwod = (2 * Math.PI * Diameter / 2) / 100;//obwód koła w metrach
            speed = Convert.ToInt32(RPMV * obwod * 3.6);//prędkość policzona poprzez obrót koła i przeliczona na km/h
            BoxDownSpeed.Text = speed.ToString();

        }

        public void ControlChart()//sprawdza charakterystykę
        {
            double x1 = 0;
            double x2 = 10;
            double y2 = 0;
            if (BarObc.Value != 50) { y2 = (x2 * (BarObc.Value)) / 10; }
            xchart[0] = x1;//stale parametry x
            xchart[1] = x2;
            ychart[0] = x1;
            ychart[1] = y2;
        }

        public void AddPointsToVchart()  //dodanie punktów do wykresu RPM(V)
        {
            if (Form2.Praca == true)
            {
                int xtime = Form2._sec;
                if (Form2._min > 0)
                {
                    xtime += Form2._min * 60;
                }
                xchart2.Add(xtime);
                ychart2.Add(RPM);
                y2chart2.Add(double.Parse(BoxDownSpeed.Text));
            }

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
            _change = 1500 * (1 + (0.035 * BarUchyl.Value)) - 1650 - (RPM * RPM * 0.505 / 10000) - (BarObc.Value * 10);
            if (_change < 0)//zaimplementowanie momentu bezwładmości
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
            if (RPM < 3000 && BarUchyl.Value > 30 && Gear > 1) return -1;//szybkie przyspieszanie "knock down"
            if (RPM > 5000 && BarUchyl.Value > 30 && Gear < 6) return 1;//wbijanie wyższego biegów w przyspieszaniu
            if (RPM < 1600 && Gear > 1) return -1;//normalna praca
            if (RPM > 2300 && Gear < 6 && BarUchyl.Value < 30) return 1;//normalna praca
            return 0;
        }
        public int CheckNormal()//jeżeli trzeba zmienić bieg na wyższy wstaw 1 jeżeli nie 0 jeżeli na niższy to -1
        {
            if (RPM < 3000 && BarUchyl.Value > 30 && Gear > 1) return -1;//szybkie przyspieszanie "knock down"
            if (RPM > 6000 && BarUchyl.Value > 30 && Gear < 6) return 1;//wbijanie wyższego biegów w przyspieszaniu
            if (RPM < 2100 && Gear > 1) return -1;//normalna praca
            if (RPM > 3100 && Gear < 6 && BarUchyl.Value < 30) return 1;//normalna praca
            return 0;
        }
        public int CheckSport()//jeżeli trzeba zmienić bieg na wyższy wstaw 1 jeżeli nie 0 jeżeli na niższy to -1
        {
            if (RPM < 4500 && Gear > 1) return -1;//normalna praca
            if (RPM > 6500 && Gear < 6) return 1;//normalna praca
            return 0;
        }
        private void timer1_Tick(object sender, EventArgs e)//zapewnia pętle
        {

        }

        private void BarObc_Scroll(object sender, EventArgs e)
        {
            if (BarObc.Value == 50) { BoxDownObc.Text = "0" + "°"; }
            else if (BarObc.Value != 50) { BoxDownObc.Text = (BarObc.Value).ToString() + "°"; }
            //else if (BarObc.Value < 50) { BoxDownObc.Text = (BarObc.Value-50).ToString() + "°"; }
        }

        private void BarUchyl_Scroll(object sender, EventArgs e)
        {
            BoxDownUchyl.Text = (BarUchyl.Value * 2).ToString() + "°";
        }

        private void BarSzybkosc_Scroll(object sender, EventArgs e)//szybkość symulacji
        {

        }

        private void TimerCzas_Tick_1(object sender, EventArgs e)
        {

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

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            TimerCzas.Start();
            Praca = true;
            Form1.xchart2.Clear();
            Form1.ychart2.Clear();
            Form1.y2chart2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }

}

