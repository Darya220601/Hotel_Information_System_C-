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

namespace HotelManagementSystem
{
    public partial class WorkersForm : Form
    {
        public static Boolean ExceptErr = true;
        string fileName = "";
        public static List<Workers> workersData = new List<Workers>();
        public WorkersForm()
        {
            InitializeComponent();
            workersBindingSource.DataSource = workersData;

            dataGridView1.DataError += new DataGridViewDataErrorEventHandler(DataGridView1_DataError);
        }
        void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            try
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    // ((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Add(value);


                    e.ThrowException = false;
                }
            }
            catch (System.InvalidCastException)
            {
                MessageBox.Show("Wrong type of data" + "\n" + "Please, check fields");
            }


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
        void  ReadWorkers()
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            StreamReader workersFile = new StreamReader(fs);
            workersBindingSource.Clear();//очищаем все хранящиеся данные
            while (!workersFile.EndOfStream)
            {
                Workers w = new Workers();
                w.Read(workersFile);
                workersBindingSource.Add(w);

            }
            workersFile.Close();
        }
        void WriteWorkers()
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter workersFile = new StreamWriter(fs);
            foreach (Workers c in workersBindingSource.List)
            {
                c.Write(workersFile);
            }
            workersFile.Close();
        }
        private void WorkersForm_Load(object sender, EventArgs e)
        {
            Workers.IdiList.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                
               
                ReadWorkers();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workers.IdiList.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                ReadWorkers();
            }

        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workers.IdiList.Clear();
            
            workersBindingSource.Clear();
         //очищаем все хранящиеся данные
            fileName = "";

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
                WriteWorkers();
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
                    WriteWorkers();
                }

            }
            else
            {
                MessageBox.Show("Не все поля заполнены, либо клиенты отсутсвуют");
                ExceptErr = true;
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

        private void textBoxFindClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCountOfClients_Click(object sender, EventArgs e)
        {
            int count = 0;
            Boolean b = IsDataGridViewEmpty(dataGridView1);
            if (dataGridView1.Rows.Count - 1 == 0 || b || ExceptErr == false) count++;

            if (count == 0)
            {


                textBoxCountOfWorkers.Text = workersData.Count.ToString();
            }
            else
            {

                MessageBox.Show("Не все поля заполнены, либо такого клиента нет");
                ExceptErr = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to detete client?", "Remove client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[1].Value.ToString().Equals(textBoxWorkerDelete.Text))
                        {
                            int deletedId = Convert.ToInt32(textBoxWorkerDelete.Text);
                           

                            foreach (int i in Workers.IdiList.ToArray())
                            {
                                if (i == deletedId)
                                {
                                    Workers.IdiList.Remove(i);
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBoxGender.Text = "";
            comboBoxPosition.Text = "";
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
              if (textBoxSumm.Text.Trim() != "")
                {
                try
                {
                    Workers.otherExpenses = Convert.ToInt32(textBoxSumm.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Wrong format");
                }
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            List<Workers> worker = workersData.FindAll(
delegate (Workers worker1)
{
    if (checkBoxChoosePosition.Checked && textBox1.Text != "" && worker1.WorkPosition != textBox1.Text) return false;
    if (checkBoxChooseGender.Checked && textBox2.Text != "" && worker1.Gender != textBox2.Text) return false;

    return true;

});
            for (int i = 0; i < worker.Count; i++)
            {
                if (checkBoxSort1.Checked) worker.Sort(
delegate (Workers c1, Workers c2)
{//анонимная функция для сравнения объектов Workers
    int res = c1.WorkerID.CompareTo(c2.WorkerID);//сравнение по id
    return res;

});
            }
            for (int i = 0; i < worker.Count; i++)
            {
                if (checkBoxSort2.Checked) worker.Sort(
delegate (Workers c1, Workers c2)
{ 
    int res = c1.FirstName.CompareTo(c2.FirstName);//сравнение по имени
    if (res == 0)
    {
        int res1 = c1.WorkerID.CompareTo(c2.WorkerID); // сравнение по id
        return res1;
    }
    else
    {
        return res;
    }

});
            }
            for (int i = 0; i < worker.Count; i++)
            {
                if (checkBoxSalary.Checked) worker.Sort(
delegate (Workers c1, Workers c2)
{
    int res = c1.Salary.CompareTo(c2.Salary);//сравнение по имени
    
        return res;
    

});
            }
            int count = 0;
            Boolean b = IsDataGridViewEmpty(dataGridView1);
            if (dataGridView1.Rows.Count - 1 == 0 || b || ExceptErr == false) count++;

            if (count == 0)
            {
                ResultWorkers r = new ResultWorkers(worker);
                r.Show();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены, либо клиенты отстутсвуют!");
                ExceptErr = true;
            }
        }

        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBoxPosition.Text;
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = comboBoxGender.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
            }
            if (textBoxFindWorker.Text != "")
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;

                    if (dataGridView1.Rows[i].Cells[1].Value != null)
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(textBoxFindWorker.Text))
                        {

                            dataGridView1.Rows[i].Selected = true;
                            dataGridView1.CurrentCell = dataGridView1[0, i];
                            break;

                        }
                }
            }
        }
    }
}
