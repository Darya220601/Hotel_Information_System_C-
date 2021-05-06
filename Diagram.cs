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
    public partial class Diagram : Form
    {
        int countOfS;
        int countOfD;
        int countOfF;
        public Diagram(int cS, int cD, int cF)
        {
            InitializeComponent();
            countOfS = cS;
            countOfD = cD;
            countOfF = cF;
        }

        private void Diagram_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("Информация о занятых номерах");
            chart1.Series["s1"].IsValueShownAsLabel = true;
            chart1.Series["s1"].Points.AddXY("Count of single rooms", countOfS);
            chart1.Series["s1"].Points.AddXY("Count of family rooms", countOfF);
            chart1.Series["s1"].Points.AddXY("Count of double rooms", countOfD);
        }
    }
}
