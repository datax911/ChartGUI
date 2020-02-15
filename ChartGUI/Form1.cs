using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fillChart();
        }






        private void fillChart()
        {
            chart1.Series["Salary"].Points.AddXY("Vince", "50000");
            chart1.Series["Salary"].Points.AddXY("Paul", "45000");
            chart1.Series["Salary"].Points.AddXY("Pierre", "28000");
            chart1.Series["Salary"].Points.AddXY("Phil", "65000");

            chart1.Series["Salary"].Color = Color.PaleVioletRed;
            chart1.ChartAreas[0].AxisY.Maximum = 100000;
            chart1.ChartAreas[0].AxisY.Minimum = 10000;

            chart1.Series.Add("test");
            chart1.Series["test"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["test"].Points.AddXY("Bloops", "67000");
            chart1.Series["test"].Points.AddXY("sadf", "62000");
            chart1.Series["test"].Points.AddXY("xzcv", "63000");



            chart1.Titles.Add("Test1");
        }




    }
}
