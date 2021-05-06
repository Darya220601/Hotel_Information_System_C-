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
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNameText.Text == "Darya2206" && PasswordText.Text == "280320")

            {

                this.Hide();

               RegClients f = new RegClients();

                f.Show();

            }

            else

            {

                UserNameText.Text = "";

                PasswordText.Text = "";

                MessageBox.Show("Error!"+"\n"+"Wrong Login or Password!"+"\n"+"Check,please...");

            }
        }
    }
}
