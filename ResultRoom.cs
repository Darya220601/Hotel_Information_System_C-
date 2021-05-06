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
    public partial class ResultRoom : Form
    {
        List<Room> roomsData;
        
        public ResultRoom(List<Room> room)
        {
            InitializeComponent();
            roomsData = room;
        }

        private void ResultRoom_Load(object sender, EventArgs e)
        {
            roomBindingSource.DataSource = roomsData;
            int s = 0;
            int d = 0;
            int f = 0;
            foreach(Room r in roomsData)
            {
                if(r.roomNumber>0 && r.roomNumber<101&& r.isFree == false)
                {
                    s++;
                }
                if (r.roomNumber > 100 && r.roomNumber < 201 && r.isFree == false)
                {
                    d++;
                }
                if (r.roomNumber > 200 && r.roomNumber < 301 && r.isFree == false)
                {
                    f++;
                }
            }
            textBox2.Text = s.ToString();
            textBox3.Text = d.ToString();
            textBox4.Text = f.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRooms_Click(object sender, EventArgs e)
        {
            List<Room> room = roomsData.FindAll(
delegate (Room room1)
{//анонимная функция для проверки условий выбора

   if (checkBoxType.Checked && textBoxRoomType.Text != "")
    {
        switch (textBoxRoomType.Text)
        {
            case Room.typeOne:
                if (room1.roomNumber > 100)
                {
                    return false;
                }
                break;
            case Room.typeTwo:
                if (room1.roomNumber<101 || room1.roomNumber>200)
                {
                    return false;
                }
                break;
            case Room.typeThree:
                if (room1.roomNumber < 201)
                {
                    return false;
                }
                break;
        }
    }
   if (checkBoxFree.Checked &&room1.isFree==false) return false;
    if (checkBoxNotFree.Checked && room1.isFree == true) return false;



    return true;


});

            RoomsSelected r = new RoomsSelected(room);
            r.Show();
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxRoomType.Text = comboBoxRoomType.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[dataGridView1.ColumnCount - 1];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                }
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex - 1].Cells[dataGridView1.CurrentCell.ColumnIndex];
               
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Конец Таблицы");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                }
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex + 1].Cells[dataGridView1.CurrentCell.ColumnIndex];
                
            }

            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Конец таблицы");
            }
        }
    }
}
