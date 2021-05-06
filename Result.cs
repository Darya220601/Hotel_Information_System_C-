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
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace HotelManagementSystem
{
    public partial class Result : Form
    {
        string fileName = "";
        List<Client> clientsData;
        static decimal totalExpensesForPeriod;
        static decimal profit;
        static DateTime minDateOfArrival;
        static DateTime maxDateOfDeparture;
        decimal sumExpensesSalary = 0;
        decimal sum = 0;
        int countofSingle = 0;
        int countOfDouble = 0;
        int countOfFamily = 0;
        decimal profitS = 0;
        decimal profitD = 0;
        decimal profitF = 0;

        public Result(List<Client> clients)
        {
            InitializeComponent();
            clientsData = clients;

        }
        void ReadWorkers()
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

        private void Result_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Выберете базу со своими сотрудниками");
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;


                ReadWorkers();
            }

            clientBindingSource.DataSource = clientsData;


            foreach (Client s in clientsData)
            {
                sum += s;
            }
            labelDohod.Text = "Доход гостиницы = " + sum.ToString() + "$";
            LabelCount.Text = "Кол-во клиентов = " + (dataGridView1.Rows.Count).ToString();



            foreach (Workers w in workersBindingSource)
            {
                sumExpensesSalary += w;
            }
            int middleCountOfDays = 30;
            decimal middleExpenses = (sumExpensesSalary + Workers.otherExpenses) / middleCountOfDays;
            minDateOfArrival = DateTime.MaxValue;
            maxDateOfDeparture = DateTime.MinValue;
            foreach (Client s in clientsData)
            {
                if (s.DateofArival < minDateOfArrival)
                {
                    minDateOfArrival = s.DateofArival;
                }
            }
            foreach (Client s in clientsData)
            {
                if (s.DateofDeparture > maxDateOfDeparture)
                {
                    maxDateOfDeparture = s.DateofDeparture;
                }
            }
            int countOfDays = (maxDateOfDeparture - minDateOfArrival).Days;
            totalExpensesForPeriod = countOfDays * middleExpenses;
            profit = sum - totalExpensesForPeriod;
            labelProfit.Text = "Чистая прибыль гостиницы = " + profit.ToString() + "$";
            labelExpensesforPeriod.Text = "Расходы за этот период = " + totalExpensesForPeriod.ToString() + "$";
            labelCountOfDaysForPeriod.Text = "Количество дней в рассматриваемом периоде = " + countOfDays;
            foreach (Client s in clientsData)
            {
                switch (s.RoomType)
                {
                    case Room.typeOne:
                        countofSingle++;
                        profitS +=s;
                        break;
                    case Room.typeTwo:
                        countOfDouble++;
                        profitD += s;
                        break;
                    case Room.typeThree:
                        countOfFamily++;
                        profitF += s;
                        break;
                }
            }
        }


        private void labelProfit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {







        }

        private void LabelCount_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.CurrentCell = dataGridView2.Rows[0].Cells[0];
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2.Rows[i].Selected = false;
                }
                dataGridView2.CurrentCell = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex - 1].Cells[dataGridView2.CurrentCell.ColumnIndex];
                dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex - 1].Cells[dataGridView2.CurrentCell.ColumnIndex].Selected = true;

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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView2.Rows[i].Selected = false;
                }
                dataGridView2.CurrentCell = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex + 1].Cells[dataGridView2.CurrentCell.ColumnIndex];
                dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex + 1].Cells[dataGridView2.CurrentCell.ColumnIndex].Selected = true;
            }

            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Конец таблицы");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[dataGridView1.ColumnCount - 1];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView2.CurrentCell = dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[dataGridView2.ColumnCount - 1];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Client s in clientsData)
            {
                if (s.DateofArival < minDateOfArrival)
                {
                    minDateOfArrival = s.DateofArival;
                }
            }
            
            foreach (Client s in clientsData)
            {
                if (s.DateofDeparture > maxDateOfDeparture)
                {
                    maxDateOfDeparture = s.DateofDeparture;
                }
            }
            Excel.Application app = new Excel.Application();
            app.Visible = true;
            Excel.Workbook wb = app.Workbooks.Add();
            Excel.Worksheet ws = wb.Worksheets[1];
            ws.Columns[1].ColumnWidth = 20;
            ws.Columns[2].ColumnWidth = 40;
            ws.Columns[3].ColumnWidth = 10;
            ws.Columns[4].ColumnWidth = 10;
            ws.Columns["A:D"].WrapText = true;
            Excel.Range rng = ws.Range["A1:D1"];
            ws.Cells[1, 1].value = "ОТЧЕТ О ДОХОДАХ ГОСТИНИЦЫ ЗА " +
           minDateOfArrival.ToShortDateString() +
            " - " + maxDateOfDeparture.ToShortDateString();
            rng.Font.Bold = true;
            rng.Font.Size = 14;
            rng.MergeCells = true;
            ws.Range["A1:D2"].HorizontalAlignment =
           Excel.Constants.xlCenter;
            ws.Cells[2, 1].value = "Id постояльца";
            ws.Cells[2, 2].value = "Дата приезда";
            ws.Cells[2, 3].value = "Дата отъезда";
            ws.Cells[2, 4].value = "Сумма";
            int i = 3;
            foreach (Client c in clientsData)
            {
                ws.Cells[i, 1].value = c.ClientId;
                ws.Cells[i, 2].value = c.DateofArival;
                ws.Cells[i, 3].value = c.DateofDeparture;
                ws.Cells[i, 4].value = c.TotalCost;
                i++;
            }
            ws.Cells[i, 1].value = "ИТОГО";
            ws.Range[ws.Cells[i, 1], ws.Cells[i, 3]].MergeCells =
           true;
            ws.Cells[i, 4].FormulaR1C1 = "=SUM(R[-" + (i - 3) +
           "]C:R[-1]C)";
            i++;
            ws.Cells[i, 1].value = "Количество Клиентов";
            ws.Range[ws.Cells[i, 1], ws.Cells[i, 3]].MergeCells =
          true;
            ws.Cells[i, 4].value = clientsData.Count().ToString()+" people";
            i++;
            ws.Cells[i, 1].value = "Расходы за этот период";
            ws.Range[ws.Cells[i, 1], ws.Cells[i, 3]].MergeCells =
          true;
            ws.Cells[i, 4].value = totalExpensesForPeriod.ToString() + "$";
            i++;
            ws.Cells[i, 1].value = "ПРИБЫЛЬ";
            ws.Range[ws.Cells[i, 1], ws.Cells[i, 3]].MergeCells =
          true;
            ws.Cells[i, 4].value = profit+"$";
            i++;
            ws.Cells[i, 1].value = "Кол-во занятых номеров типа single";
            ws.Range[ws.Cells[i, 1], ws.Cells[i, 3]].MergeCells =
          true;
            ws.Cells[i, 4].value = countofSingle.ToString();
            i++;
            ws.Cells[i, 1].value = "Кол-во занятых номеров типа double";
            ws.Range[ws.Cells[i, 1], ws.Cells[i, 3]].MergeCells =
          true;
            ws.Cells[i, 4].value = countOfDouble.ToString();
            i++;
            ws.Cells[i, 1].value = "Кол-во занятых номеров типа family";
            ws.Range[ws.Cells[i, 1], ws.Cells[i, 3]].MergeCells =
          true;
            ws.Cells[i, 4].value = countOfFamily.ToString();
            

            rng = ws.Range[ws.Cells[2, 1], ws.Cells[i, 4]];
            rng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle =
           Excel.XlLineStyle.xlContinuous;
            rng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle =
           Excel.XlLineStyle.xlContinuous;
            rng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle =
           Excel.XlLineStyle.xlContinuous;
            rng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle =
           Excel.XlLineStyle.xlContinuous;

            rng.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle =
            Excel.XlLineStyle.xlContinuous;

            rng.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle =
Excel.XlLineStyle.xlContinuous;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Word.Application app = new Word.Application();
            app.Visible = true;
            Word.Document doc = app.Documents.Add();
            app.Selection.Font.Name = "Times New Roman";
            app.Selection.Font.Size = 14;
            app.Selection.Font.Bold = 1;
            app.Selection.TypeText("ОТЧЕТ О ПРОДАЖАХ ЗА " +
           minDateOfArrival.ToShortDateString() +
            " - " + maxDateOfDeparture.ToShortDateString());
            app.Selection.ParagraphFormat.Alignment =
           Word.WdParagraphAlignment.wdAlignParagraphCenter;
            app.Selection.TypeParagraph();
            app.Selection.ParagraphFormat.Alignment =
           Word.WdParagraphAlignment.wdAlignParagraphLeft;
            app.Selection.Font.Bold = 0;
            Word.Table t = doc.Tables.Add(app.Selection.Range, 1, 4);
            Object style = "Сетка таблицы";
            t.set_Style(style);
            Object unit = Word.WdUnits.wdCell;
            app.Selection.TypeText("Id клиента");
            app.Selection.MoveRight(unit);
            app.Selection.TypeText("Дата приезда");
            app.Selection.MoveRight(unit);
            app.Selection.TypeText("Дата отъезда");
            app.Selection.MoveRight(unit);
            app.Selection.TypeText("Сумма");
            
            foreach (Client r in clientsData)
            {
                app.Selection.MoveRight(unit);
                app.Selection.TypeText(r.ClientId.ToString());
                app.Selection.MoveRight(unit);
                app.Selection.TypeText(r.DateofArival.ToShortDateString());
                app.Selection.MoveRight(unit);

                app.Selection.TypeText(r.DateofDeparture.ToShortDateString());
                app.Selection.MoveRight(unit);
                app.Selection.TypeText(r.TotalCost.ToString());
            }
            app.Selection.MoveRight(unit);
            app.Selection.TypeText("ИТОГО");
            app.Selection.MoveRight(unit);
            app.Selection.MoveRight(unit);
            app.Selection.MoveRight(unit);
            app.Selection.TypeText(sum.ToString()+"$");
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (checkBoxDiagram.Checked)
            {
                DiagramMore d2 = new DiagramMore(profitS, profitD, profitF);
                d2.Show();
            }
            else
            {
                Diagram d = new Diagram(countofSingle, countOfDouble, countOfFamily);
                d.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

