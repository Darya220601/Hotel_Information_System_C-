using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace HotelManagementSystem
{
    public partial class Report : Form
    {
        
        List<Client> clientsData;
        public Report(List<Client> clients)
        {
            InitializeComponent();
            clientsData = clients;
        }
       
        private void Report_Load(object sender, EventArgs e)
        {
            clientBindingSource.DataSource = clientsData;
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void построитьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
             SeriesCollection series = new SeriesCollection();
            ChartValues<Decimal> clientValues = new ChartValues<Decimal>();
            List<string> dates = new List<string>();
            List<DateTime> f = new List<DateTime>();
            Boolean b = false;
            foreach (Client c in clientBindingSource)
            {
                decimal total = c.TotalCost;
                foreach (DateTime g in f)
                {
                    if (c.DateofArival == g)
                    {
                        b = true;
                        break;

                    }
                }
                if (b)
                {
                    b = false;
                    continue;

                }
                else
                {
                    foreach (Client cl in clientBindingSource)
                    {
                        
                        if (cl.DateofArival == c.DateofArival)
                        {
                            total += cl.TotalCost;

                        }
                    }
                    clientValues.Add(total);
                    dates.Add(c.DateofArival.ToShortDateString());
                    f.Add(c.DateofArival);

                }
                
            }

            cartesianChart1.AxisX.Clear();

            cartesianChart1.AxisX.Add(new Axis()
            {
                Title = "Даты",
                Labels = dates
            });

            LineSeries clientLine = new LineSeries();
            clientLine.Title = "Клиент";
            clientLine.Values = clientValues;

            series.Add(clientLine);
            cartesianChart1.Series = series;
        }

        private void cartesianChart1_DataClick(object sender, ChartPoint chartPoint)
        {
            MessageBox.Show(chartPoint.X + " " + chartPoint.Y);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
