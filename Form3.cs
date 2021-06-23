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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            chart2.Series[0].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chart2.Series[1].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            chart2.ChartAreas[0].AxisX.Title = "czas";
            chart2.ChartAreas[0].AxisY.Title = "RPM, V";
            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.Series["RPM"].Points.DataBindXY(Form1.xchart2, Form1.ychart2);
            chart2.Series["V"].Points.DataBindXY(Form1.xchart2, Form1.y2chart2);
        }
                
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
        /*
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            chart2.Series["Series1"].Points.DataBindXY(Form1.xchart2, Form1.ychart2);   
        }
        */
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.chart2 = null;
        }
    }
}
