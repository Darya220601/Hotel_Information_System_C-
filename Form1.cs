using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace HotelManagementSystem
{
    public partial class RegClients : Form
    {

        public static Boolean ExceptErr = true;
        string fileName = "";
        public static List<Client> clientData = new List<Client>();
        public RegClients()
        {
            InitializeComponent();
            clientBindingSource.DataSource = clientData;

            dataGridView1.DataError += new DataGridViewDataErrorEventHandler(DataGridView1_DataError);


        }

        public static Boolean IsDataGridViewEmpty(DataGridView dataGridView)
        {

            bool isEmpty = false;
            try
            {
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {

                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {



                        if (dataGridView.Rows[i].Cells[j].Value == DBNull.Value
                         || String.IsNullOrWhiteSpace(dataGridView.Rows[i].Cells[j].Value.ToString()) || (dataGridView.Rows[i].Cells[j].Value == null) || (string.IsNullOrEmpty(dataGridView.Rows[i].Cells[j].Value.ToString())))
                        {

                            isEmpty = true;
                        }
                    }
                }
            }
            catch (System.NullReferenceException)
            {

                ExceptErr = false;

            }
            return isEmpty;
        }


        void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            try
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                   


                    e.ThrowException = false;
                }
            }
            catch (System.InvalidCastException)
            {
                MessageBox.Show("Wrong type of data" + "\n" + "Please, check fields");
            }


        }





        void ReadClients()
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            StreamReader clientsFile = new StreamReader(fs);
            clientBindingSource.Clear();//очищаем все хранящиеся данные
            while (!clientsFile.EndOfStream)
            {
                Client c = new Client();
                c.Read(clientsFile);
                clientBindingSource.Add(c);

            }
            clientsFile.Close();
        }
        void WriteClients()
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter clientsFile = new StreamWriter(fs);
            foreach (Client c in clientBindingSource.List)
            {
                c.Write(clientsFile);
            }
            clientsFile.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clientBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Client.IdiList.Clear();
            clientBindingSource.Clear();//очищаем все хранящиеся данные
            fileName = "";

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Client.IdiList.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                Client.IdiList.Clear();
               
                ReadClients();
            }

        }


        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 0;
            Boolean b = IsDataGridViewEmpty(dataGridView1);
            if (dataGridView1.Rows.Count - 1 == 0 || b || ExceptErr == false) count++;

            if (count == 0)
            {
                if (fileName == "")
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        fileName = saveFileDialog1.FileName;
                    }
                    else
                    {
                        return;
                    }
                }
                dataGridView1.EndEdit();
                WriteClients();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены, либо клиенты отсутсвуют");
                ExceptErr = true;
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 0;
            Boolean b = IsDataGridViewEmpty(dataGridView1);
            if (dataGridView1.Rows.Count - 1 == 0 || b || ExceptErr == false) count++;

            if (count == 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog1.FileName;
                    dataGridView1.EndEdit();
                    WriteClients();
                }

            }
            else
            {
                MessageBox.Show("Не все поля заполнены, либо клиенты отсутсвуют");
                ExceptErr = true;
            }
        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegClients_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите базу с клентами");
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                Client.IdiList.Clear();
                ReadClients();
            }

            DateTime d = DateTime.Today;
            dateTimePicker2.Value = d;
            dateTimePicker3.Value = d;
            dateTimePicker1.Value = new DateTime(d.Year, d.Month, 1);
          
            MessageBox.Show("После заполнения КАЖДОЙ строки, нажмите кнопку [ПРОВЕРКА]\nТаким образом вы избежите возможных ошибок");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Workers.IdiList.Clear();
            Boolean err = true;
            List<Client> client = clientData.FindAll(
delegate (Client client1)
{//анонимная функция для проверки условий выбора



    if (dateTimePicker2.Checked || dateTimePicker1.Checked)
    {
        if (dateTimePicker1.Value < dateTimePicker2.Value)
        {
            if (dateTimePicker2.Checked && client1.DateofDeparture > dateTimePicker2.Value)
                return false;
            if (dateTimePicker1.Checked && client1.DateofDeparture < dateTimePicker1.Value)
                return false;
        }
        else
        {

            err = false;
        }
    }


    if (checkBoxChoose1.Checked && textBox1.Text != "" && client1.RoomType != textBox1.Text) return false;
    if (checkBoxChoose2.Checked && textBox2.Text != "" && client1.Meal.ToString() != textBox2.Text) return false;
    if (checkBoxChoose3.Checked && textBox3.Text != "" && client1.Gender != textBox3.Text) return false;



    return true;


});


            for (int i = 0; i < client.Count; i++)
            {
                if (checkBoxSort1.Checked) client.Sort(
delegate (Client c1, Client c2)
{//анонимная функция для сравнения объектов Client
    int res = c1.DateofArival.CompareTo(c2.DateofArival);//сравнение по дате
    if (res == 0)
    {
        int res1 = c1.FirstName.CompareTo(c2.FirstName);//  сравнение по имени, если дата совпала
        if (res1 == 0)
        {
            int res2 = c1.LastName.CompareTo(c2.LastName); // по фамилии, если совпало имя
            if (res2 == 0)
            {
                int res3 = c1.ClientId.CompareTo(c2.ClientId);// по id, если совпала фамилия

                return res3;
            }
            else
            {
                return res2;
            }

        }
        else
        {
            return res1;
        }
    }
    else
    {
        return res;
    }
}

);
            }
            for (int i = 0; i < client.Count; i++)
            {
                if (checkBoxSort2.Checked) client.Sort(
delegate (Client c1, Client c2)
{//анонимная функция для сравнения объектов Client
    int res = c1.FirstName.CompareTo(c2.FirstName);//сравнение по имени
    if (res == 0)
    {
        int res1 = c1.LastName.CompareTo(c2.LastName);//  сравнение по фамилии, если имя совпало
        if (res1 == 0)
        {
            int res3 = c1.ClientId.CompareTo(c2.ClientId);// по id, если совпала фамилия

            return res3;
        }

        else
        {
            return res1;
        }
    }



    else
    {
        return res;
    }

}
);
            }
            for (int i = 0; i < client.Count; i++)
            {

                if (checkBoxSort3.Checked) client.Sort(
delegate (Client c1, Client c2)
{//анонимная функция для сравнения объектов Client
    int res = c1.LastName.CompareTo(c2.LastName);//сравнение по имени
    if (res == 0)
    {
        int res1 = c1.FirstName.CompareTo(c2.FirstName);//  сравнение по фамилии, если имя совпало
        if (res1 == 0)
        {
            int res3 = c1.ClientId.CompareTo(c2.ClientId);// по id, если совпала фамилия

            return res3;
        }
        else
        {
            return res1;
        }

    }
    else
    {
        return res;
    }

}
);
            }
            for (int i = 0; i < client.Count; i++)
            {
                if (checkBoxSort5.Checked) client.Sort(
       delegate (Client c1, Client c2)
       {//анонимная функция для сравнения объектов Client
           int res = c1.TotalCost.CompareTo(c2.TotalCost);
           if (res == 0)
           {
               int res3 = c1.ClientId.CompareTo(c2.ClientId);// по id, если совпала фамилия

               return res3;
           }

           else return res;

       });
            }

            for (int i = 0; i < client.Count; i++)
            {
                if (checkBoxSort6.Checked) client.Sort(
       delegate (Client c1, Client c2)
       {//анонимная функция для сравнения объектов Client
           int res3 = c1.ClientId.CompareTo(c2.ClientId);// по id, если совпала фамилия

           return res3;
       });
            }

            int count = 0;
            Boolean b = IsDataGridViewEmpty(dataGridView1);
            if (dataGridView1.Rows.Count - 1 == 0 || b || ExceptErr == false) count++;

            if (count == 0 && err)
            {
                Result f = new Result(client);
                f.Show();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены, либо клиенты отстутсвуют!");
                ExceptErr = true;
            }



        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxSort1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSort5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSort6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSort3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSort2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)

        {


            try
            {
                if (MessageBox.Show("Do you want to detete client?", "Remove client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[1].Value.ToString().Equals(textBoxClientDelete.Text))
                        {
                            int deletedId = Convert.ToInt32(textBoxClientDelete.Text);
                            int deletedRoom = Convert.ToInt32(row.Cells[11].Value);
                            
                            foreach (int i in Client.IdiList.ToArray())
                            {
                                if (i == deletedId)
                                {
                                    Client.IdiList.Remove(i);
                                }
                            }

                            dataGridView1.Rows.RemoveAt(row.Index);
                            break;
                        }
                    }

                }

                else
                {
                    MessageBox.Show("Client not removed", "Client was removed sucessfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("No selected client");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBoxMeal.Text = "";
            comboBoxRoom.Text = "";
            comboBoxS.Text = "";

        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegClients f = new RegClients();
            f.Show();

        }

        private void dataGridView1_CellContentClick_4(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCountOfClients_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCountOfClients_Click(object sender, EventArgs e)
        {

            int count = 0;
            Boolean b = IsDataGridViewEmpty(dataGridView1);
            if (dataGridView1.Rows.Count - 1 == 0 || b || ExceptErr == false) count++;

            if (count == 0)
            {

                textBoxCountOfClients.Text = clientData.Count.ToString();
            }
            else
            {

                MessageBox.Show("Не все поля заполнены, либо такого клиента нет");
                ExceptErr = true;
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegClients f = new RegClients();
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBoxRoom.Text;
        }

        private void comboBoxMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = comboBoxMeal.Text;
        }

        private void comboBoxS_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBoxS.Text;
        }

        private void номераToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<Room> rooms = new List<Room>();
            int count = 0;
            Boolean b = IsDataGridViewEmpty(dataGridView1);
            if (dataGridView1.Rows.Count - 1 == 0 || b || ExceptErr == false) count++;

            if (count == 0)
            {
                if (checkBoxRoomDate.Checked && dateTimePicker3.Checked)
                {

                    List<Client> client = clientData.FindAll(
    delegate (Client client1)
    {//анонимная функция для проверки условий выбора
        if (client1.DateofDeparture >= dateTimePicker3.Value && client1.DateofArival <= dateTimePicker3.Value)
        {
            return true;
        }
        else { return false; }




    });
                    if (client.Count == 0)
                    {
                        for (int i = 1; i < Client.sizeRooms; i++)
                        {
                            Room r = new Room();
                            r.roomNumber = i;
                            r.isFree = true;
                            rooms.Add(r);
                        }
                    }
                    else
                    {


                        Boolean f = true;
                        for (int i = 1; i < Client.sizeRooms; i++)
                        {
                            foreach (Client c in client)
                            {
                                Room r = new Room();
                                if (i == c.RoomNumber)
                                {

                                    r.roomNumber = i;
                                    r.isFree = false;
                                    f = false;
                                    rooms.Add(r);

                                    break;


                                }


                            }
                            if (f)
                            {
                                Room r1 = new Room();
                                r1.roomNumber = i;
                                r1.isFree = true;
                                rooms.Add(r1);



                            }
                            f = true;
                        }
                    }


                    ResultRoom res = new ResultRoom(rooms);
                    res.Show();
                }

                else
                {

                    MessageBox.Show("Не выбрана дата, за которую хотите посмотреть информацию  о номерах");

                   



                }

            }



            else
            {

                MessageBox.Show("Не все поля заполнены, либо такого клиента нет");
                ExceptErr = true;
            }
        }


        private void dataGridView1_CellContentClick_5(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Boolean b = true;
            Boolean k = false;
            Random random = new Random();
            for (int f = 0; f < clientData.Count; f++)
            {
                foreach (Client c in clientData)
                {
                    foreach (Client cl in clientData)
                    {
                        if (c.clientId == cl.clientId)
                        {
                            continue;
                        }
                        else
                        {
                            if (c.RoomNumber == cl.RoomNumber)
                            {
                                if (c.DateofArival >= cl.DateofDeparture || c.DateofArival < cl.DateofArival && c.DateofDeparture <= cl.DateofArival)
                                {
                                    continue;

                                }
                                else
                                {
                                    MessageBox.Show("This room is not available for this date");
                                    switch (c.RoomType)
                                    {
                                        case Room.typeOne:

                                            while (b)
                                            {
                                                if (c.DateofArival >= cl.DateofArival)
                                                {
                                                    int i = random.Next(100);
                                                    if (i != cl.RoomNumber)
                                                    {
                                                        c.RoomNumber = i;
                                                        b = false;
                                                        k = true;
                                                        
                                                    }
                                                }
                                                else
                                                {
                                                    if (c.DateofArival < cl.DateofArival)
                                                    {
                                                        int i = random.Next(100);
                                                        if (i != cl.RoomNumber)
                                                        {
                                                            cl.RoomNumber = i;
                                                            b = false;
                                                            k = true;
                                                            
                                                        }
                                                    }
                                                }


                                            }

                                            break;

                                        case Room.typeTwo:

                                            while (b)
                                            {
                                                if (c.DateofArival >= cl.DateofArival)
                                                {
                                                    int i = random.Next(101, 200);
                                                    if (i != cl.RoomNumber)
                                                    {
                                                        c.RoomNumber = i;
                                                        b = false;
                                                        k = true;
                                                        
                                                    }
                                                }
                                                else
                                                {
                                                    if (c.DateofArival < cl.DateofArival)
                                                    {
                                                        int i = random.Next(101, 200);
                                                        if (i != cl.RoomNumber)
                                                        {
                                                            cl.RoomNumber = i;
                                                            b = false;
                                                            k = true;
                                                        }
                                                    }
                                                }


                                            }


                                            break;
                                        case Room.typeThree:
                                            while (b)
                                            {
                                                if (c.DateofArival >= cl.DateofArival)
                                                {
                                                    int i = random.Next(201, 300);
                                                    if (i != cl.RoomNumber)
                                                    {
                                                        c.RoomNumber = i;
                                                        b = false;
                                                        k = true;
                                                    }
                                                }
                                                else
                                                {
                                                    if (c.DateofArival < cl.DateofArival)
                                                    {
                                                        int i = random.Next(201, 300);
                                                        if (i != cl.RoomNumber)
                                                        {
                                                            cl.RoomNumber = i;
                                                            b = false;
                                                            k = true;
                                                        }
                                                    }
                                                }


                                            }

                                            break;

                                    }
                                }


                            }
                        }
                        if (k) break;
                    }
                    if (k) break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                }
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex + 1].Cells[dataGridView1.CurrentCell.ColumnIndex];
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex + 1].Cells[dataGridView1.CurrentCell.ColumnIndex].Selected = true;
            }

            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Конец таблицы");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                }
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex - 1].Cells[dataGridView1.CurrentCell.ColumnIndex];
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex - 1].Cells[dataGridView1.CurrentCell.ColumnIndex].Selected = true;

            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Конец Таблицы");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[dataGridView1.ColumnCount - 1];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                }
                if (textBoxFindClient.Text != "")
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dataGridView1.Rows[i].Selected = false;

                        if (dataGridView1.Rows[i].Cells[1].Value != null)
                            if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(textBoxFindClient.Text))
                            {

                                dataGridView1.Rows[i].Selected = true;
                                dataGridView1.CurrentCell = dataGridView1[0, i];
                                break;

                            }
                    }
                }
            
    }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkersForm w = new WorkersForm();
            w.Show();
        }

        private void отчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean err = true;
            int count = 0;

            Boolean b = IsDataGridViewEmpty(dataGridView1);
            
            List<Client> client = clientData.FindAll(
delegate (Client client1)
{//анонимная функция для проверки условий выбора



    if (dateTimePicker2.Checked || dateTimePicker1.Checked)
    {
        if (dateTimePicker1.Value < dateTimePicker2.Value)
        {
            if (dateTimePicker2.Checked && client1.DateofArival > dateTimePicker2.Value)
                return false;
            if (dateTimePicker1.Checked && client1.DateofArival < dateTimePicker1.Value)
                return false;
        }
        else
        {

            err = false;
        }
    }


    if (checkBoxChoose1.Checked && textBox1.Text != "" && client1.RoomType != textBox1.Text) return false;
    if (checkBoxChoose2.Checked && textBox2.Text != "" && client1.Meal.ToString() != textBox2.Text) return false;
    if (checkBoxChoose3.Checked && textBox3.Text != "" && client1.Gender != textBox3.Text) return false;

    return true;


});
            if (dataGridView1.Rows.Count - 1 == 0 || b || err==false) count++;

            if (count == 0)
            {
                
                Report r = new Report(client);
                r.Show();

            }
            else
            {
               
                MessageBox.Show("Не все поля заполнены, либо такого клиента нет");
                
            }

        }

        private void оСистемеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationAboutSystem f = new InformationAboutSystem();
            f.Show();
        }

        
    }
}




        


    



   




