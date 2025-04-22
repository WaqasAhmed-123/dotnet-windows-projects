using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();

            GenerateCoulmnChat();
            GenerateBarChat();
            GeneratePieChart();
            GenerateLineChart();
        }

        private void GenerateCoulmnChat()
        {
            columnChart.Titles.Add("Salary Chart");
            //ge to the series collection to change the chart types
            columnChart.Series["Salary"].Points.AddXY("Waqas ahmed", "50");
            columnChart.Series["Salary"].Points.AddXY("Ali Ahmed", "80");
            columnChart.Series["Salary"].Points.AddXY("Qaiser Javed", "70");
            columnChart.Series["Salary"].Points.AddXY("Khizar Khan", "10");
            columnChart.Series["Salary"].Points.AddXY("Sajid Ali", "85");
            columnChart.Series["Salary"].IsValueShownAsLabel = true; // value will be show as label
        }

        private void GeneratePieChart()
        {
            string[] xAxis = { "Banana", "Mango", "Apple" };
            double[] Percentage = { 40, 30, 30 }; //sum must be equal to 100
            pieChart.Titles.Add("Pie Chart");
            pieChart.Series[0].Points.DataBindXY(xAxis, Percentage);
            pieChart.Series[0].Points[0].Color = Color.Yellow;
            pieChart.Series[0].Points[0].ToolTip = "this is banana."; //custom tooltip
            pieChart.Series[0].Points[1].Color = Color.Orange;
            pieChart.Series[0].Points[1].ToolTip = "this is mango."; //custom tooltip
            pieChart.Series[0].Points[2].Color = Color.Red;
            pieChart.Series[0].Points[2].ToolTip = "this is apple."; //custom tooltip
            pieChart.Series["Expense"].IsValueShownAsLabel = true; // value will be show as label
        }

        private void GenerateLineChart()
        {
            string[] xAxis = { "Banana", "Mango", "Apple" };
            double[] Percentage = { 40, 30, 30 }; 
            lineChart.Titles.Add("Line Chart");
            lineChart.Series[0].Points.DataBindXY(xAxis, Percentage);
            lineChart.Series[0].Points[0].Color = Color.Yellow;
            lineChart.Series[0].Points[0].ToolTip = "this is banana."; //custom tooltip
            lineChart.Series[0].Points[1].Color = Color.Orange;
            lineChart.Series[0].Points[1].ToolTip = "this is mango."; //custom tooltip
            lineChart.Series[0].Points[2].Color = Color.Red;
            lineChart.Series[0].Points[2].ToolTip = "this is apple."; //custom tooltip
            lineChart.Series["Fruit"].IsValueShownAsLabel = true; // value will be show as label
        }

        private void GenerateBarChat()
        {
            string[] xAxis = { "Waqas Admed", "Ali Ahmed", "Qaiser Javed", "Khizar Khan", "Sajad Ali" };
            double[] salaries = { 40, 30, 30, 20, 87 };

            barChart.Titles.Add("Salary Chart");
            barChart.Series["Salary"].IsValueShownAsLabel = true; // value will be show as label
            barChart.Series[0].Points.DataBindXY(xAxis, salaries);
            barChart.Series[0].Points[0].Color = Color.Yellow;
            barChart.Series[0].Points[0].ToolTip = "this is first salary."; //custom tooltip
            barChart.Series[0].Points[1].Color = Color.Orange;
            barChart.Series[0].Points[2].Color = Color.Red;
            barChart.Series[0].Points[3].Color = Color.Green;
            barChart.Series[0].Points[4].Color = Color.Pink;
        }

    }
}
