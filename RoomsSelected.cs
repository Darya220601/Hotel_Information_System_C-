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
    public partial class RoomsSelected : Form
    {
        List<Room> roomsData;
        public RoomsSelected(List<Room> r)
        {
            roomsData = r;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RoomsSelected_Load(object sender, EventArgs e)
        {
            roomBindingSource.DataSource = roomsData;
            int countOfClient = 0;
            foreach(Room  r in roomsData)
            {
                if (r.isFree == false)
                {
                    countOfClient++;
                }
            }
            LabelCount.Text = "Кол-во клиентов = " + countOfClient.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelCount_Click(object sender, EventArgs e)
        {

        }
    }
}
