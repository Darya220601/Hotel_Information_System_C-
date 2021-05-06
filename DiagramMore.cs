using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class DiagramMore : Form
    {
        decimal s;
        decimal d;
        decimal f;
        public DiagramMore(decimal singleR, decimal doubleR, decimal familyR)
        {
            InitializeComponent();
            s = singleR;
            d = doubleR;
            f = familyR;
        }

        private void DiagramMore_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("Подробнеая информация по номерам");
            chart1.Series["k"].IsValueShownAsLabel = true;
            chart1.Series["k"].Points.AddXY("Доход с одноместных номеров", s);
            chart1.Series["k"].Points.AddXY("Доход с двуместных номеров", d);
            chart1.Series["k"].Points.AddXY("Доход с семейных номеров", f);
        }
    }
}
